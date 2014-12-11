using System;

namespace System.Security.Cryptography.X509Certificates
{
    [FlagsAttribute()]
    public enum X500DistinguishedNameFlags : int
    {
        None = 0,
        Reversed = 1,
        UseSemicolons = 16,
        DoNotUsePlusSign = 32,
        DoNotUseQuotes = 64,
        UseCommas = 128,
        UseNewLines = 256,
        UseUTF8Encoding = 4096,
        UseT61Encoding = 8192,
        ForceUTF8Encoding = 16384
    }
}
