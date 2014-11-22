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
    }
}
