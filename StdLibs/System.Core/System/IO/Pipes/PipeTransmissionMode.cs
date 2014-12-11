using System;

namespace System.IO.Pipes
{
    [Serializable]
    public enum PipeTransmissionMode : int
    {
        Byte = 0,
        Message = 1
    }
}
