using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileConvI4(ILExpression e, ExpectType expect)
        {
            InterType gettedType = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType gettedJava = JavaHelpers.InterTypeToJavaPrimitive(gettedType);

            CompileExpression(e.Arguments[0], ExpectType.Any);

            switch (gettedJava)
            {
                case JavaPrimitiveType.Double:
                    codeGenerator.Add(Java.OpCodes.d2i, null, e);
                    break;

                case JavaPrimitiveType.Float:
                    codeGenerator.Add(Java.OpCodes.f2i, null, e);
                    break;

                case JavaPrimitiveType.Long:
                    codeGenerator.Add(Java.OpCodes.l2i, null, e);
                    break;
            }

            TranslateType(InterType.PrimitiveTypes[(int)PrimitiveType.Int32], expect, e);
        }
    }
}
