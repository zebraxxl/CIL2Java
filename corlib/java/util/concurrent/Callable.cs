using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.util.concurrent
{
    [FromJava]
    public interface Callable
    {
        [FromJava] object call();
    }
}
