using System;

namespace System.Net
{
    [FlagsAttribute()]
    public enum DecompressionMethods : int
    {
        None = 0,
        GZip = 1,
        Deflate = 2
    }
}
