using System;

namespace System.Net.WebSockets
{
    public enum WebSocketError : int
    {
        Success = 0,
        InvalidMessageType = 1,
        Faulted = 2,
        NativeError = 3,
        NotAWebSocket = 4,
        UnsupportedVersion = 5,
        UnsupportedProtocol = 6,
        HeaderError = 7,
        ConnectionClosedPrematurely = 8,
        InvalidState = 9
    }
}
