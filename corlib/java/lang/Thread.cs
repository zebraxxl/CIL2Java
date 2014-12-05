using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.lang
{
    [FromJava]
    public class Thread : Runnable
    {
        [FromJava]
        public static Thread currentThread() { return null; }

        [FromJava]
        public long getId() { return 0; }

        [FromJava]
        public void run() { }

        [FromJava]
        public void setDaemon(bool on) { }
    }
}
