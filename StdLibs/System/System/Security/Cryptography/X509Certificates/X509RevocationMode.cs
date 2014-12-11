using System;

namespace System.Security.Cryptography.X509Certificates
{
    public enum X509RevocationMode : int
    {
        NoCheck = 0,
        Online = 1,
        Offline = 2
    }
}
