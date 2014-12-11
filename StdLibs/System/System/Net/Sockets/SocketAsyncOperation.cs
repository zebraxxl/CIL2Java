using System;

namespace System.Net.Sockets
{
    public enum SocketAsyncOperation : int
    {
        None = 0,
        Accept = 1,
        Connect = 2,
        Disconnect = 3,
        Receive = 4,
        ReceiveFrom = 5,
        ReceiveMessageFrom = 6,
        Send = 7,
        SendPackets = 8,
        SendTo = 9
    }
}
