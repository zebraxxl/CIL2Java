using System;

namespace System.Net.NetworkInformation
{
    public enum DuplicateAddressDetectionState : int
    {
        Invalid = 0,
        Tentative = 1,
        Duplicate = 2,
        Deprecated = 3,
        Preferred = 4
    }
}
