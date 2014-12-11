using System;

namespace System.Security.Cryptography.X509Certificates
{
    [FlagsAttribute()]
    public enum OpenFlags : int
    {
        ReadOnly = 0,
        ReadWrite = 1,
        MaxAllowed = 2,
        OpenExistingOnly = 4,
        IncludeArchived = 8
    }
}
