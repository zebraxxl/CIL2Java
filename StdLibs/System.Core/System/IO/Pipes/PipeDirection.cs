using System;

namespace System.IO.Pipes
{
    [Serializable]
    public enum PipeDirection : int
    {
        In = 1,
        Out = 2,
        InOut = 3
    }
}
