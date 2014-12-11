using System;

namespace System.Security.Cryptography.X509Certificates
{
    public enum TrustStatus : int
    {
        Untrusted = 0,
        UnknownIdentity = 1,
        KnownIdentity = 2,
        Trusted = 3
    }
}
