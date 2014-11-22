using System.Runtime.InteropServices;
using System;

namespace System.Security.Principal
{
    /// <summary>Specifies common roles to be used with <see cref="M:System.Security.Principal.WindowsPrincipal.IsInRole(System.String)" />.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum WindowsBuiltInRole : int
    {
        /// <summary>Administrators have complete and unrestricted access to the computer or domain.</summary>
        Administrator = 544,
        /// <summary>Users are prevented from making accidental or intentional system-wide changes. Thus, users can run certified applications, but not most legacy applications.</summary>
        User = 545,
        /// <summary>Guests are more restricted than users.</summary>
        Guest = 546,
        /// <summary>Power users possess most administrative permissions with some restrictions. Thus, power users can run legacy applications, in addition to certified applications.</summary>
        PowerUser = 547,
        /// <summary>Account operators manage the user accounts on a computer or domain.</summary>
        AccountOperator = 548,
        /// <summary>System operators manage a particular computer.</summary>
        SystemOperator = 549,
        /// <summary>Print operators can take control of a printer.</summary>
        PrintOperator = 550,
        /// <summary>Backup operators can override security restrictions for the sole purpose of backing up or restoring files.</summary>
        BackupOperator = 551,
        /// <summary>Replicators support file replication in a domain.</summary>
        Replicator = 552
    }
}
