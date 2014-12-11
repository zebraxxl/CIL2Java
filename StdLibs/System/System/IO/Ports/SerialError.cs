using System;

namespace System.IO.Ports
{
    public enum SerialError : int
    {
        TXFull = 256,
        RXOver = 1,
        Overrun = 2,
        RXParity = 4,
        Frame = 8
    }
}
