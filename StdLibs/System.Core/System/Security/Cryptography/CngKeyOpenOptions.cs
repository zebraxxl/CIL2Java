using System;

namespace System.Security.Cryptography
{
    [FlagsAttribute()]
    public enum CngKeyOpenOptions : int
    {
        None = 0,
        UserKey = 0,
        MachineKey = 32,
        Silent = 64
    }
}
