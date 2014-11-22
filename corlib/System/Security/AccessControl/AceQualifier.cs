using System;

namespace System.Security.AccessControl
{
    /// <summary>Specifies the function of an access control entry (ACE).</summary>
    public enum AceQualifier : int
    {
        /// <summary>Allow access.</summary>
        AccessAllowed = 0,
        /// <summary>Deny access.</summary>
        AccessDenied = 1,
        /// <summary>Cause a system audit.</summary>
        SystemAudit = 2,
        /// <summary>Cause a system alarm.</summary>
        SystemAlarm = 3
    }
}
