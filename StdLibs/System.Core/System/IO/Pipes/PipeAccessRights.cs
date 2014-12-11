using System;

namespace System.IO.Pipes
{
    [FlagsAttribute()]
    public enum PipeAccessRights : int
    {
        ReadData = 1,
        WriteData = 2,
        ReadAttributes = 128,
        WriteAttributes = 256,
        ReadExtendedAttributes = 8,
        WriteExtendedAttributes = 16,
        CreateNewInstance = 4,
        Delete = 65536,
        ReadPermissions = 131072,
        ChangePermissions = 262144,
        TakeOwnership = 524288,
        Synchronize = 1048576,
        FullControl = 2032031,
        Read = 131209,
        Write = 274,
        ReadWrite = 131483,
        AccessSystemSecurity = 16777216
    }
}
