using CIL2Java.Attributes;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public abstract class DelegateRunner : java.lang.Runnable
    {
        [AlwaysCompile]
        public IAsyncResult AsyncResult;
        [AlwaysCompile]
        public AsyncCallback OnEnd;

        [AlwaysCompile]
        public DelegateRunner() { }

        [AlwaysCompile]
        public abstract void run();
    }
}
