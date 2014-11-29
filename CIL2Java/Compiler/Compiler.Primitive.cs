using CIL2Java.Java;
using CIL2Java.Java.Constants;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class Compiler
    {
        private void CompilePrimitive(InterType type)
        {
            if (Program.BoxType == BoxingType.Java)
                return;

            JavaPrimitiveType javaType = JavaHelpers.InterTypeToJavaPrimitive(type);

            currentJavaClass = new Java.Class();
            currentJavaClass.AccessFlag = Java.ClassAccessFlag.Public | Java.ClassAccessFlag.Super | ClassAccessFlag.Final;
            currentJavaClass.ThisClass = TypeNameToJava(type.CILBoxType);
            currentJavaClass.SuperClass = TypeNameToJava(ClassNames.JavaObject);

            Field valueField = new Field();
            valueField.AccessFlags = FieldAccessFlags.Private;
            valueField.Name = "value";
            valueField.Descriptor = GetFieldDescriptor(type);
            currentJavaClass.Fields.Add(valueField);
            FieldRef valueFieldRef = new FieldRef(currentJavaClass.ThisClass, valueField.Name, valueField.Descriptor);

            Method ctorMethod = new Method();
            ctorMethod.AccessFlags = MethodAccessFlags.Public;
            ctorMethod.Name = ClassNames.JavaConstructorMethodName;
            ctorMethod.Descriptor = "()V";
            ctorMethod.Attributes.Add(new JavaBytecodeWriter()
                .Add(OpCodes.aload_0)
                .Add(OpCodes.invokespecial, ClassNames.JavaObjectCtorMethodRef)

                .Add(OpCodes.aload_0)
                .AddDefaultValue(javaType)
                .Add(OpCodes.putfield, valueFieldRef)

                .Add(OpCodes._return)

                .End(currentJavaClass.ConstantPool));
            currentJavaClass.Methods.Add(ctorMethod);

            Method ctorValueMethod = new Method();
            ctorValueMethod.AccessFlags = MethodAccessFlags.Public;
            ctorValueMethod.Name = ClassNames.JavaConstructorMethodName;
            ctorValueMethod.Descriptor = "(" + valueField.Descriptor + ")V";
            ctorValueMethod.Attributes.Add(new JavaBytecodeWriter()
                .Add(OpCodes.aload_0)
                .Add(OpCodes.invokespecial, ClassNames.JavaObjectCtorMethodRef)

                .Add(OpCodes.aload_0)
                .AddLoad(javaType, 1)
                .Add(OpCodes.putfield, valueFieldRef)

                .Add(OpCodes._return)

                .End(currentJavaClass.ConstantPool));
            currentJavaClass.Methods.Add(ctorValueMethod);
            MethodRef ctorValueMethodRef = new MethodRef(currentJavaClass.ThisClass, ctorValueMethod.Name, ctorValueMethod.Descriptor);

            Method valueOfMethod = new Method();
            valueOfMethod.AccessFlags = MethodAccessFlags.Public | MethodAccessFlags.Static;
            valueOfMethod.Name = "valueOf";
            valueOfMethod.Descriptor = "(" + valueField.Descriptor + ")L" + TypeNameToJava(type.CILBoxType) + ";";
            valueOfMethod.Attributes.Add(new JavaBytecodeWriter()
                .Add(OpCodes._new, new Java.Constants.Class(TypeNameToJava(type.CILBoxType)))
                .Add(OpCodes.dup)
                .AddLoad(javaType, 0)
                .Add(OpCodes.invokespecial, ctorValueMethodRef)
                .Add(OpCodes.areturn)

                .End(currentJavaClass.ConstantPool));
            currentJavaClass.Methods.Add(valueOfMethod);

            Method getValueMethod = new Method();
            getValueMethod.AccessFlags = MethodAccessFlags.Public;
            getValueMethod.Name = Utils.GetJavaTypeName(type.PrimitiveType) + "Value";
            getValueMethod.Descriptor = "()" + GetFieldDescriptor(type);
            getValueMethod.Attributes.Add(new JavaBytecodeWriter()
                .Add(OpCodes.aload_0)
                .Add(OpCodes.getfield, valueFieldRef)
                .AddReturn(JavaHelpers.InterTypeToJavaPrimitive(type))

                .End(currentJavaClass.ConstantPool));
            currentJavaClass.Methods.Add(getValueMethod);

            currentJavaInnerClasses = new Java.Attributes.InnerClasses();

            foreach (InterField field in type.Fields)
                currentJavaClass.Fields.Add(CompileField(field));

            foreach (InterMethod method in type.Methods)
                currentJavaClass.Methods.Add(CompileMethod(method));

            if (currentJavaInnerClasses.Classes.Count > 0)
                currentJavaClass.Attributes.Add(currentJavaInnerClasses);

            WriteClass(currentJavaClass);
        }
    }
}
