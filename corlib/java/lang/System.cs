using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    [FromJava()]
    public sealed class System
    {
        /** Don't let anyone instantiate this class */
        private System() { }

        [FromJava()]
        public static io.PrintStream @out;
    }
}
