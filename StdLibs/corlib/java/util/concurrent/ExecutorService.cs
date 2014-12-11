using CIL2Java.Attributes;
using java.lang;
using System;
using System.Collections.Generic;

namespace java.util.concurrent
{
    [FromJava]
    public interface ExecutorService : Executor
    {
        [FromJava] void shutdown();
        [FromJava] List shutdownNow();
        [FromJava] bool isShutdown();
        [FromJava] bool isTerminated();
        [FromJava] bool awaitTermination(long timeout, TimeUnit unit);
        [FromJava] Future submit(Callable task);
        [FromJava] Future submit(Runnable task, object result);
        [FromJava] Future submit(Runnable task);
        [FromJava] List invokeAll(Collection tasks);
        [FromJava] List invokeAll(Collection tasks, long timeout, TimeUnit unit);
        [FromJava] object invokeAny(Collection tasks);
        [FromJava] object invokeAny(Collection tasks, long timeout, TimeUnit unit);
    }
}
