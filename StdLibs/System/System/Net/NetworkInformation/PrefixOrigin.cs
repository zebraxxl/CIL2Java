using System;

namespace System.Net.NetworkInformation
{
    public enum PrefixOrigin : int
    {
        Other = 0,
        Manual = 1,
        WellKnown = 2,
        Dhcp = 3,
        RouterAdvertisement = 4
    }
}
