using System;

namespace System.Net
{
    [FlagsAttribute()]
    public enum SecurityProtocolType : int
    {
        Ssl3 = 48,
        Tls = 192,
        Tls11 = 768,
        Tls12 = 3072
    }
}
