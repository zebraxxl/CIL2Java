using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Defines the identity permission for files originating in the global assembly cache. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class GacIdentityPermission : CodeAccessPermission
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.GacIdentityPermission" /> class with fully restricted <see cref="T:System.Security.Permissions.PermissionState" />.</summary><param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values.</param><exception cref="T:System.ArgumentException"><paramref name="state" /> is not a valid <see cref="T:System.Security.Permissions.PermissionState" /> value. </exception>
        public GacIdentityPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        public GacIdentityPermission()
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Copy()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the current permission is a subset of the specified permission.</summary><returns>true if the current permission is a subset of the specified permission; otherwise, false.</returns><param name="target">A permission object to test for the subset relationship. The permission must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException"><paramref name="target" /> is not null and is not of the same type as the current permission. </exception>
        public override bool IsSubsetOf(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and returns a permission that is the intersection of the current permission and the specified permission.</summary><returns>A new permission that represents the intersection of the current permission and the specified permission. The new permission is null if the intersection is empty.</returns><param name="target">A permission to intersect with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException"><paramref name="target" /> is not null and is not of the same type as the current permission. </exception>
        public override IPermission Intersect(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and returns a permission that is the union of the current permission and the specified permission.</summary><returns>A new permission that represents the union of the current permission and the specified permission.</returns><param name="target">A permission to combine with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException"><paramref name="target" /> is not null and is not of the same type as the current permission. </exception>
        public override IPermission Union(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        public override SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a permission from an XML encoding.</summary><param name="securityElement">A <see cref="T:System.Security.SecurityElement" />  that contains the XML encoding to use to create the permission. </param><exception cref="T:System.ArgumentNullException"><paramref name="securityElement" />is null. </exception><exception cref="T:System.ArgumentException"><paramref name="securityElement" /> is not a valid permission element. -or- The version number of <paramref name="securityElement" /> is not valid. </exception>
        public override void FromXml(SecurityElement securityElement)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
