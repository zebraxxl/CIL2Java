using System;

namespace System.Net.Sockets
{
    public enum SelectMode : int
    {
        SelectRead = 0,
        SelectWrite = 1,
        SelectError = 2
    }
}
