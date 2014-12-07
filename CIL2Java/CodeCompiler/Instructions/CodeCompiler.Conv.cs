using CIL2Java.Java;
using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileCheckOvf(ILExpression e, JavaPrimitiveType from, long mask, double minValue, double maxValue)
        {
            string labelsSufix = rnd.Next().ToString();
            string noOvfLabel = "noOvfLabel" + labelsSufix;
            string hasOvfLabel = "ovfLabel" + labelsSufix;

            string overflowJavaTypeName = namesController.TypeNameToJava(ClassNames.OverflowExceptionTypeName);

            switch (from)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Short:
                case JavaPrimitiveType.Int:
                    codeGenerator
                        .Add(OpCodes.dup, null, e)
                        .AddIntConst(~unchecked((int)mask))
                        .Add(OpCodes.iand)
                        .Add(OpCodes.ifeq, noOvfLabel, e)
                        .Add(OpCodes._new, new Java.Constants.Class(overflowJavaTypeName), e)
                        .Add(OpCodes.dup, null, e)
                        .Add(OpCodes.invokespecial, new MethodRef(overflowJavaTypeName, ClassNames.JavaConstructorMethodName, "()V"), e)
                        .Add(OpCodes.athrow, null, e)
                        .Label(noOvfLabel);
                    break;

                case JavaPrimitiveType.Long:
                    codeGenerator
                        .Add(OpCodes.dup2, null, e)
                        .AddLongConst(~mask, e)
                        .Add(OpCodes.land, null, e)
                        .Add(OpCodes.iconst_0, null, e)
                        .Add(OpCodes.lcmp, null, e)
                        .Add(OpCodes.ifeq, noOvfLabel, e)
                        .Add(OpCodes._new, new Java.Constants.Class(overflowJavaTypeName), e)
                        .Add(OpCodes.dup, null, e)
                        .Add(OpCodes.invokespecial, new MethodRef(overflowJavaTypeName, ClassNames.JavaConstructorMethodName, "()V"), e)
                        .Add(OpCodes.athrow, null, e)
                        .Label(noOvfLabel);
                    break;

                case JavaPrimitiveType.Float:
                    codeGenerator
                        .Add(OpCodes.dup, null, e)
                        .AddFloatConst((float)minValue, e)
                        .Add(OpCodes.fcmpg, null, e)
                        .Add(OpCodes.iflt, hasOvfLabel, e)
                        .Add(OpCodes.dup, null, e)
                        .AddFloatConst((float)maxValue, e)
                        .Add(OpCodes.fcmpg, null, e)
                        .Add(OpCodes.ifgt, hasOvfLabel, e)
                        .Add(OpCodes._goto, noOvfLabel, e)
                        .Label(hasOvfLabel)
                        .Add(OpCodes._new, new Java.Constants.Class(overflowJavaTypeName), e)
                        .Add(OpCodes.dup, null, e)
                        .Add(OpCodes.invokespecial, new MethodRef(overflowJavaTypeName, ClassNames.JavaConstructorMethodName, "()V"), e)
                        .Add(OpCodes.athrow, null, e)
                        .Label(noOvfLabel);
                    break;

                case JavaPrimitiveType.Double:
                    codeGenerator
                        .Add(OpCodes.dup2, null, e)
                        .AddDoubleConst(minValue, e)
                        .Add(OpCodes.dcmpg, null, e)
                        .Add(OpCodes.iflt, hasOvfLabel, e)
                        .Add(OpCodes.dup2, null, e)
                        .AddDoubleConst(maxValue, e)
                        .Add(OpCodes.dcmpg, null, e)
                        .Add(OpCodes.ifgt, hasOvfLabel, e)
                        .Add(OpCodes._goto, noOvfLabel, e)
                        .Label(hasOvfLabel)
                        .Add(OpCodes._new, new Java.Constants.Class(overflowJavaTypeName), e)
                        .Add(OpCodes.dup, null, e)
                        .Add(OpCodes.invokespecial, new MethodRef(overflowJavaTypeName, ClassNames.JavaConstructorMethodName, "()V"), e)
                        .Add(OpCodes.athrow, null, e)
                        .Label(noOvfLabel);
                    break;

                default: throw new Exception(); //In valid IL code this never must happend
            }
        }

        private void CompileConvTo1(ILExpression e, ExpectType expect)
        {
            InterType gettedType = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType gettedJava = JavaHelpers.InterTypeToJavaPrimitive(gettedType);

            CompileExpression(e.Arguments[0], ExpectType.Any);

            bool isToUnsigned = e.Code.IsConvToUnsigned();
            bool isFromUnsigned = e.Code.IsConvFromUnsigned();
            bool isOvf = e.Code.IsConvOvf();

            if (isOvf)
            {
                long mask = 0xffL;
                double minValue = (double)sbyte.MinValue;
                double maxValue = (double)sbyte.MaxValue;

                if (isToUnsigned)
                {
                    minValue = (double)byte.MinValue;
                    maxValue = (double)byte.MaxValue;
                }

                if ((isToUnsigned && !isFromUnsigned) || (!isToUnsigned && isFromUnsigned))
                    mask = 0x7fL;
                CompileCheckOvf(e, gettedJava, mask, minValue, maxValue);
            }

            switch (gettedJava)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                    break;

                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Short:
                    codeGenerator.Add(OpCodes.i2b, null, e);
                    break;

                case JavaPrimitiveType.Int:
                    codeGenerator.Add(OpCodes.i2b, null, e);
                    break;

                case JavaPrimitiveType.Long:
                    codeGenerator.Add(OpCodes.l2i, null, e).Add(OpCodes.i2b, null, e);
                    break;

                case JavaPrimitiveType.Float:
                    codeGenerator.Add(OpCodes.f2i, null, e).Add(OpCodes.i2b, null, e);
                    break;

                case JavaPrimitiveType.Double:
                    codeGenerator.Add(OpCodes.d2i, null, e).Add(OpCodes.i2b, null, e);
                    break;

                default: throw new Exception(); //TODO: Normal error
            }

            TranslateType(InterType.PrimitiveTypes[(int)(isToUnsigned ? PrimitiveType.Byte : PrimitiveType.SByte)], expect, e);
        }

        private void CompileConvTo2(ILExpression e, ExpectType expect)
        {
            InterType gettedType = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType gettedJava = JavaHelpers.InterTypeToJavaPrimitive(gettedType);

            CompileExpression(e.Arguments[0], ExpectType.Any);

            bool isToUnsigned = e.Code.IsConvToUnsigned();
            bool isFromUnsigned = e.Code.IsConvFromUnsigned();
            bool isOvf = e.Code.IsConvOvf();

            if (isOvf)
            {
                long mask = 0xffffL;
                double minValue = (double)short.MinValue;
                double maxValue = (double)short.MaxValue;

                if (isToUnsigned)
                {
                    minValue = (double)ushort.MinValue;
                    maxValue = (double)ushort.MaxValue;
                }

                if ((isToUnsigned && !isFromUnsigned) || (!isToUnsigned && isFromUnsigned))
                    mask = 0x7fffL;
                CompileCheckOvf(e, gettedJava, mask, minValue, maxValue);
            }

            switch (gettedJava)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                    codeGenerator.Add(OpCodes.i2s, null, e);
                    break;

                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Short:
                    break;

                case JavaPrimitiveType.Int:
                    codeGenerator.Add(OpCodes.i2s, null, e);
                    break;

                case JavaPrimitiveType.Long:
                    codeGenerator.Add(OpCodes.l2i, null, e).Add(OpCodes.i2s, null, e);
                    break;

                case JavaPrimitiveType.Float:
                    codeGenerator.Add(OpCodes.f2i, null, e).Add(OpCodes.i2s, null, e);
                    break;

                case JavaPrimitiveType.Double:
                    codeGenerator.Add(OpCodes.d2i, null, e).Add(OpCodes.i2s, null, e);
                    break;

                default: throw new Exception(); //TODO: Normal error
            }

            TranslateType(InterType.PrimitiveTypes[(int)(isToUnsigned ? PrimitiveType.UInt16 : PrimitiveType.Int16)], expect, e);
        }

        private void CompileConvTo4(ILExpression e, ExpectType expect)
        {
            InterType gettedType = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType gettedJava = JavaHelpers.InterTypeToJavaPrimitive(gettedType);

            CompileExpression(e.Arguments[0], ExpectType.Any);

            bool isToUnsigned = e.Code.IsConvToUnsigned();
            bool isFromUnsigned = e.Code.IsConvFromUnsigned();
            bool isOvf = e.Code.IsConvOvf();

            if (isOvf)
            {
                long mask = 0xffffffffL;
                double minValue = (double)int.MinValue;
                double maxValue = (double)int.MaxValue;

                if (isToUnsigned)
                {
                    minValue = (double)uint.MinValue;
                    maxValue = (double)uint.MaxValue;
                }

                if ((isToUnsigned && !isFromUnsigned) || (!isToUnsigned && isFromUnsigned))
                    mask = 0x7fffffffL;
                CompileCheckOvf(e, gettedJava, mask, minValue, maxValue);
            }

            switch (gettedJava)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Short:
                case JavaPrimitiveType.Int:
                    break;

                case JavaPrimitiveType.Long:
                    codeGenerator.Add(OpCodes.l2i, null, e);
                    break;

                case JavaPrimitiveType.Float:
                    codeGenerator.Add(OpCodes.f2i, null, e);
                    break;

                case JavaPrimitiveType.Double:
                    codeGenerator.Add(OpCodes.d2i, null, e);
                    break;

                default: throw new Exception(); //TODO: Normal error
            }

            TranslateType(InterType.PrimitiveTypes[(int)(isToUnsigned ? PrimitiveType.UInt32 : PrimitiveType.Int32)], expect, e);
        }

        private void CompileConvTo8(ILExpression e, ExpectType expect)
        {
            InterType gettedType = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType gettedJava = JavaHelpers.InterTypeToJavaPrimitive(gettedType);

            CompileExpression(e.Arguments[0], ExpectType.Any);

            bool isToUnsigned = e.Code.IsConvToUnsigned();
            bool isFromUnsigned = e.Code.IsConvFromUnsigned();
            bool isOvf = e.Code.IsConvOvf();

            if (isOvf)
            {
                long mask = unchecked((long)0xffffffffffffffffL);
                double minValue = (double)long.MinValue;
                double maxValue = (double)long.MaxValue;

                if (isToUnsigned)
                {
                    minValue = (double)ulong.MinValue;
                    maxValue = (double)ulong.MaxValue;
                }

                if ((isToUnsigned && !isFromUnsigned) || (!isToUnsigned && isFromUnsigned))
                    mask = 0x7fffffffffffffffL;
                CompileCheckOvf(e, gettedJava, mask, minValue, maxValue);
            }

            switch (gettedJava)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Short:
                case JavaPrimitiveType.Int:
                    codeGenerator.Add(OpCodes.i2l, null, e);
                    break;

                case JavaPrimitiveType.Long:
                    break;

                case JavaPrimitiveType.Float:
                    codeGenerator.Add(OpCodes.f2l, null, e);
                    break;

                case JavaPrimitiveType.Double:
                    codeGenerator.Add(OpCodes.d2l, null, e);
                    break;

                default: throw new Exception(); //TODO: Normal error
            }

            TranslateType(InterType.PrimitiveTypes[(int)(isToUnsigned ? PrimitiveType.UInt64 : PrimitiveType.Int64)], expect, e);
        }

        private void CompileConvR4(ILExpression e, ExpectType expect)
        {
            InterType gettedType = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType gettedJava = JavaHelpers.InterTypeToJavaPrimitive(gettedType);

            CompileExpression(e.Arguments[0], ExpectType.Any);

            switch (gettedJava)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                case JavaPrimitiveType.Short:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Int:
                    codeGenerator.Add(Java.OpCodes.i2f, e);
                    break;

                case JavaPrimitiveType.Long:
                    codeGenerator.Add(Java.OpCodes.l2f, e);
                    break;

                case JavaPrimitiveType.Float:
                    break;

                case JavaPrimitiveType.Double:
                    codeGenerator.Add(Java.OpCodes.d2f, e);
                    break;

                default:
                    Messages.Message(MessageCode.CantConvertType, gettedType.Fullname, "sbyte");
                    return;
            }

            TranslateType(InterType.PrimitiveTypes[(int)PrimitiveType.Single], expect, e);
        }

        private void CompileConvR8(ILExpression e, ExpectType expect)
        {
            InterType gettedType = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType gettedJava = JavaHelpers.InterTypeToJavaPrimitive(gettedType);

            CompileExpression(e.Arguments[0], ExpectType.Any);

            switch (gettedJava)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                case JavaPrimitiveType.Short:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Int:
                    codeGenerator.Add(Java.OpCodes.i2d, e);
                    break;

                case JavaPrimitiveType.Long:
                    codeGenerator.Add(Java.OpCodes.l2d, e);
                    break;

                case JavaPrimitiveType.Float:
                    codeGenerator.Add(Java.OpCodes.f2d, e);
                    break;

                case JavaPrimitiveType.Double:
                    break;

                default:
                    Messages.Message(MessageCode.CantConvertType, gettedType.Fullname, "sbyte");
                    return;
            }

            TranslateType(InterType.PrimitiveTypes[(int)PrimitiveType.Double], expect, e);
        }

        private void CompileConvRUn(ILExpression e, ExpectType expect)
        {
            InterType gettedType = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType gettedJava = JavaHelpers.InterTypeToJavaPrimitive(gettedType);

            CompileExpression(e.Arguments[0], ExpectType.Any);

            switch (gettedJava)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                case JavaPrimitiveType.Short:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Int:
                    codeGenerator
                        .Add(Java.OpCodes.i2l, e)
                        .AddLongConst(0xffffffffL, e)
                        .Add(Java.OpCodes.land, e)
                        .Add(Java.OpCodes.l2d);
                    break;

                case JavaPrimitiveType.Long:
                    int tmpVar = GetNextFreeVar(JavaPrimitiveType.Int);

                    // Pseudocode (ulong value -> double result):
                    // int bit = ((int)value) & 0x01;
                    // double result = (double)(value >>> 1)
                    // result *= 2
                    // result += (double)bit
                    codeGenerator
                        .Add(OpCodes.dup2, null, e)                 //save original value for future
                        .Add(OpCodes.l2i, null, e)
                        .Add(OpCodes.iconst_1, null, e)
                        .Add(OpCodes.iand, null, e)                 //get last bit of value
                        .AddStore(JavaPrimitiveType.Int, tmpVar, e) //and save it. Now in stack original value.
                        .Add(OpCodes.iconst_1, null, e)
                        .Add(OpCodes.lushr, null, e)                //unsigned divide value by 2 to make it positive
                        .Add(OpCodes.l2d, null, e)                  //convert it to double = value / 2
                        .AddDoubleConst(2.0, e)
                        .Add(OpCodes.dmul, null, e)                 //and multiple double by 2 to restore original value
                        .AddLoad(JavaPrimitiveType.Int, tmpVar, e)  //restore last bit of original value
                        .Add(OpCodes.i2d, null, e)
                        .Add(OpCodes.dadd, null, e);                // and add it to result double


                    FreeVar(tmpVar, JavaPrimitiveType.Int);
                    break;

                default:
                    throw new Exception();  //This never must be happend in valid IL code
            }

            InterType resultType = InterType.PrimitiveTypes[(int)PrimitiveType.Double];
            InterType expected = resolver.Resolve(e.ExpectedType, thisMethod.FullGenericArguments);
            if (expected.PrimitiveType == PrimitiveType.Single)
            {
                codeGenerator.Add(OpCodes.d2f, null, e);
                resultType = expected;
            }

            TranslateType(resultType, expect, e);
        }
    }
}
