using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.util.concurrent
{
    [FromJava]
    public class Executors
    {
        [FromJava]
        public static ThreadFactory defaultThreadFactory() { return null; }

        [FromJava]
        public static ExecutorService newCachedThreadPool() { return null; }

        [FromJava]
        public static ExecutorService newCachedThreadPool(ThreadFactory threadFactory) { return null; }
    }
}
