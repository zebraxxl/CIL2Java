using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace java.util.concurrent
{
    [FromJava]
    public interface Future
    {
        [FromJava] bool cancel(bool mayInterruptIfRunning);
        [FromJava] bool isCancelled();
        [FromJava] bool isDone();
        [FromJava] object get();
        [FromJava] object get(long timeout, TimeUnit unit);
    }
}
