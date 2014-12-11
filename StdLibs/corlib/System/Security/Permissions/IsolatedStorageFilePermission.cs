using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Specifies the allowed usage of a private virtual file system. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class IsolatedStorageFilePermission : IsolatedStoragePermission
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.IsolatedStorageFilePermission" /> class with either fully restricted or unrestricted permission as specified.</summary><param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values. </param><exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.PermissionState" />. </exception>
        public IsolatedStorageFilePermission(PermissionState state)
            : base(state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a permission that is the union of the current permission and the specified permission.</summary><returns>A new permission that represents the union of the current permission and the specified permission.</returns><param name="target">A permission to combine with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        public override IPermission Union(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current permission is a subset of the specified permission.</summary><returns>true if the current permission is a subset of the specified permission; otherwise, false.</returns><param name="target">A permission that is to be tested for the subset relationship. This permission must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        public override bool IsSubsetOf(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and returns a permission that is the intersection of the current permission and the specified permission.</summary><returns>A new permission that represents the intersection of the current permission and the specified permission. This new permission is null if the intersection is empty.</returns><param name="target">A permission to intersect with the current permission object. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        public override IPermission Intersect(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Copy()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public override SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
