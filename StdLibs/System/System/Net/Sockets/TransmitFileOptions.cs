using System;

namespace System.Net.Sockets
{
    [FlagsAttribute()]
    public enum TransmitFileOptions : int
    {
        UseDefaultWorkerThread = 0,
        Disconnect = 1,
        ReuseSocket = 2,
        WriteBehind = 4,
        UseSystemThread = 16,
        UseKernelApc = 32
    }
}
