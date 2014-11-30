using System;
using System.Collections.Generic;

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

            if (currentJavaInnerClasses.Classes.Count > 0)
                currentJavaClass.Attributes.Add(currentJavaInnerClasses);

            return currentJavaClass;
        }
    }
}
