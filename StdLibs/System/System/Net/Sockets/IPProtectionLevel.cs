using System;

namespace System.Net.Sockets
{
    public enum IPProtectionLevel : int
    {
        Unspecified = -1,
        Unrestricted = 10,
        EdgeRestricted = 20,
        Restricted = 30
    }
}
