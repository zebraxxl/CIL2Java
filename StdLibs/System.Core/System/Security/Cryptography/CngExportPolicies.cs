using System;

namespace System.Security.Cryptography
{
    [FlagsAttribute()]
    public enum CngExportPolicies : int
    {
        None = 0,
        AllowExport = 1,
        AllowPlaintextExport = 2,
        AllowArchiving = 4,
        AllowPlaintextArchiving = 8
    }
}
