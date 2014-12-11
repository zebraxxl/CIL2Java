using System;

namespace System.Net.Sockets
{
    [FlagsAttribute()]
    public enum SocketInformationOptions : int
    {
        NonBlocking = 1,
        Connected = 2,
        Listening = 4,
        UseOnlyOverlappedIO = 8
    }
}
