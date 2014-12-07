using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileCastclass(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            CompileExpression(e.Arguments[0], expect);

            codeGenerator.Add(Java.OpCodes.checkcast, new Java.Constants.Class(namesController.TypeNameToJava(operand)), e);
        }

        private void CompileNewobj(ILExpression e, ExpectType expect)
        {
            InterMethod ctor = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

            if (ctor.DeclaringType.IsArray)
                CompileNewmultiarray(e, expect);
            else
            {
                Java.Constants.Class declTypeClassRef = new Java.Constants.Class(
                    namesController.TypeNameToJava(ctor.DeclaringType));

                codeGenerator
                    .Add(Java.OpCodes._new, declTypeClassRef, e)
                    .Add(Java.OpCodes.dup, null, e);

                CompileCall(e, expect);
            }
        }

        private void CompileStobj(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            if (operand.IsValueType)
            {
                // stobj(destPtr, src) compiling to
                // src.CopyTo(destPtr)
                CompileExpression(e.Arguments[1], ExpectType.Any);
                CompileExpression(e.Arguments[0], ExpectType.ByRef);

                MethodRef copyToRef = new MethodRef(namesController.TypeNameToJava(operand),
                    ClassNames.ValueTypeCopyTo, "(" + namesController.GetFieldDescriptor(operand) + ")V");

                bool needDup = ((e.ExpectedType != null) && (expect != ExpectType.None));
                if (needDup)
                    codeGenerator.Add(Java.OpCodes.dup_x1, null, e);

                codeGenerator.Add(Java.OpCodes.invokevirtual, copyToRef, e);
            }
            else
            {
                // From ECMA-335, III.4.29
                // The stobj instruction copies the value src to the address dest. If typeTok is not
                // a generic parameter and either a reference type or a built-in value class, then 
                // the stind instruction provides a shorthand for the stobj instruction.
                CompileStind(e, expect);
            } 
        }

        private void CompileLdobj(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            if ((operand.IsPrimitive) && (e.Arguments[0].Code == ILCode.Ldloc) &&
                (((ILVariable)e.Arguments[0].Operand).Name == "this"))
            {
                //Special treatment. Value for primitive types
                codeGenerator
                    .Add(Java.OpCodes.aload_0, null, e)
                    .Add(Java.OpCodes.getfield, new Java.Constants.FieldRef(
                        namesController.TypeNameToJava(operand.CILBoxType), "value",
                        namesController.GetFieldDescriptor(operand)), e);
            }
            else if (operand.IsValueType)
            {
                CompileExpression(e.Arguments[0], ExpectType.ByRef);
                MethodRef getCopyRef = new MethodRef(namesController.TypeNameToJava(operand),
                    ClassNames.ValueTypeGetCopy, "()" + namesController.GetFieldDescriptor(operand));

                codeGenerator.Add(Java.OpCodes.invokevirtual, getCopyRef, e);
            }
            else
            {
                // From ECMA-335, III.4.29
                // If typeTok is not a generic parameter and either a reference type or a built-in value
                // class, then the ldind instruction provides a shorthand for the ldobj instruction.
                CompileLdind(e, expect);
            }
        }

        private void CompileCpobj(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);
            // dst = arg[0]
            // src = arg[1]


            if (operand.IsValueType)
            {
                CompileExpression(e.Arguments[1], ExpectType.ByRef);
                CompileExpression(e.Arguments[0], ExpectType.ByRef);
                codeGenerator.Add(Java.OpCodes.invokevirtual, new MethodRef(
                    namesController.TypeNameToJava(operand),
                    ClassNames.ValueTypeCopyTo,
                    "(" + namesController.GetFieldDescriptor(operand) + ")V"), e);
            }
            else
            {
                CompileExpression(new ILExpression(ILCode.Ldind_Ref, e.Operand, e.Arguments[1]), ExpectType.Any);
                CompileExpression(new ILExpression(ILCode.Stind_Ref, e.Operand, e.Arguments[0]), expect);
            }
        }

        private void CompileIsinst(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            CompileExpression(e.Arguments[0], ExpectType.Reference);

            //  dup
            //  instanceof operand
            //  ifne :end
            //  pop
            //  aconst_null
            //:end

            string endLabel = rnd.Next().ToString() + "end";

            Java.Constants.Class operandRef = new Java.Constants.Class(namesController.TypeNameToJava(GetBoxType(operand)));

            codeGenerator
                .Add(Java.OpCodes.dup, null, e)
                .Add(Java.OpCodes.instanceof, operandRef, e)
                .Add(Java.OpCodes.ifne, endLabel, e)
                .Add(Java.OpCodes.pop, null, e)
                .Add(Java.OpCodes.aconst_null, null, e)
                .Label(endLabel);
        }

        private void CompileBox(ILExpression e, ExpectType expect)
        {
            CompileExpression(e.Arguments[0], ExpectType.Boxed);
        }

        private void CompileUnbox(ILExpression e, ExpectType expect)
        {
            // By standart, we must compute a ref to value type from it boxed representation
            // But in CIL2Java boxed value type is ref to it
            CompileExpression(e.Arguments[0], ExpectType.Any);
        }

        private void CompileUnbox_Any(ILExpression e, ExpectType expect)
        {
            CompileExpression(e.Arguments[0], ExpectType.Boxed);

            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);
            string boxType = GetBoxType(operand);

            Java.Constants.Class operandRef = new Java.Constants.Class(namesController.TypeNameToJava(boxType));

            Java.Constants.MethodRef valueRef;

            if (operand.IsValueType)
            {
                valueRef = new Java.Constants.MethodRef(operandRef.Value, ClassNames.ValueTypeGetCopy, "()" +
                    namesController.GetFieldDescriptor(operand));
            }
            else if (operand.IsEnum)
            {
                valueRef = new MethodRef(operandRef.Value, ClassNames.EnumGetUnboxedMethodName,
                    "()" + namesController.GetFieldDescriptor(operand.ElementType));
            }
            else
            {
                valueRef = new Java.Constants.MethodRef(operandRef.Value,
                    Utils.GetJavaTypeName(operand.PrimitiveType) + "Value",
                    "()" + namesController.GetFieldDescriptor(operand));
            }

            codeGenerator
                .Add(Java.OpCodes.checkcast, operandRef, e)
                .Add(Java.OpCodes.invokevirtual, valueRef, e);
        }
    }
}
