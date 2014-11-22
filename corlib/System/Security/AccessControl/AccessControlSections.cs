using System;

namespace System.Security.AccessControl
{
    /// <summary>Specifies which sections of a security descriptor to save or load.</summary>
    [FlagsAttribute()]
    public enum AccessControlSections : int
    {
        /// <summary>No sections.</summary>
        None = 0,
        /// <summary>The system access control list (SACL).</summary>
        Audit = 1,
        /// <summary>The discretionary access control list (DACL).</summary>
        Access = 2,
        /// <summary>The owner.</summary>
        Owner = 4,
        /// <summary>The primary group.</summary>
        Group = 8,
        /// <summary>The entire security descriptor.</summary>
        All = 15
    }
}
