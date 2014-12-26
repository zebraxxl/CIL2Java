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
        private Stack<int> initializedObjectsVarIndexes = new Stack<int>();

        private void CompileCastclass(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            CompileExpression(e.Arguments[0], expect);

            codeGenerator.Add(Java.OpCodes.checkcast, new Java.Constants.Class(namesController.TypeNameToJava(operand)), e);
        }

        private void CompileNewobj(ILExpression e, ExpectType expect)
        {
            InterMethod ctor = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

            if (ctor.DeclaringType.IsArray)
                CompileNewmultiarray(e, expect);
            else
            {
                Java.Constants.Class declTypeClassRef = new Java.Constants.Class(
                    namesController.TypeNameToJava(ctor.DeclaringType));

                codeGenerator
                    .Add(Java.OpCodes._new, declTypeClassRef, e)
                    .Add(Java.OpCodes.dup, null, e);

                CompileCall(e, expect);
            }
        }

        private void CompileStobj(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            if (operand.IsValueType)
            {
                // stobj(destPtr, src) compiling to
                // src.CopyTo(destPtr)
                CompileExpression(e.Arguments[1], ExpectType.Any);
                CompileExpression(e.Arguments[0], ExpectType.ByRef);

                MethodRef copyToRef = new MethodRef(namesController.TypeNameToJava(operand),
                    ClassNames.ValueTypeCopyTo, "(" + namesController.GetFieldDescriptor(operand) + ")V");

                bool needDup = ((e.ExpectedType != null) && (expect != ExpectType.None));
                if (needDup)
                    codeGenerator.Add(Java.OpCodes.dup_x1, null, e);

                codeGenerator.Add(Java.OpCodes.invokevirtual, copyToRef, e);
            }
            else
            {
                // From ECMA-335, III.4.29
                // The stobj instruction copies the value src to the address dest. If typeTok is not
                // a generic parameter and either a reference type or a built-in value class, then 
                // the stind instruction provides a shorthand for the stobj instruction.
                CompileStind(e, expect);
            } 
        }

        private void CompileLdobj(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            if ((operand.IsPrimitive) && (e.Arguments[0].Code == ILCode.Ldloc) &&
                (((ILVariable)e.Arguments[0].Operand).Name == "this"))
            {
                //Special treatment. Value for primitive types
                codeGenerator
                    .Add(Java.OpCodes.aload_0, null, e)
                    .Add(Java.OpCodes.getfield, new Java.Constants.FieldRef(
                        namesController.TypeNameToJava(operand.CILBoxType), "value",
                        namesController.GetFieldDescriptor(operand)), e);
            }
            else if (operand.IsValueType)
            {
                CompileExpression(e.Arguments[0], ExpectType.ByRef);
                MethodRef getCopyRef = new MethodRef(namesController.TypeNameToJava(operand),
                    ClassNames.ValueTypeGetCopy, "()" + namesController.GetFieldDescriptor(operand));

                codeGenerator.Add(Java.OpCodes.invokevirtual, getCopyRef, e);
            }
            else
            {
                // From ECMA-335, III.4.29
                // If typeTok is not a generic parameter and either a reference type or a built-in value
                // class, then the ldind instruction provides a shorthand for the ldobj instruction.
                CompileLdind(e, expect);
            }
        }

        private void CompileCpobj(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);
            // dst = arg[0]
            // src = arg[1]


            if (operand.IsValueType)
            {
                CompileExpression(e.Arguments[1], ExpectType.ByRef);
                CompileExpression(e.Arguments[0], ExpectType.ByRef);
                codeGenerator.Add(Java.OpCodes.invokevirtual, new MethodRef(
                    namesController.TypeNameToJava(operand),
                    ClassNames.ValueTypeCopyTo,
                    "(" + namesController.GetFieldDescriptor(operand) + ")V"), e);
            }
            else
            {
                CompileExpression(new ILExpression(ILCode.Ldind_Ref, e.Operand, e.Arguments[1]), ExpectType.Any);
                CompileExpression(new ILExpression(ILCode.Stind_Ref, e.Operand, e.Arguments[0]), expect);
            }
        }

        private void CompileInitobj(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            CompileExpression(e.Arguments[0], ExpectType.ByRef);

            if (!operand.IsValueType)
            {
                JavaPrimitiveType jp = JavaHelpers.InterTypeToJavaPrimitive(operand);
                MethodRef setValueRef = byRefController.GetByRefSetValueMethodRef(jp);

                switch (jp)
                {
                    case JavaPrimitiveType.Bool:
                    case JavaPrimitiveType.Byte:
                    case JavaPrimitiveType.Char:
                    case JavaPrimitiveType.Int:
                    case JavaPrimitiveType.Short:
                        codeGenerator.AddIntConst(0, e);
                        break;

                    case JavaPrimitiveType.Long: codeGenerator.AddLongConst(0L, e); break;
                    case JavaPrimitiveType.Float: codeGenerator.AddFloatConst(0.0f, e); break;
                    case JavaPrimitiveType.Double: codeGenerator.AddDoubleConst(0.0, e); break;
                    case JavaPrimitiveType.Ref: codeGenerator.Add(OpCodes.aconst_null, e); break;
                }

                codeGenerator.Add(OpCodes.invokevirtual, setValueRef, e);
            }
            else
            {
                codeGenerator.Add(OpCodes.invokevirtual, new MethodRef(namesController.TypeNameToJava(operand),
                    ClassNames.ValueTypeZeroFill, "()V"));
            }
        }

        private void CompileIsinst(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            CompileExpression(e.Arguments[0], ExpectType.Reference);

            //  dup
            //  instanceof operand
            //  ifne :end
            //  pop
            //  aconst_null
            //:end
            //  checkcast operand

            string endLabel = rnd.Next().ToString() + "end";

            Java.Constants.Class operandRef = new Java.Constants.Class(namesController.TypeNameToJava(GetBoxType(operand)));

            codeGenerator
                .Add(Java.OpCodes.dup, null, e)
                .Add(Java.OpCodes.instanceof, operandRef, e)
                .Add(Java.OpCodes.ifne, endLabel, e)
                .Add(Java.OpCodes.pop, null, e)
                .Add(Java.OpCodes.aconst_null, null, e)
                .Label(endLabel)
                .Add(Java.OpCodes.checkcast, operandRef, e);
        }

        private void CompileBox(ILExpression e, ExpectType expect)
        {
            CompileExpression(e.Arguments[0], ExpectType.Boxed);
        }

        private void CompileUnbox(ILExpression e, ExpectType expect)
        {
            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

            if ((operand.IsPrimitive) || (operand.IsEnum))
            {
                string fieldName = ClassNames.BoxedPrimitiveValueFieldName;
                if (operand.IsEnum)
                    fieldName = ClassNames.EnumValueFieldName;

                // Generating FieldByRef to value field of boxed class
                // In java boxed primitived has field named "value" too.
                // Yes, it is bad hack, but I don't known another way to do this
                string boxedClass = GetBoxType(operand);

                string byRefTypeName = byRefController.GetFieldByRefTypeName(operand);

                Java.Constants.Class constByRefType = new Java.Constants.Class(namesController.TypeNameToJava(byRefTypeName));
                Java.Constants.Class constFieldDeclClass =
                    new Java.Constants.Class(namesController.TypeNameToJava(operand));
                Java.Constants.String constFieldName = new Java.Constants.String(
                    namesController.FieldNameToJava(fieldName));
                MethodRef constFieldByRefCtorRef = byRefController.GetFieldByRefCtorMethodRef(operand);

                codeGenerator.Add(OpCodes._new, constByRefType, e);
                codeGenerator.Add(OpCodes.dup, null, e);

                CompileExpression(e.Arguments[0], ExpectType.Boxed);

                codeGenerator.Add(OpCodes.ldc, constFieldDeclClass, e);
                codeGenerator.Add(OpCodes.ldc, constFieldName, e);
                codeGenerator.Add(OpCodes.invokevirtual, ClassNames.JavaLangClass.getDeclaredFieldRef, e);
                codeGenerator.Add(OpCodes.invokespecial, constFieldByRefCtorRef);
            }
            else if (operand.IsNullable)
            {
                // From ECMA-335, III.4.32
                // [Note: Typically, unbox simply computes the address of the value type that is already present
                // inside of the boxed object. This approach is not possible when unboxing nullable value types.
                // Because Nullable<T> values are converted to boxed Ts during the box operation, an
                // implementation often must manufacture a new Nullable<T> on the heap and compute the address
                // to the newly allocated object. end note]
                codeGenerator
                    .Add(OpCodes._new, new Java.Constants.Class(namesController.TypeNameToJava(operand)), e)
                    .Add(OpCodes.dup, null, e);

                CompileUnbox_Any(e, ExpectType.Any);

                codeGenerator.Add(OpCodes.invokespecial, new MethodRef(
                    namesController.TypeNameToJava(operand),
                    ClassNames.JavaConstructorMethodName,
                    "(" + namesController.GetFieldDescriptor(operand.GenericArguments[0].Type) + ")V"));
            }
            else
                // By standart, we must compute a ref to value type from it boxed representation
                // But in CIL2Java boxed value type is ref to it
                CompileExpression(e.Arguments[0], ExpectType.Any);
        }

        private void CompileUnbox_Any(ILExpression e, ExpectType expect)
        {

            InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);
            InterType nullableType = null;
            
            if (operand.IsNullable)
            {
                nullableType = operand;
                operand = operand.GenericArguments[0].Type;

                codeGenerator
                    .Add(OpCodes._new, new Java.Constants.Class(namesController.TypeNameToJava(nullableType)), e)
                    .Add(OpCodes.dup, null, e);
            }

            CompileExpression(e.Arguments[0], ExpectType.Boxed);

            string boxType = GetBoxType(operand);

            Java.Constants.Class operandRef = new Java.Constants.Class(namesController.TypeNameToJava(boxType));

            Java.Constants.MethodRef valueRef;

            if (operand.IsValueType)
            {
                valueRef = new Java.Constants.MethodRef(operandRef.Value, ClassNames.ValueTypeGetCopy, "()" +
                    namesController.GetFieldDescriptor(operand));
            }
            else if (operand.IsEnum)
            {
                valueRef = new MethodRef(operandRef.Value, ClassNames.EnumGetUnboxedMethodName,
                    "()" + namesController.GetFieldDescriptor(operand.ElementType));
            }
            else
            {
                valueRef = new Java.Constants.MethodRef(operandRef.Value,
                    Utils.GetJavaTypeName(operand.PrimitiveType) + "Value",
                    "()" + namesController.GetFieldDescriptor(operand));
            }

            codeGenerator
                .Add(Java.OpCodes.checkcast, operandRef, e)
                .Add(Java.OpCodes.invokevirtual, valueRef, e);

            if (nullableType != null)
            {
                codeGenerator.Add(OpCodes.invokespecial, new MethodRef(
                    namesController.TypeNameToJava(nullableType),
                    ClassNames.JavaConstructorMethodName,
                    "(" + namesController.GetFieldDescriptor(operand) + ")V"));
            }
        }

        private void CompileLdtoken(ILExpression e, ExpectType expect)
        {
            if (e.Operand is TypeReference)
            {
                InterType operand = resolver.Resolve((TypeReference)e.Operand, thisMethod.FullGenericArguments);

                codeGenerator
                    .Add(OpCodes._new, new Java.Constants.Class(namesController.TypeNameToJava(ClassNames.SystemRuntimeTypeHandle.ClassName)), e)
                    .Add(OpCodes.dup, null, e)
                    .Add(OpCodes.ldc, new Java.Constants.Class(namesController.TypeNameToJava(operand)), e)
                    .Add(OpCodes.invokespecial, ClassNames.SystemRuntimeTypeHandle.CtorMethodRef, e);
            }
            else if (e.Operand is FieldReference)
            {
                InterField operand = resolver.Resolve((FieldReference)e.Operand, thisMethod.FullGenericArguments);

                codeGenerator
                    .Add(OpCodes._new, new Java.Constants.Class(namesController.TypeNameToJava(ClassNames.SystemRuntimeFieldHandle.ClassName)), e)
                    .Add(OpCodes.dup, null, e)
                    .Add(OpCodes.ldc, new Java.Constants.Class(namesController.TypeNameToJava(operand.DeclaringType)), e)
                    .Add(OpCodes.ldc, new Java.Constants.String(operand.Name), e)
                    .Add(OpCodes.invokevirtual, ClassNames.JavaLangClass.getDeclaredFieldRef, e)
                    .Add(OpCodes.invokespecial, ClassNames.SystemRuntimeFieldHandle.CtorMethodRef, e);
            }
            else if (e.Operand is MethodReference)
            {
                InterMethod operand = resolver.Resolve((MethodReference)e.Operand, thisMethod.FullGenericArguments);

                codeGenerator
                    .Add(OpCodes._new, new Java.Constants.Class(namesController.TypeNameToJava(ClassNames.SystemRuntimeMethodHandle.ClassName)), e)
                    .Add(OpCodes.dup, null, e)
                    .Add(OpCodes.ldc, new Java.Constants.Class(namesController.TypeNameToJava(operand.DeclaringType)), e);

                if (!operand.IsConstructor)
                    codeGenerator.Add(OpCodes.ldc, new Java.Constants.String(operand.NewName), e);

                codeGenerator
                    .AddIntConst(operand.Parameters.Count, e)
                    .Add(OpCodes.anewarray, new Java.Constants.Class(namesController.TypeNameToJava(ClassNames.JavaLangClass.ClassName)), e);

                for (int i = 0; i < operand.Parameters.Count; i++)
                {
                    codeGenerator
                        .Add(OpCodes.dup)
                        .AddIntConst(i, e)
                        .Add(OpCodes.ldc, new Java.Constants.Class(namesController.TypeNameToJava(operand.Parameters[i].Type)))
                        .Add(OpCodes.aastore, null, e);
                }

                if (operand.IsConstructor)
                    codeGenerator.Add(OpCodes.invokevirtual, ClassNames.JavaLangClass.getDeclaredConstructorRef, e);
                else
                    codeGenerator.Add(OpCodes.invokevirtual, ClassNames.JavaLangClass.getDeclaredMethodRef, e);

                codeGenerator.Add(OpCodes.invokespecial, ClassNames.SystemRuntimeMethodHandle.CtorMethodRef, e);
            }
        }

        private void CompileInitObjectOrCollection(ILExpression e, ExpectType expect)
        {
            int tmpVar = GetNextFreeVar(JavaPrimitiveType.Ref);

            CompileExpression(e.Arguments[0], ExpectType.Reference);
            codeGenerator.AddStore(JavaPrimitiveType.Ref, tmpVar, e);

            initializedObjectsVarIndexes.Push(tmpVar);
            for (int i = 1; i < e.Arguments.Count; i++)
                CompileExpression(e.Arguments[i], ExpectType.None);

            codeGenerator.AddLoad(JavaPrimitiveType.Ref, initializedObjectsVarIndexes.Pop(), e);
            FreeVar(tmpVar, JavaPrimitiveType.Ref);
        }

        private void CompileInitializedObject(ILExpression e, ExpectType expect)
        {
            if (initializedObjectsVarIndexes.Count == 0)
                Messages.Message(MessageCode.NoInitializedObject);
            else
                codeGenerator.AddLoad(JavaPrimitiveType.Ref, initializedObjectsVarIndexes.Peek(), e);
        }
    }
}
