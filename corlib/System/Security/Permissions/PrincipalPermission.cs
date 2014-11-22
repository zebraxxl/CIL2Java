using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Allows checks against the active principal (see <see cref="T:System.Security.Principal.IPrincipal" />) using the language constructs defined for both declarative and imperative security actions. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class PrincipalPermission : IPermission, IUnrestrictedPermission
    {
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.PrincipalPermission" /> class with the specified <see cref="T:System.Security.Permissions.PermissionState" />.</summary><param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values. </param><exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid <see cref="T:System.Security.Permissions.PermissionState" />. </exception>
        public PrincipalPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.PrincipalPermission" /> class for the specified <paramref name="name" /> and <paramref name="role" />.</summary><param name="name">The name of the <see cref="T:System.Security.Principal.IPrincipal" /> object's user. </param><param name="role">The role of the <see cref="T:System.Security.Principal.IPrincipal" /> object's user (for example, Administrator). </param>
        public PrincipalPermission(string name, string role)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.PrincipalPermission" /> class for the specified <paramref name="name" />, <paramref name="role" />, and authentication status.</summary><param name="name">The name of the <see cref="T:System.Security.Principal.IPrincipal" /> object's user. </param><param name="role">The role of the <see cref="T:System.Security.Principal.IPrincipal" /> object's user (for example, Administrator). </param><param name="isAuthenticated">true to signify that the user is authenticated; otherwise, false. </param>
        public PrincipalPermission(string name, string role, bool isAuthenticated)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsUnrestricted()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current permission is a subset of the specified permission.</summary><returns>true if the current permission is a subset of the specified permission; otherwise, false.</returns><param name="target">A permission that is to be tested for the subset relationship. This permission must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is an object that is not of the same type as the current permission. </exception>
        public bool IsSubsetOf(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and returns a permission that is the intersection of the current permission and the specified permission.</summary><returns>A new permission that represents the intersection of the current permission and the specified permission. This new permission will be null if the intersection is empty.</returns><param name="target">A permission to intersect with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not an instance of the same class as the current permission. </exception>
        public IPermission Intersect(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a permission that is the union of the current permission and the specified permission.</summary><returns>A new permission that represents the union of the current permission and the specified permission.</returns><param name="other">A permission to combine with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="other" /> parameter is an object that is not of the same type as the current permission. </exception>
        public IPermission Union(IPermission other)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified <see cref="T:System.Security.Permissions.PrincipalPermission" /> object is equal to the current <see cref="T:System.Security.Permissions.PrincipalPermission" />.</summary><returns>true if the specified <see cref="T:System.Security.Permissions.PrincipalPermission" /> is equal to the current <see cref="T:System.Security.Permissions.PrincipalPermission" /> object; otherwise, false.</returns><param name="obj">The <see cref="T:System.Security.Permissions.PrincipalPermission" /> object to compare with the current <see cref="T:System.Security.Permissions.PrincipalPermission" />. </param>
        [ComVisibleAttribute(false)]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public IPermission Copy()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Demand()
        {
             throw new NotImplementedException();
        }
        
        
        public SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a permission with a specified state from an XML encoding.</summary><param name="elem">The XML encoding to use to reconstruct the permission. </param><exception cref="T:System.ArgumentNullException">The <paramref name="elem" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="elem" /> parameter is not a valid permission element.-or- The <paramref name="elem" /> parameter's version number is not valid. </exception>
        public void FromXml(SecurityElement elem)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
