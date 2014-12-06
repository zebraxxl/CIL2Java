using CIL2Java.Java;
using CIL2Java.Java.Constants;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class Compiler
    {
        private void GenerateEnumCtor(InterType type)
        {
            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public;
            result.Name = ClassNames.JavaConstructorMethodName;
            result.Descriptor = "()V";
            result.Attributes.Add(new JavaBytecodeWriter()
                .Add(OpCodes.aload_0)
                .Add(OpCodes.invokespecial, ClassNames.EnumCtorRef)
                .Add(OpCodes._return)
                .End(currentJavaClass.ConstantPool));
            currentJavaClass.Methods.Add(result);
        }

        private void GenerateEnumGetBoxed(InterType type)
        {
            string boxedEnumName = TypeNameToJava(type.Fullname);
            string elementDescriptor = GetFieldDescriptor(type.ElementType);

            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public | MethodAccessFlags.Final | MethodAccessFlags.Static;
            result.Name = ClassNames.EnumGetBoxedMethodName;
            result.Descriptor = "(" + elementDescriptor + ")" + "L" + boxedEnumName + ";";
            result.Attributes.Add(new JavaBytecodeWriter()
                .Add(OpCodes._new, new Java.Constants.Class(boxedEnumName))
                .Add(OpCodes.dup)
                .Add(OpCodes.invokespecial, new MethodRef(boxedEnumName, ClassNames.JavaConstructorMethodName, "()V"))
                .Add(OpCodes.dup)
                .AddLoad(JavaHelpers.InterTypeToJavaPrimitive(type.ElementType), 0)
                .Add(OpCodes.putfield, new FieldRef(boxedEnumName, ClassNames.EnumValueFieldName, elementDescriptor))
                .Add(OpCodes.areturn)
                .End(currentJavaClass.ConstantPool)
                );
            currentJavaClass.Methods.Add(result);
        }

        private void GenerateEnumGetUnboxed(InterType type)
        {
            string boxedEnumName = TypeNameToJava(type.Fullname);
            string elementDescriptor = GetFieldDescriptor(type.ElementType);

            Method result = new Method();
            result.AccessFlags = MethodAccessFlags.Public | MethodAccessFlags.Final;
            result.Name = ClassNames.EnumGetUnboxedMethodName;
            result.Descriptor = "()" + elementDescriptor;
            result.Attributes.Add(new JavaBytecodeWriter()
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, new FieldRef(boxedEnumName, ClassNames.EnumValueFieldName, elementDescriptor))
                .AddReturn(JavaHelpers.InterTypeToJavaPrimitive(type.ElementType))

                .End(currentJavaClass.ConstantPool));
            currentJavaClass.Methods.Add(result);
        }

        private void CompileEnum(InterType type)
        {
            GenerateEnumCtor(type);
            GenerateEnumGetBoxed(type);
            GenerateEnumGetUnboxed(type);
        }
    }
}
