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
        private void CompileLoopOrSwitchBreak(ILExpression e, ExpectType expect)
        {
            if (loopOrSwitchExitLabel.Count == 0)
                Messages.Message(MessageCode.LoopOpcodeFoundedOutsideLoop, e.Code.ToString());
            else
                codeGenerator.Add(OpCodes._goto, loopOrSwitchExitLabel.Peek(), e);
        }

        private void CompileLoopContinue(ILExpression e, ExpectType expect)
        {
            if (loopContinueLabel.Count == 0)
                Messages.Message(MessageCode.LoopOpcodeFoundedOutsideLoop, e.Code.ToString());
            else
                codeGenerator.Add(OpCodes._goto, loopContinueLabel.Peek(), e);
        }

        private void CompileBr(ILExpression e, ExpectType expect)
        {
            codeGenerator.Add(Java.OpCodes._goto, ((ILLabel)e.Operand).Name , e);
        }

        private void CompileBreak(ILExpression e, ExpectType expect)
        {
            if (Program.CompileBreak)
                codeGenerator.Add(Java.OpCodes.breakpoint, null, e);
        }

        private void CompileNop(ILExpression e, ExpectType expect)
        {
        }

        private void CompileCkfinite(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);

            CompileExpression(e.Arguments[0], ExpectType.Primitive);

            if (operand.PrimitiveType == PrimitiveType.Double)
                codeGenerator.Add(OpCodes.invokestatic, ClassNames.CIL2JavaVESInstructions.CkfiniteDoubleRef, e);
            else if (operand.PrimitiveType == PrimitiveType.Single)
                codeGenerator.Add(OpCodes.invokestatic, ClassNames.CIL2JavaVESInstructions.CkfiniteFloatRef, e);
            else throw new Exception(); //In valid CIL code this never will happed
        }

        private void CompileLocalloc(ILExpression e, ExpectType expect)
        {
            Messages.Message(MessageCode.UnsafeInstruction, e.Code.ToString());

            CompileExpression(e.Arguments[0], ExpectType.Primitive);
            codeGenerator.AddNewArray(JavaArrayType.Byte, e);
        }

        private void CompileCpblk(ILExpression e, ExpectType expect)
        {
            Messages.Message(MessageCode.UnsafeInstruction, e.Code.ToString());

            CompileExpression(e.Arguments[0], ExpectType.Reference);
            CompileExpression(e.Arguments[1], ExpectType.Reference);
            CompileExpression(e.Arguments[2], ExpectType.Primitive);

            codeGenerator.Add(OpCodes.invokestatic, ClassNames.CIL2JavaVESInstructions.CpblkRef, e);
        }

        private void CompileInitblk(ILExpression e, ExpectType expect)
        {
            Messages.Message(MessageCode.UnsafeInstruction, e.Code.ToString());

            CompileExpression(e.Arguments[0], ExpectType.Reference);
            CompileExpression(e.Arguments[1], ExpectType.Primitive);
            CompileExpression(e.Arguments[2], ExpectType.Primitive);

            codeGenerator.Add(OpCodes.invokestatic, ClassNames.CIL2JavaVESInstructions.InitblkRef, e);
        }

        private void CompileSizeof(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            codeGenerator.AddIntConst(GetSize(operand));
        }

        private int GetSize(InterType operand)
        {
            if (operand.IsEnum)
                operand = operand.ElementType;

            if (operand.IsPrimitive)
            {
                switch (operand.PrimitiveType)
                {
                    case PrimitiveType.Bool:
                    case PrimitiveType.Byte:
                    case PrimitiveType.SByte:
                        return 1;

                    case PrimitiveType.Char:
                    case PrimitiveType.Int16:
                    case PrimitiveType.UInt16:
                        return 2;

                    case PrimitiveType.Int32:
                    case PrimitiveType.UInt32:
                    case PrimitiveType.Single:
                        return 4;

                    case PrimitiveType.Int64:
                    case PrimitiveType.UInt64:
                    case PrimitiveType.Double:
                        return 8;

                    case PrimitiveType.IntPtr:
                    case PrimitiveType.UIntPtr:
                        if (Program.AsX64)
                            return 8;
                        else
                            return 4;

                    default:
                        return 0;
                }
            }
            else if (operand.IsValueType)
            {
                int size = 0;
                foreach (InterField fld in operand.Fields)
                    size += GetSize(fld.FieldType);
                return size;
            }
            else
            {
                if (Program.AsX64)
                    return 8;
                else
                    return 4;
            }
        }

        private void CompileValueOf(ILExpression e, ExpectType expect)
        {
            InterType returnType = resolver.Resolve(e.InferredType, thisMethod.FullGenericArguments);
            InterType nullableType = resolver.Resolve(e.Arguments[0].InferredType, thisMethod.FullGenericArguments);

            CompileExpression(e.Arguments[0], ExpectType.ByRef);
            codeGenerator.Add(OpCodes.invokevirtual, new MethodRef(namesController.TypeNameToJava(nullableType),
                ClassNames.SystemNullable_1.GetValueOrDefaultMethodName, "()" + namesController.GetFieldDescriptor(returnType)));
        }
    }
}
