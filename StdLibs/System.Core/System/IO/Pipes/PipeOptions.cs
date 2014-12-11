using System;

namespace System.IO.Pipes
{
    [Serializable]
    [FlagsAttribute()]
    public enum PipeOptions : int
    {
        None = 0,
        WriteThrough = -2147483648,
        Asynchronous = 1073741824
    }
}
