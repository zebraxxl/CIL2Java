using CIL2Java.Java.Constants;
using ICSharpCode.Decompiler.ILAst;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private void CompileLdloc(ILExpression e, ExpectType expectType)
        {
            ILVariable operand = (ILVariable)e.Operand;
            int varIndex = GetVarIndex(operand);
            InterType operandType = resolver.Resolve(operand.Type, thisMethod.FullGenericArguments);

            //TODO: GetExpectType(InterParameter);
            codeGenerator.AddLocalVarInstruction(LocalVarInstruction.Load, JavaHelpers.InterTypeToJavaPrimitive(operandType), varIndex, e);

            if (operandType.IsValueType)
            {
                MethodRef getCopyRef = new MethodRef(namesController.TypeNameToJava(operandType.Fullname),
                    ClassNames.ValueTypeGetCopy, "()" + namesController.GetFieldDescriptor(operandType));
                codeGenerator.Add(Java.OpCodes.invokevirtual, getCopyRef, e);
            } else
                TranslateType(operandType, expectType, e);
        }

        private void CompileStloc(ILExpression e, ExpectType expectType)
        {
            ILVariable operand = (ILVariable)e.Operand;
            int varIndex = GetVarIndex(operand);
            InterType operandType = resolver.Resolve(operand.Type, thisMethod.FullGenericArguments);

            if ((operandType.IsValueType) && (e.Arguments[0].Code == ILCode.DefaultValue))
            {
                // In il this looks like `initobj(ldloca(var))`
                // But ILSpy optimizing it to `stloc(var, defaultvalue())`

                MethodRef zeroFillRef = new MethodRef(namesController.TypeNameToJava(operandType.Fullname),
                    ClassNames.ValueTypeZeroFill, "()V");

                codeGenerator
                    .AddLoad(JavaPrimitiveType.Ref, varIndex)
                    .Add(Java.OpCodes.invokevirtual, zeroFillRef);
            }
            else
            {
                //TODO: GetExpectType(InterParameter);
                CompileNode(e.Arguments[0], GetExpectType(operandType));

                codeGenerator.AddLocalVarInstruction(LocalVarInstruction.Store, JavaHelpers.InterTypeToJavaPrimitive(operandType), varIndex, e);
            }
        }
    }
}
