using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public abstract class DelegateRunner : java.lang.Runnable
    {
        public IAsyncResult AsyncResult;
        public AsyncCallback OnEnd;

        public abstract void run();
    }
}
