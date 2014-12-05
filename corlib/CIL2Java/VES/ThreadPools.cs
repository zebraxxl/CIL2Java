using java.util.concurrent;
using System;
using System.Collections.Generic;

namespace CIL2Java.VES
{
    public static class ThreadPools
    {
        private class DaemonThreadFactory : ThreadFactory
        {
            private ThreadFactory defaultThreadFactory;

            public DaemonThreadFactory()
            {
                defaultThreadFactory = Executors.defaultThreadFactory();
            }

            //TODO: always compile attribute
            public java.lang.Thread newThread(java.lang.Runnable r)
            {
                java.lang.Thread result = defaultThreadFactory.newThread(r);
                result.setDaemon(true);
                return result;
            }
        }

        private static DaemonThreadFactory threadFactory = new DaemonThreadFactory();
        private static ExecutorService asyncPool = null;

        public static ExecutorService AsyncPool
        {
            get
            {
                if (asyncPool == null)
                    asyncPool = Executors.newCachedThreadPool(threadFactory);
                return asyncPool;
            }
        }
    }
}
