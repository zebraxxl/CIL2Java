using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    [FromJava]
    public class ArithmeticException : RuntimeException
    {
        [FromJava]
        public ArithmeticException() { }

        [FromJava]
        public ArithmeticException(string message) { }
    }
}
