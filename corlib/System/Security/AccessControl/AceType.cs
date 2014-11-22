using System;

namespace System.Security.AccessControl
{
    /// <summary>Defines the available access control entry (ACE) types.</summary>
    public enum AceType : byte
    {
        /// <summary>Allows access to an object for a specific trustee identified by an <see cref="T:System.Security.Principal.IdentityReference" /> object.</summary>
        AccessAllowed = 0,
        /// <summary>Denies access to an object for a specific trustee identified by an <see cref="T:System.Security.Principal.IdentityReference" /> object.</summary>
        AccessDenied = 1,
        /// <summary>Causes an audit message to be logged when a specified trustee attempts to gain access to an object. The trustee is identified by an <see cref="T:System.Security.Principal.IdentityReference" /> object.</summary>
        SystemAudit = 2,
        /// <summary>Reserved for future use.</summary>
        SystemAlarm = 3,
        /// <summary>Defined but never used. Included here for completeness.</summary>
        AccessAllowedCompound = 4,
        /// <summary>Allows access to an object, property set, or property. The ACE contains a set of access rights, a GUID that identifies the type of object, and an <see cref="T:System.Security.Principal.IdentityReference" /> object that identifies the trustee to whom the system will grant access. The ACE also contains a GUID and a set of flags that control inheritance of the ACE by child objects.</summary>
        AccessAllowedObject = 5,
        /// <summary>Denies access to an object, property set, or property. The ACE contains a set of access rights, a GUID that identifies the type of object, and an <see cref="T:System.Security.Principal.IdentityReference" /> object that identifies the trustee to whom the system will grant access. The ACE also contains a GUID and a set of flags that control inheritance of the ACE by child objects.</summary>
        AccessDeniedObject = 6,
        /// <summary>Causes an audit message to be logged when a specified trustee attempts to gain access to an object or subobjects such as property sets or properties. The ACE contains a set of access rights, a GUID that identifies the type of object or subobject, and an <see cref="T:System.Security.Principal.IdentityReference" /> object that identifies the trustee for whom the system will audit access. The ACE also contains a GUID and a set of flags that control inheritance of the ACE by child objects.</summary>
        SystemAuditObject = 7,
        /// <summary>Reserved for future use.</summary>
        SystemAlarmObject = 8,
        /// <summary>Allows access to an object for a specific trustee identified by an <see cref="T:System.Security.Principal.IdentityReference" /> object. This ACE type may contain optional callback data. The callback data is a resource manager–specific BLOB that is not interpreted.</summary>
        AccessAllowedCallback = 9,
        /// <summary>Denies access to an object for a specific trustee identified by an <see cref="T:System.Security.Principal.IdentityReference" /> object. This ACE type can contain optional callback data. The callback data is a resource manager–specific BLOB that is not interpreted.</summary>
        AccessDeniedCallback = 10,
        /// <summary>Allows access to an object, property set, or property. The ACE contains a set of access rights, a GUID that identifies the type of object, and an <see cref="T:System.Security.Principal.IdentityReference" /> object that identifies the trustee to whom the system will grant access. The ACE also contains a GUID and a set of flags that control inheritance of the ACE by child objects. This ACE type may contain optional callback data. The callback data is a resource manager–specific BLOB that is not interpreted.</summary>
        AccessAllowedCallbackObject = 11,
        /// <summary>Denies access to an object, property set, or property. The ACE contains a set of access rights, a GUID that identifies the type of object, and an <see cref="T:System.Security.Principal.IdentityReference" /> object that identifies the trustee to whom the system will grant access. The ACE also contains a GUID and a set of flags that control inheritance of the ACE by child objects. This ACE type can contain optional callback data. The callback data is a resource manager–specific BLOB that is not interpreted.</summary>
        AccessDeniedCallbackObject = 12,
        /// <summary>Causes an audit message to be logged when a specified trustee attempts to gain access to an object. The trustee is identified by an <see cref="T:System.Security.Principal.IdentityReference" /> object. This ACE type can contain optional callback data. The callback data is a resource manager–specific BLOB that is not interpreted.</summary>
        SystemAuditCallback = 13,
        /// <summary>Reserved for future use.</summary>
        SystemAlarmCallback = 14,
        /// <summary>Causes an audit message to be logged when a specified trustee attempts to gain access to an object or subobjects such as property sets or properties. The ACE contains a set of access rights, a GUID that identifies the type of object or subobject, and an <see cref="T:System.Security.Principal.IdentityReference" /> object that identifies the trustee for whom the system will audit access. The ACE also contains a GUID and a set of flags that control inheritance of the ACE by child objects. This ACE type can contain optional callback data. The callback data is a resource manager–specific BLOB that is not interpreted.</summary>
        SystemAuditCallbackObject = 15,
        /// <summary>Reserved for future use.</summary>
        SystemAlarmCallbackObject = 16,
        /// <summary>Tracks the maximum defined ACE type in the enumeration.</summary>
        MaxDefinedAceType = 16
    }
}
