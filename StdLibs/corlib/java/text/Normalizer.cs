using CIL2Java.Attributes;
using java.lang;
using System;
using System.Collections.Generic;

namespace java.text
{
#if JAVA_1_6
    [FromJava]
    public sealed class Normalizer
    {
        private Normalizer() { }

        [FromJava]
        public sealed class Form
        {
            [FromJava]
            public static readonly Form NFD;

            [FromJava]
            public static readonly Form NFC;

            [FromJava]
            public static readonly Form NFKD;

            [FromJava]
            public static readonly Form NFKC;
        }

        [FromJava]
        public static string normalize(CharSequence src, Form form) { return null; }

        [FromJava]
        public static bool isNormalized(CharSequence src, Form form) { return false; }
    }
#endif
}
