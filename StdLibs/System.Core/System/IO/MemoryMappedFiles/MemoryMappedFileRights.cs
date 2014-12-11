using System;

namespace System.IO.MemoryMappedFiles
{
    [FlagsAttribute()]
    public enum MemoryMappedFileRights : int
    {
        CopyOnWrite = 1,
        Write = 2,
        Read = 4,
        Execute = 8,
        Delete = 65536,
        ReadPermissions = 131072,
        ChangePermissions = 262144,
        TakeOwnership = 524288,
        ReadWrite = 6,
        ReadExecute = 12,
        ReadWriteExecute = 14,
        FullControl = 983055,
        AccessSystemSecurity = 16777216
    }
}
