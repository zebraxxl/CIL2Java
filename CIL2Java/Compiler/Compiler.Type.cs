using CIL2Java.Java;
using CIL2Java.Java.Constants;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class Compiler
    {
        Java.Class currentJavaClass = null;
        Java.Attributes.InnerClasses currentJavaInnerClasses = null;

        private ushort GetClassAccessFlags(InterType type, bool includeNestedFlags)
        {
            ushort result = 0;

            //static classes in C# marked as abstract and sealed, that can't be in java
            if ((type.IsAbstract) && (!type.IsSealed)) result |= (ushort)Java.ClassAccessFlag.Abstract;
            if (type.IsInterface) result |= (ushort)(Java.ClassAccessFlag.Abstract | Java.ClassAccessFlag.Interface);
            else result |= (ushort)Java.ClassAccessFlag.Super;

            if (type.IsSealed) result |= (ushort)Java.ClassAccessFlag.Final;

            //In java classes must be always public (except nested classes) because java hasn't internal visible (only package visible)
            if ((!type.IsNested) && (!type.IsNestedPublic)) result |= (ushort)Java.ClassAccessFlag.Public;

            if (!includeNestedFlags)
                return result;

            if (type.IsNestedPublic) result |= (ushort)Java.Attributes.InnerClasses.InnerClassAccessFlags.Public;
            else if (type.IsNestedProtected) result |= (ushort)Java.Attributes.InnerClasses.InnerClassAccessFlags.Protected;
            else result |= (ushort)Java.Attributes.InnerClasses.InnerClassAccessFlags.Private;

            return result;
        }

        private Java.Class ComplileType(InterType type)
        {
            Messages.Verbose("  Compiling type {0}...", type.ToString());
            currentJavaClass = new Java.Class();

            currentJavaClass.AccessFlag = (Java.ClassAccessFlag)GetClassAccessFlags(type, false);

            currentJavaClass.ThisClass = TypeNameToJava(type.Fullname);
            if (type.BaseType == null)
                currentJavaClass.SuperClass = TypeNameToJava(ClassNames.JavaObject);
            else
                currentJavaClass.SuperClass = TypeNameToJava(type.BaseType.Fullname);

            foreach (InterType i in type.Interfaces)
                currentJavaClass.Interfaces.Add(TypeNameToJava(i.Fullname));

            if (type.IsValueType)
                CompileValueType(type);

            currentJavaInnerClasses = new Java.Attributes.InnerClasses();

            if (type.DeclaringType != null)
            {
                Java.Attributes.InnerClasses.InnerClass innerClass = new Java.Attributes.InnerClasses.InnerClass();
                innerClass.AccessFlags = (Java.Attributes.InnerClasses.InnerClassAccessFlags)GetClassAccessFlags(type, true);
                innerClass.InnerClassInfo = TypeNameToJava(type.Fullname);
                innerClass.InnerName = TypeNameToJava(type.Name);
                innerClass.OuterClassInfo = TypeNameToJava(type.DeclaringType.Fullname);
                currentJavaInnerClasses.Classes.Add(innerClass);
            }

            foreach (InterType nestedClass in type.NestedClasses)
            {
                Java.Attributes.InnerClasses.InnerClass innerClass = new Java.Attributes.InnerClasses.InnerClass();
                innerClass.AccessFlags = (Java.Attributes.InnerClasses.InnerClassAccessFlags)GetClassAccessFlags(nestedClass, true);
                innerClass.InnerClassInfo = TypeNameToJava(nestedClass.Fullname);
                innerClass.InnerName = TypeNameToJava(nestedClass.Name);
                innerClass.OuterClassInfo = TypeNameToJava(type.Fullname);
                currentJavaInnerClasses.Classes.Add(innerClass);
            }

            foreach (InterField field in type.Fields)
                currentJavaClass.Fields.Add(CompileField(field));

            foreach (InterMethod method in type.Methods)
                currentJavaClass.Methods.Add(CompileMethod(method));

            bool hasStaticCtor = type.Methods.Where(M => ((M.IsConstructor) && (M.IsStatic))).Count() > 0;
            bool needStaticCtor = type.Fields.Where(F => ((F.FieldType.IsValueType) && (F.IsStatic))).Count() > 0;

            if ((needStaticCtor) && (!hasStaticCtor))
                GenerateStaticCtor(type);

            if (currentJavaInnerClasses.Classes.Count > 0)
                currentJavaClass.Attributes.Add(currentJavaInnerClasses);

            return currentJavaClass;
        }

        private void GenerateStaticCtor(InterType type)
        {
            Method ctor = new Method();
            ctor.AccessFlags = MethodAccessFlags.Static;
            ctor.Name = "<clinit>";
            ctor.Descriptor = "()V";

            JavaBytecodeWriter codeWriter = new JavaBytecodeWriter();

            var staticValueTypeFields = type.Fields.Where(F => ((F.IsStatic) && (F.FieldType.IsValueType)));

            foreach (InterField fld in staticValueTypeFields)
            {
                Java.Constants.Class fldTypeRef = new Java.Constants.Class(TypeNameToJava(fld.FieldType.Fullname));
                MethodRef fldTypeInitRef = new MethodRef(fldTypeRef.Value, ClassNames.JavaConstructorMethodName, "()V");
                FieldRef fldRef = new FieldRef(TypeNameToJava(type.Fullname), FieldNameToJava(fld.Name),
                    GetFieldDescriptor(fld.FieldType));

                codeWriter
                    .Add(OpCodes._new, fldTypeRef)
                    .Add(OpCodes.dup)
                    .Add(OpCodes.invokespecial, fldTypeInitRef)
                    .Add(OpCodes.putstatic, fldRef);
            }

            codeWriter.AddReturn(JavaPrimitiveType.Void);

            ctor.Attributes.Add(codeWriter.End(currentJavaClass.ConstantPool));
            currentJavaClass.Methods.Add(ctor);
        }
    }
}
