using System;

namespace System.Security.Cryptography.X509Certificates
{
    public enum X509NameType : int
    {
        SimpleName = 0,
        EmailName = 1,
        UpnName = 2,
        DnsName = 3,
        DnsFromAlternativeName = 4,
        UrlName = 5
    }
}
