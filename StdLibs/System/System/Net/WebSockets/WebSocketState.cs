using System;

namespace System.Net.WebSockets
{
    public enum WebSocketState : int
    {
        None = 0,
        Connecting = 1,
        Open = 2,
        CloseSent = 3,
        CloseReceived = 4,
        Closed = 5,
        Aborted = 6
    }
}
