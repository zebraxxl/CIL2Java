using System;

namespace System.Security.Cryptography
{
    [FlagsAttribute()]
    public enum CngUIProtectionLevels : int
    {
        None = 0,
        ProtectKey = 1,
        ForceHighProtection = 2
    }
}
