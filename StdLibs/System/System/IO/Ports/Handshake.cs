using System;

namespace System.IO.Ports
{
    public enum Handshake : int
    {
        None = 0,
        XOnXOff = 1,
        RequestToSend = 2,
        RequestToSendXOnXOff = 3
    }
}
