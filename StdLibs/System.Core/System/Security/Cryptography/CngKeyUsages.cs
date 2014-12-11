using System;

namespace System.Security.Cryptography
{
    [FlagsAttribute()]
    public enum CngKeyUsages : int
    {
        None = 0,
        Decryption = 1,
        Signing = 2,
        KeyAgreement = 4,
        AllUsages = 16777215
    }
}
