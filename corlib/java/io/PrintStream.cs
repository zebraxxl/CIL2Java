using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.io
{
    [FromJava()]
    public class PrintStream
    {
        [FromJava()]
        public void print(int i) { }

        [FromJava()]
        public void print(string s) { }

        [FromJava()]
        public void println(int i) { }

        [FromJava()]
        public void println(string s) { }
    }
}
