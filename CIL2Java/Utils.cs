using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public static class Utils
    {
        public static string Replace(this string Value, char[] OldChars, char NewChar)
        {
            string R = Value;
            foreach (char ch in OldChars)
            {
                R = R.Replace(ch, NewChar);
            }
            return R;
        }

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> self, Action<T> a)
        {
            foreach (T v in self)
                a(v);
            return self;
        }

        public static GenericArgumentOwnerType CecilGenericOwnerToC2JGenericOwner(GenericParameterType cecilOwner)
        {
            switch (cecilOwner)
            {
                case GenericParameterType.Method: return GenericArgumentOwnerType.Method;
                case GenericParameterType.Type: return GenericArgumentOwnerType.Type;
                default: return GenericArgumentOwnerType.Type;
            }
        }

        public static string GetJavaTypeName(PrimitiveType pt)
        {
            string prefix = "";

            switch (pt)
            {
                case PrimitiveType.Bool: prefix = "boolean"; break;
                case PrimitiveType.Char: prefix = "char"; break;
                case PrimitiveType.Double: prefix = "double"; break;

                case PrimitiveType.SByte:
                case PrimitiveType.Byte:
                    prefix = "byte";
                    break;

                case PrimitiveType.Int16:
                case PrimitiveType.UInt16:
                    prefix = "short";
                    break;

                case PrimitiveType.Int32:
                case PrimitiveType.UInt32:
                    prefix = "int";
                    break;

                case PrimitiveType.Int64:
                case PrimitiveType.UInt64:
                    prefix = "long";
                    break;

                case PrimitiveType.Single:
                    prefix = "float";
                    break;
            }

            return prefix;
        }
    }
}
