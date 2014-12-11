using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Controls the permissions related to user interfaces and the Clipboard. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class UIPermission : CodeAccessPermission, IUnrestrictedPermission
    {
    
        /// <summary>Gets or sets the window access represented by the permission.</summary><returns>One of the <see cref="T:System.Security.Permissions.UIPermissionWindow" /> values.</returns>
        public UIPermissionWindow Window
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the Clipboard access represented by the permission.</summary><returns>One of the <see cref="T:System.Security.Permissions.UIPermissionClipboard" /> values.</returns>
        public UIPermissionClipboard Clipboard
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.UIPermission" /> class with either fully restricted or unrestricted access, as specified.</summary><param name="state">One of the enumeration values. </param><exception cref="T:System.ArgumentException">The <paramref name="state" /> parameter is not a valid <see cref="T:System.Security.Permissions.PermissionState" />. </exception>
        public UIPermission(PermissionState state)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.UIPermission" /> class with the specified permissions for windows and the Clipboard.</summary><param name="windowFlag">One of the enumeration values. </param><param name="clipboardFlag">One of the enumeration values. </param><exception cref="T:System.ArgumentException">The <paramref name="windowFlag" /> parameter is not a valid <see cref="T:System.Security.Permissions.UIPermissionWindow" /> value.-or- The <paramref name="clipboardFlag" /> parameter is not a valid <see cref="T:System.Security.Permissions.UIPermissionClipboard" /> value. </exception>
        public UIPermission(UIPermissionWindow windowFlag, UIPermissionClipboard clipboardFlag)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.UIPermission" /> class with the permissions for windows, and no access to the Clipboard.</summary><param name="windowFlag">One of the enumeration values. </param><exception cref="T:System.ArgumentException">The <paramref name="windowFlag" /> parameter is not a valid <see cref="T:System.Security.Permissions.UIPermissionWindow" /> value. </exception>
        public UIPermission(UIPermissionWindow windowFlag)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.UIPermission" /> class with the permissions for the Clipboard, and no access to windows.</summary><param name="clipboardFlag">One of the enumeration values. </param><exception cref="T:System.ArgumentException">The <paramref name="clipboardFlag" /> parameter is not a valid <see cref="T:System.Security.Permissions.UIPermissionClipboard" /> value. </exception>
        public UIPermission(UIPermissionClipboard clipboardFlag)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsUnrestricted()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the current permission is a subset of the specified permission.</summary><returns>true if the current permission is a subset of the specified permission; otherwise, false.</returns><param name="target">A permission to test for the subset relationship. This permission must be the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        public override bool IsSubsetOf(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates and returns a permission that is the intersection of the current permission and the specified permission.</summary><returns>A new permission that represents the intersection of the current permission and the specified permission. This new permission is null if the intersection is empty.</returns><param name="target">A permission to intersect with the current permission. It must be the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        public override IPermission Intersect(IPermission target)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a permission that is the union of the permission and the specified permission.</summary><returns>A new permission that represents the union of the current permission and the specified permission.</returns><param name="target">A permission to combine with the current permission. It must be the same type as the current permission. </param><exception cref="T:System.ArgumentException">The <paramref name="target" /> parameter is not null and is not of the same type as the current permission. </exception>
        public override IPermission Union(IPermission target)
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
        
        
        /// <summary>Reconstructs a permission with a specified state from an XML encoding.</summary><param name="esd">The XML encoding used to reconstruct the permission. </param><exception cref="T:System.ArgumentNullException">The <paramref name="esd" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="esd" /> parameter is not a valid permission element.-or- The <paramref name="esd" /> parameter's version number is not valid. </exception>
        public override void FromXml(SecurityElement esd)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
