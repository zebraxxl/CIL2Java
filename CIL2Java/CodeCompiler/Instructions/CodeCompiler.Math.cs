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

        private void CompileDivUn(ILExpression e, ExpectType expect)
        {
            if (!Program.Unsigned)
            {
                CompileMath(e, expect, OpCodes.idiv, OpCodes.ldiv, OpCodes.fdiv, OpCodes.ddiv);
                return;
            }

            InterType opType = resolver.Resolve(e.InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType jp = JavaHelpers.InterTypeToJavaPrimitive(opType);

            if ((jp == JavaPrimitiveType.Bool) || (jp == JavaPrimitiveType.Byte) || (jp == JavaPrimitiveType.Char) ||
                (jp == JavaPrimitiveType.Short))
            {
                //this types are already growed up to int
                CompileExpression(e.Arguments[0], ExpectType.Primitive);
                CompileExpression(e.Arguments[1], ExpectType.Primitive);
                codeGenerator.Add(OpCodes.idiv);
            }
            else if (jp == JavaPrimitiveType.Int)
            {
                //grow up int to long
                CompileExpression(e.Arguments[0], ExpectType.Primitive);
                codeGenerator
                    .Add(OpCodes.i2l, null, e)
                    .AddLongConst(0xffffffff, e)
                    .Add(OpCodes.land, e);

                CompileExpression(e.Arguments[0], ExpectType.Primitive);
                codeGenerator
                    .Add(OpCodes.i2l, null, e)
                    .AddLongConst(0xffffffff, e)
                    .Add(OpCodes.land, e);

                codeGenerator
                    .Add(OpCodes.ldiv, e)
                    .Add(OpCodes.l2i);
            }
            else if (jp == JavaPrimitiveType.Long)
            {
                //call special method from corlib
                CompileExpression(e.Arguments[0], ExpectType.Primitive);
                CompileExpression(e.Arguments[1], ExpectType.Primitive);
                resolver.Resolve(ClassNames.CIL2JavaVESInstructions.ClassName);
                codeGenerator.Add(OpCodes.invokestatic, ClassNames.CIL2JavaVESInstructions.UInt64DivideRef);
            }
            else
                throw new Exception();  //TODO: Normal error
            
            TranslateType(opType, expect, e);
        }

        private void CompileRem(ILExpression e, ExpectType expect)
        {
            CompileMath(e, expect, OpCodes.irem, OpCodes.lrem, OpCodes.frem, OpCodes.frem);
        }

        private void CompileRemUn(ILExpression e, ExpectType expect)
        {
            if (!Program.Unsigned)
            {
                CompileMath(e, expect, OpCodes.irem, OpCodes.lrem, OpCodes.frem, OpCodes.drem);
                return;
            }

            InterType opType = resolver.Resolve(e.InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType jp = JavaHelpers.InterTypeToJavaPrimitive(opType);

            if ((jp == JavaPrimitiveType.Bool) || (jp == JavaPrimitiveType.Byte) || (jp == JavaPrimitiveType.Char) ||
                (jp == JavaPrimitiveType.Short))
            {
                //this types are already growed up to int
                CompileExpression(e.Arguments[0], ExpectType.Primitive);
                CompileExpression(e.Arguments[1], ExpectType.Primitive);
                codeGenerator.Add(OpCodes.irem);
            }
            else if (jp == JavaPrimitiveType.Int)
            {
                //grow up int to long
                CompileExpression(e.Arguments[0], ExpectType.Primitive);
                codeGenerator
                    .Add(OpCodes.i2l, null, e)
                    .AddLongConst(0xffffffff, e)
                    .Add(OpCodes.land, e);

                CompileExpression(e.Arguments[0], ExpectType.Primitive);
                codeGenerator
                    .Add(OpCodes.i2l, null, e)
                    .AddLongConst(0xffffffff, e)
                    .Add(OpCodes.land, e);

                codeGenerator
                    .Add(OpCodes.lrem, e)
                    .Add(OpCodes.l2i);
            }
            else if (jp == JavaPrimitiveType.Long)
            {
                //call special method from corlib
                CompileExpression(e.Arguments[0], ExpectType.Primitive);
                CompileExpression(e.Arguments[1], ExpectType.Primitive);
                resolver.Resolve(ClassNames.CIL2JavaVESInstructions.ClassName);
                codeGenerator.Add(OpCodes.invokestatic, ClassNames.CIL2JavaVESInstructions.UInt64RemainderRef);
            }
            else
                throw new Exception();  //TODO: Normal error

            TranslateType(opType, expect, e);
        }

        private void CompileAnd(ILExpression e, ExpectType expect)
        {
            CompileMath(e, expect, OpCodes.iand, OpCodes.land, OpCodes.fsub, OpCodes.dsub);
        }

        private void CompileOr(ILExpression e, ExpectType expect)
        {
            CompileMath(e, expect, OpCodes.ior, OpCodes.lor, OpCodes.fadd, OpCodes.dadd);
        }

        private void CompileXor(ILExpression e, ExpectType expect)
        {
            CompileMath(e, expect, OpCodes.ixor, OpCodes.lxor, OpCodes.fconst_0, OpCodes.dconst_0);
        }

        private void CompileShl(ILExpression e, ExpectType expect)
        {
            CompileMath(e, expect, OpCodes.ishl, OpCodes.lshl, OpCodes.fconst_0, OpCodes.dconst_0);
        }

        private void CompileShr(ILExpression e, ExpectType expect)
        {
            CompileMath(e, expect, OpCodes.ishr, OpCodes.lshr, OpCodes.fconst_0, OpCodes.dconst_0);
        }

        private void CompileShrUn(ILExpression e, ExpectType expect)
        {
            CompileMath(e, expect, OpCodes.iushr, OpCodes.lushr, OpCodes.fconst_0, OpCodes.dconst_0);
        }

        private void CompileNeg(ILExpression e, ExpectType expect)
        {
            CompileExpression(e.Arguments[0], ExpectType.Primitive);

            InterType opType = resolver.Resolve(e.InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType jp = JavaHelpers.InterTypeToJavaPrimitive(opType);

            OpCodes opcode = OpCodes.ineg;

            switch (jp)
            {
                case JavaPrimitiveType.Long: opcode = OpCodes.lneg; break;
                case JavaPrimitiveType.Float: opcode = OpCodes.fneg; break;
                case JavaPrimitiveType.Double: opcode = OpCodes.dneg; break;

                case JavaPrimitiveType.Ref:
                    throw new Exception();  //TODO: normal error
            }

            codeGenerator.Add(opcode, null, e);

            TranslateType(opType, expect, e);
        }

        private void CompileNot(ILExpression e, ExpectType expect)
        {
            CompileExpression(e.Arguments[0], ExpectType.Primitive);

            InterType opType = resolver.Resolve(e.InferredType, thisMethod.FullGenericArguments);
            JavaPrimitiveType jp = JavaHelpers.InterTypeToJavaPrimitive(opType);

            if (jp == JavaPrimitiveType.Long)
            {
                codeGenerator
                    .AddLongConst(-1L, e)
                    .Add(OpCodes.lxor, null, e);
            }
            else
            {
                codeGenerator
                    .Add(OpCodes.iconst_m1, null, e)
                    .Add(OpCodes.ixor, null, e);
            }

            TranslateType(opType, expect, e);
        }
    }
}
