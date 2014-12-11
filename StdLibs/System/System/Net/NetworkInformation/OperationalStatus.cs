using System;

namespace System.Net.NetworkInformation
{
    public enum OperationalStatus : int
    {
        Up = 1,
        Down = 2,
        Testing = 3,
        Unknown = 4,
        Dormant = 5,
        NotPresent = 6,
        LowerLayerDown = 7
    }
}
