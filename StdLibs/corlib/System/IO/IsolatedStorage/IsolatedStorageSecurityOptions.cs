using System;

namespace System.IO.IsolatedStorage
{
    /// <summary>Specifies options that affect security in isolated storage.</summary>
    public enum IsolatedStorageSecurityOptions : int
    {
        /// <summary>The quota can be increased for isolated storage.</summary>
        IncreaseQuotaForApplication = 4
    }
}
