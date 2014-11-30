using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

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

        private void CompileCall(ILExpression e, ExpectType expect)
        {
            InterMethod operand = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

            if ((Program.BoxType == BoxingType.Java) && (operand.DeclaringType.Fullname == ClassNames.CorlibUtils) &&
                (operand.Name == ClassNames.ReboxMethod))
            {
                //Skip CIL2Java.Utils::Rebox in java boxing mode due optimizations
                CompileExpression(e.Arguments[0], expect);
                return;
            }

            if ((operand.IsConstructor) && (operand.DeclaringType.IsValueType) && (operand.Parameters.Count < e.Arguments.Count))
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
                CompileExpression(e.Arguments[argIndex++], ExpectType.Reference);

            foreach (InterParameter param in operand.Parameters)
                CompileExpression(e.Arguments[argIndex++], GetExpectType(param));

            CallType callType = CallType.Virtual;

            if (operand.IsStatic)
                callType = CallType.Static;
            else if (operand.DeclaringType.IsInterface)
                callType = CallType.Interface;
            else if ((operand.IsConstructor) || (operand.IsPrivate) ||
                ((operand.IsSame(thisMethod)) && (thisMethod.DeclaringType.IsSuper(operand.DeclaringType))))
                callType = CallType.Special;

            Java.Constant javaOperand = null;

            if (callType == CallType.Interface)
                javaOperand = new Java.Constants.InterfaceMethodRef(
                    namesController.TypeNameToJava(operand.DeclaringType.Fullname),
                    namesController.MethodNameToJava(operand.Name),
                    namesController.GetMethodDescriptor(operand));
            else
                javaOperand = new Java.Constants.MethodRef(
                    namesController.TypeNameToJava(operand.DeclaringType.Fullname),
                    namesController.MethodNameToJava(operand.Name),
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
    }
}
