using System;

namespace System.Security.AccessControl
{
    /// <summary>Specifies the conditions for auditing attempts to access a securable object.</summary>
    [FlagsAttribute()]
    public enum AuditFlags : int
    {
        /// <summary>No access attempts are to be audited.</summary>
        None = 0,
        /// <summary>Successful access attempts are to be audited.</summary>
        Success = 1,
        /// <summary>Failed access attempts are to be audited.</summary>
        Failure = 2
    }
}
