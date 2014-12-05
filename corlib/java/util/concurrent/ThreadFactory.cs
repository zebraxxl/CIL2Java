using CIL2Java.Attributes;
using java.lang;
using System;
using System.Collections.Generic;

namespace java.util.concurrent
{
    [FromJava]
    public interface ThreadFactory
    {
        [FromJava]
        Thread newThread(Runnable r);
    }
}
