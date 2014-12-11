using System;

namespace System.Net.Sockets
{
    public enum SocketShutdown : int
    {
        Receive = 0,
        Send = 1,
        Both = 2
    }
}
