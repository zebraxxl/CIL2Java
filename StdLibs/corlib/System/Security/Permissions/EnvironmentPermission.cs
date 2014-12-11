using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Controls access to system and user environment variables. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class EnvironmentPermission : CodeAccessPermission, IUnrestrictedPermission
    {
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.EnvironmentPermission" /> class with either restricted or unrestricted permission as specified.</summary><param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values. </param><exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.PermissionState" />. </exception>
        public EnvironmentPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.EnvironmentPermission" /> class with the specified access to the specified environment variables.</summary><param name="flag">One of the <see cref="T:System.Security.Permissions.EnvironmentPermissionAccess" /> values. </param><param name="pathList">A list of environment variables (semicolon-separated) to which access is granted. </param><exception cref="T:System.ArgumentNullException">The <paramref name="pathList" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="flag" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.EnvironmentPermissionAccess" />. </exception>
        public EnvironmentPermission(EnvironmentPermissionAccess flag, string pathList)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the specified access to the specified environment variables to the existing state of the permission.</summary><param name="flag">One of the <see cref="T:System.Security.Permissions.EnvironmentPermissionAccess" /> values. </param><param name="pathList">A list of environment variables (semicolon-separated). </param><exception cref="T:System.ArgumentNullException">The <paramref name="pathList" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="flag" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.EnvironmentPermissionAccess" />. </exception>
        public void SetPathList(EnvironmentPermissionAccess flag, string pathList)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds access for the specified environment variables to the existing state of the permission.</summary><param name="flag">One of the <see cref="T:System.Security.Permissions.EnvironmentPermissionAccess" /> values. </param><param name="pathList">A list of environment variables (semicolon-separated). </param><exception cref="T:System.ArgumentNullException">The <paramref name="pathList" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="flag" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.EnvironmentPermissionAccess" />. </exception>
        [SecuritySafeCriticalAttribute()]
        public void AddPathList(EnvironmentPermissionAccess flag, string pathList)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets all environment variables with the specified <see cref="T:System.Security.Permissions.EnvironmentPermissionAccess" />.</summary><returns>A list of environment variables (semicolon-separated) for the selected flag.</returns><param name="flag">One of the <see cref="T:System.Security.Permissions.EnvironmentPermissionAccess" /> values that represents a single type of environment variable access. </param><exception cref="T:System.ArgumentException"><paramref name="flag" /> is not a valid value of <see cref="T:System.Security.Permissions.EnvironmentPermissionAccess" />.-or- <paramref name="flag" /> is <see cref="F:System.Security.Permissions.EnvironmentPermissionAccess.AllAccess" />, which represents more than one type of environment variable access, or <see cref="F:System.Security.Permissions.EnvironmentPermissionAccess.NoAccess" />, which does not represent any type of environment variable access. </exception>
        public string GetPathList(EnvironmentPermissionAccess flag)
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
