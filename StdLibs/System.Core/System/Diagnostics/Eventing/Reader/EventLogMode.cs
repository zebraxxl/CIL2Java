using System;

namespace System.Diagnostics.Eventing.Reader
{
    public enum EventLogMode : int
    {
        Circular = 0,
        AutoBackup = 1,
        Retain = 2
    }
}
