using System;

namespace System.Diagnostics
{
    [FlagsAttribute()]
    public enum TraceOptions : int
    {
        None = 0,
        LogicalOperationStack = 1,
        DateTime = 2,
        Timestamp = 4,
        ProcessId = 8,
        ThreadId = 16,
        Callstack = 32
    }
}
