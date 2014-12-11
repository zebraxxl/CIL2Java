using System;

namespace System.Diagnostics
{
    [FlagsAttribute()]
    public enum SourceLevels : int
    {
        Off = 0,
        Critical = 1,
        Error = 3,
        Warning = 7,
        Information = 15,
        Verbose = 31,
        ActivityTracing = 65280,
        All = -1
    }
}
