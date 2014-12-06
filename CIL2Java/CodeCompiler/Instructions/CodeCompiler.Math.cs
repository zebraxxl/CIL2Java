using CIL2Java.Java;
using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler.ILAst;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompilePostIncrement(ILExpression e, ExpectType expect)
        {
            int incVal = (int)e.Operand;
            e = e.Arguments[0];
            //TODO: PostIncrement for long and other types

            if (e.Code == ILCode.Ldloca)
            {
                int varIndex = GetVarIndex((ILVariable)e.Operand);

                codeGenerator
                    .AddLoad(JavaPrimitiveType.Int, varIndex, e)
                    .Add(OpCodes.dup, null, e)
                    .AddIntConst(incVal, e)
                    .Add(OpCodes.iadd, null, e)
                    .AddStore(JavaPrimitiveType.Int, varIndex, e);
            }
            else if (e.Code == ILCode.Ldsflda)
            {
                InterField operand = resolver.Resolve((FieldReference)e.Operand, thisMethod.FullGenericArguments);

                CompileFieldLoad(operand, e);
                codeGenerator
                    .Add(OpCodes.dup, null, e)
                    .AddIntConst(incVal, e)
                    .Add(OpCodes.iadd, null, e);
                CompileFieldStore(operand, e);
            }
            else if (e.Code == ILCode.Ldflda)
            {
                InterField operand = resolver.Resolve((FieldReference)e.Operand, thisMethod.FullGenericArguments);

                int tmpVar = GetNextFreeVar(JavaPrimitiveType.Int);

                CompileExpression(e.Arguments[0], ExpectType.Reference);    //this

                codeGenerator.Add(OpCodes.dup, null, e);
                CompileFieldLoad(operand, e);
                codeGenerator
                    .Add(OpCodes.dup, null, e)
                    .AddStore(JavaPrimitiveType.Int, tmpVar, e)
                    .AddIntConst(incVal, e)
                    .Add(OpCodes.iadd, null, e);
                CompileFieldStore(operand, e);
                codeGenerator
                    .AddLoad(JavaPrimitiveType.Int, tmpVar, e);

                FreeVar(tmpVar, JavaPrimitiveType.Int);
            }
            else
                throw new Exception();  //TODO: another supported postincrements. 
                                        // See ICSharpCode.Decompiler\ILAst\PeepholeTransform.cs:IntroducePostIncrement
        }

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

        private void CompileSub(ILExpression e, ExpectType expect)
        {
            CompileMath(e, expect, OpCodes.isub, OpCodes.lsub, OpCodes.fsub, OpCodes.dsub);
        }

        private void CompileMul(ILExpression e, ExpectType expect)
        {
            CompileMath(e, expect, OpCodes.imul, OpCodes.lmul, OpCodes.fmul, OpCodes.dmul);
        }

        private void CompileDiv(ILExpression e, ExpectType expect)
        {
            CompileMath(e, expect, OpCodes.idiv, OpCodes.ldiv, OpCodes.fdiv, OpCodes.ddiv);
        }
    }
}
