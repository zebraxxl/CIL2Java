using CIL2Java.Java;
using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileConvIU1(ILExpression e, ExpectType expect)
        {
            InterType gettedType = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType gettedJava = JavaHelpers.InterTypeToJavaPrimitive(gettedType);

            CompileExpression(e.Arguments[0], ExpectType.Any);

            switch (gettedJava)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                    break;

                case JavaPrimitiveType.Short:
                case JavaPrimitiveType.Char:
                case JavaPrimitiveType.Int:
                    codeGenerator.Add(Java.OpCodes.i2b, e);
                    break;

                case JavaPrimitiveType.Long:
                    codeGenerator.Add(Java.OpCodes.l2i, e).Add(Java.OpCodes.i2b, e);
                    break;

                case JavaPrimitiveType.Float:
                    codeGenerator.Add(Java.OpCodes.f2i, e).Add(Java.OpCodes.i2b, e);
                    break;

                case JavaPrimitiveType.Double:
                    codeGenerator.Add(Java.OpCodes.d2i, e).Add(Java.OpCodes.i2b, e);
                    break;

                default:
                    Messages.Message(MessageCode.CantConvertType, gettedType.Fullname, "sbyte");
                    return;
            }

            PrimitiveType pt = e.Code == ILCode.Conv_U1 ? PrimitiveType.Byte : PrimitiveType.SByte;
            TranslateType(InterType.PrimitiveTypes[(int)pt], expect, e);
        }

        private void CompileConvIU2(ILExpression e, ExpectType expect)
        {
            InterType gettedType = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType gettedJava = JavaHelpers.InterTypeToJavaPrimitive(gettedType);

            CompileExpression(e.Arguments[0], ExpectType.Any);

            switch (gettedJava)
            {
                case JavaPrimitiveType.Bool:
                case JavaPrimitiveType.Byte:
                    codeGenerator.Add(Java.OpCodes.i2s, e);
                    break;

                case JavaPrimitiveType.Short:
                case JavaPrimitiveType.Char:
                    break;

                case JavaPrimitiveType.Int:
                    codeGenerator.Add(Java.OpCodes.i2s, e);
                    break;

                case JavaPrimitiveType.Long:
                    codeGenerator.Add(Java.OpCodes.l2i, e).Add(Java.OpCodes.i2s, e);
                    break;

                case JavaPrimitiveType.Float:
                    codeGenerator.Add(Java.OpCodes.f2i, e).Add(Java.OpCodes.i2s, e);
                    break;

                case JavaPrimitiveType.Double:
                    codeGenerator.Add(Java.OpCodes.d2i, e).Add(Java.OpCodes.i2s, e);
                    break;

                default:
                    Messages.Message(MessageCode.CantConvertType, gettedType.Fullname, "sbyte");
                    return;
            }

            PrimitiveType pt = e.Code == ILCode.Conv_U2 ? PrimitiveType.UInt16 : PrimitiveType.Int16;
            TranslateType(InterType.PrimitiveTypes[(int)pt], expect, e);
        }

        private void CompileConvIU4(ILExpression e, ExpectType expect)
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
                    break;

                case JavaPrimitiveType.Long:
                    codeGenerator.Add(Java.OpCodes.l2i, e);
                    break;

                case JavaPrimitiveType.Float:
                    codeGenerator.Add(Java.OpCodes.f2i, e);
                    break;

                case JavaPrimitiveType.Double:
                    codeGenerator.Add(Java.OpCodes.d2i, e);
                    break;

                default:
                    Messages.Message(MessageCode.CantConvertType, gettedType.Fullname, "sbyte");
                    return;
            }

            PrimitiveType pt = e.Code == ILCode.Conv_U4 ? PrimitiveType.UInt32 : PrimitiveType.Int32;
            TranslateType(InterType.PrimitiveTypes[(int)pt], expect, e);
        }

        private void CompileConvIU8(ILExpression e, ExpectType expect)
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
                    codeGenerator.Add(Java.OpCodes.i2l, e);
                    break;

                case JavaPrimitiveType.Long:
                    break;

                case JavaPrimitiveType.Float:
                    codeGenerator.Add(Java.OpCodes.f2l, e);
                    break;

                case JavaPrimitiveType.Double:
                    codeGenerator.Add(Java.OpCodes.d2l, e);
                    break;

                default:
                    Messages.Message(MessageCode.CantConvertType, gettedType.Fullname, "sbyte");
                    return;
            }

            PrimitiveType pt = e.Code == ILCode.Conv_U8 ? PrimitiveType.UInt64 : PrimitiveType.Int64;
            TranslateType(InterType.PrimitiveTypes[(int)pt], expect, e);
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
