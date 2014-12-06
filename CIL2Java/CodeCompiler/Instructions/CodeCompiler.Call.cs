﻿using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private enum CallType
        {
            Static,
            Special,
            Interface,
            Virtual
        }

        private void CompileMonitorEnter(ILExpression e)
        {
            CompileExpression(e.Arguments[0], ExpectType.Reference);
            codeGenerator.Add(Java.OpCodes.monitorenter, null, e);

            if (e.Arguments.Count > 1)
            {
                ILExpression flagArg = e.Arguments[1];

                if (flagArg.Code == ILCode.Ldloca)
                    CompileExpression(new ILExpression(ILCode.Stloc, flagArg.Operand, new ILExpression(ILCode.Ldc_I4, 1)), ExpectType.None);
                else if (flagArg.Code == ILCode.Ldsflda)
                    CompileExpression(new ILExpression(ILCode.Stsfld, flagArg.Operand, new ILExpression(ILCode.Ldc_I4, 1)), ExpectType.None);
                else if (flagArg.Code == ILCode.Ldflda)
                    CompileExpression(new ILExpression(ILCode.Stfld, flagArg.Operand, flagArg.Arguments[0], new ILExpression(ILCode.Ldc_I4, 1)), ExpectType.None);
                else
                {
                    CompileExpression(new ILExpression(ILCode.Stind_Ref, flagArg.InferredType.GetElementType(),
                        flagArg), ExpectType.None);
                }
            }
        }

        private void CompileMonitorExit(ILExpression e)
        {
            CompileExpression(e.Arguments[0], ExpectType.Reference);
            codeGenerator.Add(Java.OpCodes.monitorexit);
        }

        private void CompileCall(ILExpression e, ExpectType expect)
        {
            InterMethod operand = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

            if (operand.DeclaringType.Fullname == ClassNames.SystemThreadingMonitor.ClassName)
            {
                if (operand.Name == ClassNames.SystemThreadingMonitor.Enter)
                {
                    CompileMonitorEnter(e);
                    return;
                }

                if (operand.Name == ClassNames.SystemThreadingMonitor.Exit)
                {
                    CompileMonitorExit(e);
                    return;
                }
            }

            if ((Program.BoxType == BoxingType.Java) && (operand.DeclaringType.Fullname == ClassNames.CorlibUtils) &&
                (operand.Name == ClassNames.ReboxMethod))
            {
                //Skip CIL2Java.Utils::Rebox in java boxing mode due optimizations
                CompileExpression(e.Arguments[0], expect);
                return;
            }

            if ((operand.IsConstructor) && (operand.DeclaringType.IsValueType) && (operand.Parameters.Count < e.Arguments.Count)
                && (!thisMethod.IsConstructor))
            {
                // rebuild nodes from `call ctor(getVar(), [params])` to
                // setVar(newObj([params])

                ILExpression getVar = e.Arguments[0];
                e.Arguments.RemoveAt(0);
                e.Code = ILCode.Newobj;
                getVar.Code = LoadVarInvert[getVar.Code];
                getVar.Arguments.Add(e);
                CompileExpression(getVar, ExpectType.Any);

                return;
            }

            if (operand.DeclaringType.IsArray)
            {
                CompileArrayCall(e, expect);
                return;
            }

            int argIndex = 0;
            if ((operand.HasThis) && (operand.Parameters.Count < e.Arguments.Count))
            {
                if (e.Prefixes != null)
                {
                    ILExpressionPrefix constrained = e.Prefixes.Where(P => P.Code == ILCode.Constrained).FirstOrDefault();
                    if (constrained != null)
                    {
                        InterType thisType = resolver.Resolve((TypeReference)constrained.Operand, thisMethod.FullGenericArguments);

                        if (thisType.IsPrimitive)
                        {
                            e.Arguments[argIndex].Code = GetAddrInvert[e.Arguments[argIndex].Code];
                            e.Arguments[argIndex] = new ILExpression(ILCode.Box, null, e.Arguments[argIndex]);
                        }
                    }
                }

                CompileExpression(e.Arguments[argIndex++], ExpectType.Reference);
            }

            foreach (InterParameter param in operand.Parameters)
                CompileExpression(e.Arguments[argIndex++], GetExpectType(param));

            if (operand.DeclaringType.Fullname == ClassNames.Intrinsics.ClassName)
            {
                if (operand.Name == ClassNames.Intrinsics.monitorenter)
                    codeGenerator.Add(Java.OpCodes.monitorenter, null, e);
                if (operand.Name == ClassNames.Intrinsics.monitorexit)
                    codeGenerator.Add(Java.OpCodes.monitorexit, null, e);
                return;
            }

            CallType callType = CallType.Virtual;

            if (operand.IsStatic)
                callType = CallType.Static;
            else if (operand.DeclaringType.IsInterface)
                callType = CallType.Interface;
            else if ((operand.IsConstructor) || (operand.IsPrivate) ||
                ((operand.IsSame(thisMethod)) && (thisMethod.DeclaringType.BaseType == operand.DeclaringType)))
                callType = CallType.Special;

            Java.Constant javaOperand = null;

            if (callType == CallType.Interface)
                javaOperand = new Java.Constants.InterfaceMethodRef(
                    namesController.TypeNameToJava(operand.DeclaringType),
                    namesController.MethodNameToJava(operand.NewName),
                    namesController.GetMethodDescriptor(operand));
            else
                javaOperand = new Java.Constants.MethodRef(
                    namesController.TypeNameToJava(operand.DeclaringType),
                    namesController.MethodNameToJava(operand.NewName),
                    namesController.GetMethodDescriptor(operand));

            switch (callType)
            {
                case CallType.Interface:
                    codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.invokeinterface, javaOperand, e));
                    break;

                case CallType.Special:
                    codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.invokespecial, javaOperand, e));
                    break;

                case CallType.Static:
                    codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.invokestatic, javaOperand, e));
                    break;

                case CallType.Virtual:
                    codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.invokevirtual, javaOperand, e));
                    break;
            }

            OnRestoreLocalByRefs();

            if ((!operand.ReturnParameter.Type.IsPrimitive) || (operand.ReturnParameter.Type.PrimitiveType != PrimitiveType.Void) ||
                (operand.ReturnParameter.IsBoxed) || (operand.ReturnParameter.IsJavaBoxed))
            TranslateType(operand.ReturnParameter.Type, expect, e);
        }

        private void CompileRet(ILExpression e, ExpectType expect)
        {
            InterType returnType = thisMethod.ReturnParameter.Type;
            ExpectType returnExpect = GetExpectType(thisMethod.ReturnParameter);

            if ((returnExpect == ExpectType.Primitive) && (returnType.PrimitiveType == PrimitiveType.Void))
            {
                codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes._return, null, e));
            }
            else
            {
                CompileExpression(e.Arguments[0], returnExpect);
                codeGenerator.AddReturn(JavaHelpers.InterTypeToJavaPrimitive(returnType), e);
            }
        }

        private void CompileJmp(ILExpression e, ExpectType expect)
        {
            int argIndex = 0;
            if (thisMethod.HasThis)
            {
                codeGenerator.Add(Java.OpCodes.aload_0, null, e);
                argIndex++;
            }

            for (int i = 0; i < thisMethod.Parameters.Count; i++)
            {
                JavaPrimitiveType jp = JavaHelpers.InterTypeToJavaPrimitive(thisMethod.Parameters[i].Type);
                codeGenerator.AddLoad(jp, argIndex++);
                if (jp.IsDoubleSlot())
                    argIndex++;
            }

            InterMethod operand = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

            CallType callType = CallType.Virtual;

            if (operand.IsStatic)
                callType = CallType.Static;
            else if (operand.DeclaringType.IsInterface)
                callType = CallType.Interface;
            else if ((operand.IsConstructor) || (operand.IsPrivate) ||
                ((operand.IsSame(thisMethod)) && (thisMethod.DeclaringType.BaseType == operand.DeclaringType)))
                callType = CallType.Special;

            Java.Constant javaOperand = null;

            if (callType == CallType.Interface)
                javaOperand = new Java.Constants.InterfaceMethodRef(
                    namesController.TypeNameToJava(operand.DeclaringType),
                    namesController.MethodNameToJava(operand.NewName),
                    namesController.GetMethodDescriptor(operand));
            else
                javaOperand = new Java.Constants.MethodRef(
                    namesController.TypeNameToJava(operand.DeclaringType),
                    namesController.MethodNameToJava(operand.NewName),
                    namesController.GetMethodDescriptor(operand));

            switch (callType)
            {
                case CallType.Interface:
                    codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.invokeinterface, javaOperand, e));
                    break;

                case CallType.Special:
                    codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.invokespecial, javaOperand, e));
                    break;

                case CallType.Static:
                    codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.invokestatic, javaOperand, e));
                    break;

                case CallType.Virtual:
                    codeGenerator.AddInstruction(new JavaInstruction(Java.OpCodes.invokevirtual, javaOperand, e));
                    break;
            }

            codeGenerator.AddReturn(JavaHelpers.InterTypeToJavaPrimitive(thisMethod.ReturnParameter.Type));
        }
    }
}
