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
            int pos = 0;
            while (pos < CILName.Length)
            {
                int startOfGenerics = CILName.IndexOf('<', pos);
                if (startOfGenerics < 0) break;

                int endOfGenerrics = CILName.IndexOf('>', startOfGenerics);
                if (endOfGenerrics < 0) endOfGenerrics = CILName.Length;

                CILName = CILName.Substring(0, startOfGenerics) +
                    CILName.Substring(startOfGenerics, endOfGenerrics - startOfGenerics).Replace(new char[] { '.', '/' }, '_') +
                    CILName.Substring(endOfGenerrics);

                pos = endOfGenerrics;
            }

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

            return CILName.Replace(InvalidJavaChars, '_').Replace('.', '_').Replace('/', '_');
        }
    }
}
