using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    [FromJava]
    public sealed class Integer : Number, Comparable
    {
        [FromJava]
        public static readonly Class TYPE;

        [FromJava]
        public static string ToString(int i) { return null; }

        [FromJava]
        public static string toHexString(int i) { return null; }

        [FromJava]
        public static Integer valueOf(int i) { return null; }

        [FromJava]
        public int compareTo(object obj) { return 0; }

        [FromJava]
        public static int parseInt(string s) { return 0; }

        [FromJava]
        public int intValue() { return 0; }
    }
}
