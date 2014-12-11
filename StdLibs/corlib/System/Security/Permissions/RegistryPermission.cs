using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Serialization;
using System.Security.AccessControl;

namespace System.Security.Permissions
{
    /// <summary>Controls the ability to access registry variables. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class RegistryPermission : CodeAccessPermission, IUnrestrictedPermission
    {
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.RegistryPermission" /> class with either fully restricted or unrestricted permission as specified.</summary><param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values. </param><exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.PermissionState" />. </exception>
        public RegistryPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.RegistryPermission" /> class with the specified access to the specified registry variables.</summary><param name="access">One of the <see cref="T:System.Security.Permissions.RegistryPermissionAccess" /> values. </param><param name="pathList">A list of registry variables (semicolon-separated) to which access is granted. </param><exception cref="T:System.ArgumentException">The <paramref name="access" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.-or- The <paramref name="pathList" /> parameter is not a valid string. </exception>
        public RegistryPermission(RegistryPermissionAccess access, string pathList)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.RegistryPermission" /> class with the specified access to the specified registry variables and the specified access rights to registry control information.</summary><param name="access">One of the <see cref="T:System.Security.Permissions.RegistryPermissionAccess" /> values.</param><param name="control">A bitwise combination of the <see cref="T:System.Security.AccessControl.AccessControlActions" />  values.</param><param name="pathList">A list of registry variables (semicolon-separated) to which access is granted.</param><exception cref="T:System.ArgumentException">The <paramref name="access" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.-or- The <paramref name="pathList" /> parameter is not a valid string. </exception>
        public RegistryPermission(RegistryPermissionAccess access, AccessControlActions control, string pathList)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets new access for the specified registry variable names to the existing state of the permission.</summary><param name="access">One of the <see cref="T:System.Security.Permissions.RegistryPermissionAccess" /> values. </param><param name="pathList">A list of registry variables (semicolon-separated). </param><exception cref="T:System.ArgumentException">The <paramref name="access" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.-or- The <paramref name="pathList" /> parameter is not a valid string. </exception>
        public void SetPathList(RegistryPermissionAccess access, string pathList)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds access for the specified registry variables to the existing state of the permission.</summary><param name="access">One of the <see cref="T:System.Security.Permissions.RegistryPermissionAccess" /> values. </param><param name="pathList">A list of registry variables (semicolon-separated). </param><exception cref="T:System.ArgumentException">The <paramref name="access" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.-or- The <paramref name="pathList" /> parameter is not a valid string. </exception>
        public void AddPathList(RegistryPermissionAccess access, string pathList)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds access for the specified registry variables to the existing state of the permission, specifying registry permission access and access control actions.</summary><param name="access">One of the <see cref="T:System.Security.Permissions.RegistryPermissionAccess" /> values. </param><param name="control">One of the <see cref="T:System.Security.AccessControl.AccessControlActions" /> values. </param><param name="pathList">A list of registry variables (separated by semicolons).</param><exception cref="T:System.ArgumentException">The <paramref name="access" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.-or- The <paramref name="pathList" /> parameter is not a valid string. </exception>
        [SecuritySafeCriticalAttribute()]
        public void AddPathList(RegistryPermissionAccess access, AccessControlActions control, string pathList)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets paths for all registry variables with the specified <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.</summary><returns>A list of the registry variables (semicolon-separated) with the specified <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.</returns><param name="access">One of the <see cref="T:System.Security.Permissions.RegistryPermissionAccess" /> values that represents a single type of registry variable access. </param><exception cref="T:System.ArgumentException"><paramref name="access" /> is not a valid value of <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />.-or- <paramref name="access" /> is <see cref="F:System.Security.Permissions.RegistryPermissionAccess.AllAccess" />, which represents more than one type of registry variable access, or <see cref="F:System.Security.Permissions.RegistryPermissionAccess.NoAccess" />, which does not represent any type of registry variable access. </exception>
        [SecuritySafeCriticalAttribute()]
        public string GetPathList(RegistryPermissionAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsUnrestricted()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current permission is a subset of the specified permission.</summary><returns>true if the current permission is a subset of the specified permission; otherwise, false.</returns><param name="target">A permission that is to be tested for the subset relationship. This permission must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        [SecuritySafeCriticalAttribute()]
        public override bool IsSubsetOf(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and returns a permission that is the intersection of the current permission and the specified permission.</summary><returns>A new permission that represents the intersection of the current permission and the specified permission. This new permission is null if the intersection is empty.</returns><param name="target">A permission to intersect with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        [SecuritySafeCriticalAttribute()]
        public override IPermission Intersect(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a permission that is the union of the current permission and the specified permission.</summary><returns>A new permission that represents the union of the current permission and the specified permission.</returns><param name="other">A permission to combine with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="other" /> parameter is not null and is not of the same type as the current permission. </exception>
        [SecuritySafeCriticalAttribute()]
        public override IPermission Union(IPermission other)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Copy()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a permission with a specified state from an XML encoding.</summary><param name="esd">The XML encoding to use to reconstruct the permission. </param><exception cref="T:System.ArgumentNullException">The <paramref name="esd" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="esd" /> parameter is not a valid permission element.-or- The <paramref name="esd" /> parameter's version number is not valid. </exception>
        public override void FromXml(SecurityElement esd)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
