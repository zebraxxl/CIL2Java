using System;
using System.Collections.Generic;

using javaString = java.lang.String;

namespace CIL2Java.Maps
{
    public static class String
    {
        public static javaString Concat(javaString s1, javaString s2)
        {
            return s1.concat(s2);
        }

        public static bool OperatorEq(javaString a, javaString b)
        {
            return a.Equals(b);
        }

        public static bool OperatorNotEq(javaString a, javaString b)
        {
            return !a.Equals(b);
        }
    }
}
