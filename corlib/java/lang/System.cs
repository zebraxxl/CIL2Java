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

        [FromJava]
        public static void arraycopy(object src, int srcPos, object dest, int destPos, int length) { }
    }
}
