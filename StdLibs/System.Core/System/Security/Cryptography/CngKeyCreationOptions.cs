using System;

namespace System.Security.Cryptography
{
    [FlagsAttribute()]
    public enum CngKeyCreationOptions : int
    {
        None = 0,
        MachineKey = 32,
        OverwriteExistingKey = 128
    }
}
