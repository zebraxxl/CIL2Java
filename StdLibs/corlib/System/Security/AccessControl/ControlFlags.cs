using System;

namespace System.Security.AccessControl
{
    /// <summary>These flags affect the security descriptor behavior.</summary>
    [FlagsAttribute()]
    public enum ControlFlags : int
    {
        /// <summary>No control flags.</summary>
        None = 0,
        /// <summary>Specifies that the owner <see cref="T:System.Security.Principal.SecurityIdentifier" /> was obtained by a defaulting mechanism. Set by resource managers only; should not be set by callers.  </summary>
        OwnerDefaulted = 1,
        /// <summary>Specifies that the group <see cref="T:System.Security.Principal.SecurityIdentifier" /> was obtained by a defaulting mechanism. Set by resource managers only; should not be set by callers.</summary>
        GroupDefaulted = 2,
        /// <summary>Specifies that the DACL is not null. Set by resource managers or users.  </summary>
        DiscretionaryAclPresent = 4,
        /// <summary>Specifies that the DACL was obtained by a defaulting mechanism. Set by resource managers only.</summary>
        DiscretionaryAclDefaulted = 8,
        /// <summary>Specifies that the SACL is not null. Set by resource managers or users.</summary>
        SystemAclPresent = 16,
        /// <summary>Specifies that the SACL was obtained by a defaulting mechanism. Set by resource managers only.</summary>
        SystemAclDefaulted = 32,
        /// <summary>Ignored.</summary>
        DiscretionaryAclUntrusted = 64,
        /// <summary>Ignored.</summary>
        ServerSecurity = 128,
        /// <summary>Ignored.</summary>
        DiscretionaryAclAutoInheritRequired = 256,
        /// <summary>Ignored.</summary>
        SystemAclAutoInheritRequired = 512,
        /// <summary>Specifies that the Discretionary Access Control List (DACL) has been automatically inherited from the parent. Set by resource managers only.</summary>
        DiscretionaryAclAutoInherited = 1024,
        /// <summary>Specifies that the System Access Control List (SACL) has been automatically inherited from the parent. Set by resource managers only.</summary>
        SystemAclAutoInherited = 2048,
        /// <summary>Specifies that the resource manager prevents auto-inheritance. Set by resource managers or users.  </summary>
        DiscretionaryAclProtected = 4096,
        /// <summary>Specifies that the resource manager prevents auto-inheritance. Set by resource managers or users.</summary>
        SystemAclProtected = 8192,
        /// <summary>Specifies that the contents of the Reserved field are valid.</summary>
        RMControlValid = 16384,
        /// <summary>Specifies that the security descriptor binary representation is in the self-relative format.  This flag is always set.</summary>
        SelfRelative = 32768
    }
}
