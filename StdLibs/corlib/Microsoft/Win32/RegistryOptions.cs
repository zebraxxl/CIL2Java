using System;

namespace Microsoft.Win32
{
    /// <summary>Specifies options to use when creating a registry key.</summary>
    [FlagsAttribute()]
    public enum RegistryOptions : int
    {
        /// <summary>A non-volatile key. This is the default.</summary>
        None = 0,
        /// <summary>A volatile key. The information is stored in memory and is not preserved when the corresponding registry hive is unloaded.</summary>
        Volatile = 1
    }
}
