using System;

namespace System.Net.Security
{
    public enum EncryptionPolicy : int
    {
        RequireEncryption = 0,
        AllowNoEncryption = 1,
        NoEncryption = 2
    }
}
