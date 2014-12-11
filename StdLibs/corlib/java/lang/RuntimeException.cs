using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    [FromJava]
    public class RuntimeException : Exception
    {
        [FromJava]
        public RuntimeException() { }

        [FromJava]
        public RuntimeException(string message) { }

        [FromJava]
        public RuntimeException(string message, Throwable cause) { }

        [FromJava]
        public RuntimeException(Throwable cause) { }

#if JAVA_1_7
        [FromJava]
        protected RuntimeException(string message, Throwable cause, bool enableSuppression, bool writableStackTrace) { }
#endif
    }
}
