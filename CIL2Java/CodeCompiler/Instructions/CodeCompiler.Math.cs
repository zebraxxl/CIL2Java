using CIL2Java.Java;
using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileMath(ILExpression e, ExpectType expect, OpCodes intOp, OpCodes longOp, OpCodes floatOp, OpCodes doubleOp)
        {
            CompileExpression(e.Arguments[0], ExpectType.Primitive);
            CompileExpression(e.Arguments[1], ExpectType.Primitive);

            InterType opType = resolver.Resolve(e.InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType jp = JavaHelpers.InterTypeToJavaPrimitive(opType);

            OpCodes opcode = intOp;

            switch (jp)
            {
                case JavaPrimitiveType.Long: opcode = longOp; break;
                case JavaPrimitiveType.Float: opcode = floatOp; break;
                case JavaPrimitiveType.Double: opcode = doubleOp; break;

                case JavaPrimitiveType.Ref:
                    throw new Exception();  //TODO: normal error
            }

            codeGenerator.Add(opcode, null, e);

            TranslateType(opType, expect, e);
        }

        private void CompileAdd(ILExpression e, ExpectType expect)
        {
            CompileMath(e, expect, OpCodes.iadd, OpCodes.ladd, OpCodes.fadd, OpCodes.dadd);
        }

        private void CompileMul(ILExpression e, ExpectType expect)
        {
            CompileMath(e, expect, OpCodes.imul, OpCodes.lmul, OpCodes.fmul, OpCodes.dmul);
        }
    }
}
