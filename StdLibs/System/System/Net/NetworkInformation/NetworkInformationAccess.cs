using System;

namespace System.Net.NetworkInformation
{
    [FlagsAttribute()]
    public enum NetworkInformationAccess : int
    {
        None = 0,
        Read = 1,
        Ping = 4
    }
}
