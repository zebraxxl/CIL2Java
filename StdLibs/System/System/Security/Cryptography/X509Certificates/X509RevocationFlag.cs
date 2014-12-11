using System;

namespace System.Security.Cryptography.X509Certificates
{
    public enum X509RevocationFlag : int
    {
        EndCertificateOnly = 0,
        EntireChain = 1,
        ExcludeRoot = 2
    }
}
