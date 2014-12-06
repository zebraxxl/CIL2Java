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
    }
}
