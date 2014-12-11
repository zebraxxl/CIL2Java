using System;

namespace System.IO
{
    [FlagsAttribute()]
    public enum WatcherChangeTypes : int
    {
        Created = 1,
        Deleted = 2,
        Changed = 4,
        Renamed = 8,
        All = 15
    }
}
