using System;

namespace System.Net.Security
{
    [FlagsAttribute()]
    public enum SslPolicyErrors : int
    {
        None = 0,
        RemoteCertificateNotAvailable = 1,
        RemoteCertificateNameMismatch = 2,
        RemoteCertificateChainErrors = 4
    }
}
