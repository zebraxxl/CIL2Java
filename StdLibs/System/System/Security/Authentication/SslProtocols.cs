using System;

namespace System.Security.Authentication
{
    [FlagsAttribute()]
    public enum SslProtocols : int
    {
        None = 0,
        Ssl2 = 12,
        Ssl3 = 48,
        Tls = 192,
        Tls11 = 768,
        Tls12 = 3072,
        Default = 240
    }
}
