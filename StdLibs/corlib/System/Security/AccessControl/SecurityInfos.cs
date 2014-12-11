using System;

namespace System.Security.AccessControl
{
    /// <summary>Specifies the section of a security descriptor to be queried or set.</summary>
    [FlagsAttribute()]
    public enum SecurityInfos : int
    {
        /// <summary>Specifies the owner identifier.</summary>
        Owner = 1,
        /// <summary>Specifies the primary group identifier.</summary>
        Group = 2,
        /// <summary>Specifies the discretionary access control list (DACL).</summary>
        DiscretionaryAcl = 4,
        /// <summary>Specifies the system access control list (SACL).</summary>
        SystemAcl = 8
    }
}
