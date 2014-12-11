using CIL2Java.Attributes;
using java.lang;
using System;
using System.Collections.Generic;

namespace java.util.concurrent
{
    [FromJava]
    public interface Executor
    {
        [FromJava] void execute(Runnable command);
    }
}
