using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Controls the ability to access files or folders through a File dialog box. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class FileDialogPermission : CodeAccessPermission, IUnrestrictedPermission
    {
    
        /// <summary>Gets or sets the permitted access to files.</summary><returns>The permitted access to files.</returns><exception cref="T:System.ArgumentException">An attempt is made to set the <paramref name="access" /> parameter to a value that is not a valid combination of the <see cref="T:System.Security.Permissions.FileDialogPermissionAccess" /> values. </exception>
        public FileDialogPermissionAccess Access
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.FileDialogPermission" /> class with either restricted or unrestricted permission, as specified.</summary><param name="state">One of the <see cref="T:System.Security.Permissions.PermissionState" /> values (Unrestricted or None). </param><exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid value of <see cref="T:System.Security.Permissions.PermissionState" />. </exception>
        public FileDialogPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.FileDialogPermission" /> class with the specified access.</summary><param name="access">A bitwise combination of the <see cref="T:System.Security.Permissions.FileDialogPermissionAccess" /> values. </param><exception cref="T:System.ArgumentException">The <paramref name="access" /> parameter is not a valid combination of the <see cref="T:System.Security.Permissions.FileDialogPermissionAccess" /> values. </exception>
        public FileDialogPermission(FileDialogPermissionAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission Copy()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Reconstructs a permission with a specified state from an XML encoding.</summary><param name="esd">The XML encoding used to reconstruct the permission. </param><exception cref="T:System.ArgumentNullException">The <paramref name="esd" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="esd" /> parameter is not a valid permission element.-or- The version number of the <paramref name="esd" /> parameter is not supported. </exception>
        public override void FromXml(SecurityElement esd)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and returns a permission that is the intersection of the current permission and the specified permission.</summary><returns>A new permission that represents the intersection of the current permission and the specified permission. This new permission is null if the intersection is empty.</returns><param name="target">A permission to intersect with the current permission. It must be the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        public override IPermission Intersect(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current permission is a subset of the specified permission.</summary><returns>true if the current permission is a subset of the specified permission; otherwise, false.</returns><param name="target">A permission that is to be tested for the subset relationship. This permission must be the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        public override bool IsSubsetOf(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsUnrestricted()
        {
             throw new NotImplementedException();
        }
        
        
        public override SecurityElement ToXml()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a permission that is the union of the current permission and the specified permission.</summary><returns>A new permission that represents the union of the current permission and the specified permission.</returns><param name="target">A permission to combine with the current permission. It must be of the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        public override IPermission Union(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
