using System;

namespace System.Diagnostics
{
    [FlagsAttribute()]
    public enum PerformanceCounterPermissionAccess : int
    {
        Browse = 1,
        Instrument = 3,
        None = 0,
        Read = 1,
        Write = 2,
        Administer = 7
    }
}
