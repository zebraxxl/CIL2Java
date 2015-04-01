using CIL2Java.Attributes;
using java.lang;
using System;
using System.Collections.Generic;

namespace java.util.regex
{
    [FromJava]
    public class Pattern : io.Serializable
    {
        [FromJava]
        public static Pattern compile(string regex) { return null; }

        [FromJava]
        public Matcher matcher(CharSequence input) { return null; }
    }
}
