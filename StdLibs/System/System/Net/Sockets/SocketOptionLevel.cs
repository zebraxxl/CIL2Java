using System;

namespace System.Net.Sockets
{
    public enum SocketOptionLevel : int
    {
        Socket = 65535,
        IP = 0,
        IPv6 = 41,
        Tcp = 6,
        Udp = 17
    }
}
