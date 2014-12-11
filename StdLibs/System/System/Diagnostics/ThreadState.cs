using System;

namespace System.Diagnostics
{
    public enum ThreadState : int
    {
        Initialized = 0,
        Ready = 1,
        Running = 2,
        Standby = 3,
        Terminated = 4,
        Wait = 5,
        Transition = 6,
        Unknown = 7
    }
}
