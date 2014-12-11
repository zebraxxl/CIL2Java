using System;

namespace System.Diagnostics
{
    public enum ProcessPriorityClass : int
    {
        Normal = 32,
        Idle = 64,
        High = 128,
        RealTime = 256,
        BelowNormal = 16384,
        AboveNormal = 32768
    }
}
