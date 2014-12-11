using System;

namespace System.IO.MemoryMappedFiles
{
    [Serializable]
    [FlagsAttribute()]
    public enum MemoryMappedFileOptions : int
    {
        None = 0,
        DelayAllocatePages = 67108864
    }
}
