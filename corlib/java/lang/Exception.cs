using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    [FromJava]
    public class Exception : Throwable
    {
        [FromJava] 
        public Exception() { }

        [FromJava]
        public Exception(string message) { }

        [FromJava]
        public Exception(string message, Throwable cause) { }

        [FromJava]
        public Exception(Throwable cause) { }

#if JAVA_1_7
        [FromJava]
        protected Exception(string message, Throwable cause, bool enableSuppression, bool writableStackTrace) { }
#endif
    }
}
