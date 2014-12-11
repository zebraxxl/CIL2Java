using System;

namespace System.IO.MemoryMappedFiles
{
    [Serializable]
    public enum MemoryMappedFileAccess : int
    {
        ReadWrite = 0,
        Read = 1,
        Write = 2,
        CopyOnWrite = 3,
        ReadExecute = 4,
        ReadWriteExecute = 5
    }
}
