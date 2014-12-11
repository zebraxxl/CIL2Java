using System;

namespace System.Diagnostics
{
    [FlagsAttribute()]
    public enum EventLogPermissionAccess : int
    {
        None = 0,
        Write = 16,
        Administer = 48,
        Browse = 2,
        Instrument = 6,
        Audit = 10
    }
}
