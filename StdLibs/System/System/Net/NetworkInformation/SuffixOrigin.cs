using System;

namespace System.Net.NetworkInformation
{
    public enum SuffixOrigin : int
    {
        Other = 0,
        Manual = 1,
        WellKnown = 2,
        OriginDhcp = 3,
        LinkLayerAddress = 4,
        Random = 5
    }
}
