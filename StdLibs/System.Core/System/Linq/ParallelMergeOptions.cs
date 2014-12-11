using System;

namespace System.Linq
{
    public enum ParallelMergeOptions : int
    {
        Default = 0,
        NotBuffered = 1,
        AutoBuffered = 2,
        FullyBuffered = 3
    }
}
