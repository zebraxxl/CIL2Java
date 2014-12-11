using System;

namespace System.Security.Cryptography
{
    [FlagsAttribute()]
    public enum CngKeyHandleOpenOptions : int
    {
        None = 0,
        EphemeralKey = 1
    }
}
