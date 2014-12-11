using System;

namespace System.Net.Security
{
    public enum ProtectionLevel : int
    {
        None = 0,
        Sign = 1,
        EncryptAndSign = 2
    }
}
