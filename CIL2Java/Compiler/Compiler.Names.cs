using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public partial class Compiler
    {
        private static char[] InvalidJavaChars = new char[] { '<', '>', '-', '\\', ';', '[', ']', '+', '=', '!', '@', '#', '$', '%', '^', '&', '*', '`', ',', '|', '(', ')', '{', '}' };

        private static Dictionary<string, string> AllMethodsMapper = new Dictionary<string, string>()
        {
            {".ctor", "<init>"},
            {".cctor", "<clinit>"},
            {"ToString", "toString"},
            {"GetHashCode", "hashCode"},
            {"Equals", "equals"},
            {"Finalize", "finalize"}
        };

        private static string TypeNameToJava(string CILName)
        {
            int startOfGenericArgs = CILName.IndexOf('<');
            if (startOfGenericArgs > 0)
                CILName = CILName.Substring(0, startOfGenericArgs) + CILName.Substring(startOfGenericArgs).Replace(new char[] { '.', '/' }, '_');

            return CILName.Replace(InvalidJavaChars, '_').Replace('/', '$').Replace('.', '/');
        }

        private static string FieldNameToJava(string CILName)
        {
            return CILName.Replace(InvalidJavaChars, '_');
        }

        private static string MethodNameToJava(string CILName)
        {
            if (AllMethodsMapper.ContainsKey(CILName))
                return AllMethodsMapper[CILName];

            return CILName.Replace(InvalidJavaChars, '_').Replace('.', '_');
        }
    }
}
