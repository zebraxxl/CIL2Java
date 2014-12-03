using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class Compiler
    {
        string INamesController.TypeNameToJava(InterType CILName)
        {
            if (CILName.IsArray)
                return GetFieldDescriptor(CILName);
            else if (CILName.IsByRef)
                return TypeNameToJava(GetByRefTypeName(CILName));
            
            return TypeNameToJava(CILName.Fullname);
        }

        string INamesController.TypeNameToJava(string CILName)
        {
            return TypeNameToJava(CILName);
        }

        string INamesController.FieldNameToJava(string CILName)
        {
            return FieldNameToJava(CILName);
        }

        string INamesController.MethodNameToJava(string CILName)
        {
            return MethodNameToJava(CILName);
        }

        string INamesController.GetFieldDescriptor(InterType fldType)
        {
            return GetFieldDescriptor(fldType);
        }

        string INamesController.GetMethodDescriptor(InterMethod method)
        {
            return GetMethodDescriptor(method);
        }

        string INamesController.GetAnonimousClassName()
        {
            int index = 0;
            while (currentJavaInnerClasses.Classes
                .Where(I => I.InnerName == ClassNames.AnonimousInnerClassPrefix + index.ToString()).Count() > 0)
                index++;
            return currentType.Fullname + "/" + ClassNames.AnonimousInnerClassPrefix + index.ToString();
        }

        void INamesController.WriteAnonumousClass(Java.Class javaClass)
        {
            WriteClass(javaClass);

            Java.Attributes.InnerClasses.InnerClass descr = new Java.Attributes.InnerClasses.InnerClass();
            descr.AccessFlags = Java.Attributes.InnerClasses.InnerClassAccessFlags.Public;
            descr.InnerClassInfo = javaClass.ThisClass;
            descr.OuterClassInfo = currentJavaClass.ThisClass;
            descr.InnerName = javaClass.ThisClass.Substring(javaClass.ThisClass.LastIndexOf('$') + 1);

            currentJavaInnerClasses.Classes.Add(descr);
        }

        Java.Method INamesController.GetAnonumousAccessMethod()
        {
            int index = 0;
            while (currentJavaClass.Methods.Where(M => M.Name == ClassNames.AccessMethodPrefix + index.ToString()).Count() > 0)
                index++;

            Java.Method result = new Java.Method();
            result.Name = ClassNames.AccessMethodPrefix + index.ToString();

            currentJavaClass.Methods.Add(result);

            return result;
        }

        string INamesController.GetMethodPointerInterface(InterMethod method)
        {
            string result = ClassNames.MethodPointerPrefix + escapeTypeName(method.ReturnParameter.Type.Fullname) + "_"
                + string.Join("_", method.Parameters.Select(P => escapeTypeName(P.Type.Fullname)).ToArray());

            if (!methodPointerInterfaces.ContainsKey(result))
                methodPointerInterfaces.Add(result, method);

            return result;
        }

        private string escapeTypeName(string name)
        {
            return name.Replace(new char[] { '.', '/' }, '_');
        }
    }
}
