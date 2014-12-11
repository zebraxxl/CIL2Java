using System;

namespace System.Security.Cryptography.X509Certificates
{
    public enum X509IncludeOption : int
    {
        None = 0,
        ExcludeRoot = 1,
        EndCertOnly = 2,
        WholeChain = 3
    }
}
