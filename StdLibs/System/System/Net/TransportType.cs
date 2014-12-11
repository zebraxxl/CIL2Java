using System;

namespace System.Net
{
    public enum TransportType : int
    {
        Udp = 1,
        Connectionless = 1,
        Tcp = 2,
        ConnectionOriented = 2,
        All = 3
    }
}
