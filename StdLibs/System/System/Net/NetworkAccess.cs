using System;

namespace System.Net
{
    [FlagsAttribute()]
    public enum NetworkAccess : int
    {
        Accept = 128,
        Connect = 64
    }
}
