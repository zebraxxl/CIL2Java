using CIL2Java.Attributes;
using System;
using System.Collections.Generic;
using boolean = System.Boolean;

namespace java.io
{
    [FromJava]
    public class File : Serializable, lang.Comparable
    {
        [FromJava]
        public File(string fileName) { }

        [FromJava]
        public boolean exists() { return false; }

        [FromJava]
        public boolean isDirectory() { return false; }

        [FromJava]
        public int compareTo(object obj) { return 0; } 
    }
}
