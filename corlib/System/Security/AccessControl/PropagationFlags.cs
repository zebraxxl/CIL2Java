using System;

namespace System.Security.AccessControl
{
    /// <summary>Specifies how Access Control Entries (ACEs) are propagated to child objects.  These flags are significant only if inheritance flags are present. </summary>
    [FlagsAttribute()]
    public enum PropagationFlags : int
    {
        /// <summary>Specifies that no inheritance flags are set.</summary>
        None = 0,
        /// <summary>Specifies that the ACE is not propagated to child objects.</summary>
        NoPropagateInherit = 1,
        /// <summary>Specifies that the ACE is propagated only to child objects. This includes both container and leaf child objects. </summary>
        InheritOnly = 2
    }
}
