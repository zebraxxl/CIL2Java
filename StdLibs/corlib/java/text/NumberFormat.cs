using CIL2Java.Attributes;
using java.util;
using System;
using System.Collections.Generic;

namespace java.text
{
    [FromJava]
    public abstract class NumberFormat : Format
    {
        [FromJava]
        public static NumberFormat getInstance() { return null; }

        [FromJava]
        public static NumberFormat getInstance(Locale inLocale) { return null; }
    }
}
