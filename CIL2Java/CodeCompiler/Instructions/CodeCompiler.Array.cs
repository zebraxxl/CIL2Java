using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileNewarr(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);
            InterType element = operand;
            if (element.IsArray) element = element.ElementType;

            Java.Constants.Class operandRef = new Java.Constants.Class(namesController.TypeNameToJava(element.Fullname));
            MethodRef valueTypeInitRef = new MethodRef(operandRef.Value, ClassNames.JavaConstructorMethodName, "()V");

            JavaArrayType arrayType = JavaHelpers.InterTypeToJavaArrayType(operand);

            if (e.Code == ILCode.Newarr)
            {
                CompileExpression(e.Arguments[0], ExpectType.Primitive);
            }
            else
            {
                if (operand.Dimesnsions[0].LowerBound != 0)
                    Messages.Message(MessageCode.NotZeroLowerBound, operand.Fullname);
                codeGenerator.AddIntConst(operand.Dimesnsions[0].UpperBound.Value, e);
            }

            if (arrayType == JavaArrayType.Ref)
            {
                codeGenerator.Add(Java.OpCodes.anewarray, operandRef, e);
            }
            else
                codeGenerator.AddNewArray(arrayType, e);

            if (e.Code == ILCode.InitArray)
            {
                for (int i = 0; i < e.Arguments.Count; i++)
                {
                    if ((e.Arguments[i].Code == ILCode.DefaultValue) && (!element.IsValueType))
                        continue;

                    codeGenerator.Add(Java.OpCodes.dup, null, e);
                    codeGenerator.AddIntConst(i, e);

                    if (e.Arguments[i].Code != ILCode.DefaultValue)
                        CompileExpression(e.Arguments[i], GetExpectType(element));
                    else
                        codeGenerator
                            .Add(Java.OpCodes._new, operandRef, e)
                            .Add(Java.OpCodes.dup, null, e)
                            .Add(Java.OpCodes.invokespecial, valueTypeInitRef, e);

                    codeGenerator.AddArrayStore(arrayType, e);
                }
            }
            else if (element.IsValueType)
            {
                int arrayTmpStore = GetNextFreeVar(JavaPrimitiveType.Ref);
                int arrayLengthTmp = GetNextFreeVar(JavaPrimitiveType.Int);

                string labelPrefix = rnd.Next().ToString();
                string loopLabel = labelPrefix + "loop";
                string endLabel = labelPrefix + "end";

                codeGenerator
                    .AddStore(JavaPrimitiveType.Ref, arrayTmpStore, e)
                    .AddLoad(JavaPrimitiveType.Ref, arrayTmpStore, e)
                    .Add(Java.OpCodes.arraylength, null, e)
                    .AddStore(JavaPrimitiveType.Int, arrayLengthTmp, e)

                    // while (arrayLengthTmp > 0) arrayTmpStore[--arrayLengthTmp] = new valType();
                    .Label(loopLabel)
                    .AddLoad(JavaPrimitiveType.Int, arrayLengthTmp, e)
                    .Add(Java.OpCodes.ifle, endLabel, e)
                    .AddIInc((ushort)arrayLengthTmp, -1, e)
                    .AddLoad(JavaPrimitiveType.Ref, arrayTmpStore, e)
                    .AddLoad(JavaPrimitiveType.Int, arrayLengthTmp, e)
                    .Add(Java.OpCodes._new, operandRef, e)
                    .Add(Java.OpCodes.dup, null, e)
                    .Add(Java.OpCodes.invokespecial, valueTypeInitRef, e)
                    .Add(Java.OpCodes.aastore, null, e)
                    .Add(Java.OpCodes._goto, loopLabel, e)
                    .Label(endLabel)


                    .AddLoad(JavaPrimitiveType.Ref, arrayTmpStore, e);

                FreeVar(arrayTmpStore, JavaPrimitiveType.Ref);
                FreeVar(arrayLengthTmp, JavaPrimitiveType.Int);
            }
        }

        private void CompileStelem(ILExpression e, ExpectType expect)
        {
            TypeReference typeRef = e.Operand as TypeReference ?? e.InferredType;
            InterType operand = resolver.Resolve(typeRef, thisMethod.FullGenericArguments);
            JavaArrayType arrType = JavaHelpers.InterTypeToJavaArrayType(operand);

            CompileExpression(e.Arguments[0], ExpectType.Reference);    //array
            CompileExpression(e.Arguments[1], ExpectType.Primitive);    //index
            CompileExpression(e.Arguments[2], GetExpectType(operand));  //value

            codeGenerator.AddArrayStore(arrType, e);
        }

        private void CompileLdelem(ILExpression e, ExpectType expect)
        {
            TypeReference typeRef = e.Operand as TypeReference ?? e.InferredType;
            InterType operand = resolver.Resolve(typeRef, thisMethod.FullGenericArguments);
            JavaArrayType arrType = JavaHelpers.InterTypeToJavaArrayType(operand);

            CompileExpression(e.Arguments[0], ExpectType.Reference);    //array
            CompileExpression(e.Arguments[1], ExpectType.Primitive);    //index

            codeGenerator.AddArrayLoad(arrType, e);

            TranslateType(operand, expect, e);
        }

        private void CompileNewmultiarray(ILExpression e, ExpectType expect)
        {
            InterMethod ctor = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);
            InterType arrType = ctor.DeclaringType;

            for (int i = 0; i < arrType.ArrayRank; i++)
                CompileExpression(e.Arguments[i], ExpectType.Primitive);

            //TODO: lower and apper bounds

            codeGenerator.AddMultianewarray(new Java.Constants.Class(namesController.GetFieldDescriptor(arrType)),
                (byte)arrType.ArrayRank);
        }

        private void CompileArrayCall(ILExpression e, ExpectType expect)
        {
            InterMethod operand = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

            CompileExpression(e.Arguments[0], ExpectType.Reference);    //array
            CompileExpression(e.Arguments[1], ExpectType.Primitive);    //first index

            for (int i = 0; i < operand.DeclaringType.ArrayRank - 1; i++)
            {
                codeGenerator.Add(Java.OpCodes.aaload, null, e);
                CompileExpression(e.Arguments[i + 2], ExpectType.Primitive);
            }

            if (operand.Name == "Set")
                CompileArraySet(e, expect);
            else if (operand.Name == "Get")
                CompileArrayGet(e, expect);
        }

        private void CompileArraySet(ILExpression e, ExpectType expect)
        {
            InterMethod operand = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

            CompileExpression(e.Arguments.Last(), GetExpectType(operand.DeclaringType.ElementType));

            JavaArrayType arrType = JavaHelpers.InterTypeToJavaArrayType(operand.DeclaringType);
            codeGenerator.AddArrayStore(arrType, e);
        }

        private void CompileArrayGet(ILExpression e, ExpectType expect)
        {
            InterMethod operand = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

            JavaArrayType arrType = JavaHelpers.InterTypeToJavaArrayType(operand.DeclaringType);
            codeGenerator.AddArrayLoad(arrType, e);
        }
    }
}
