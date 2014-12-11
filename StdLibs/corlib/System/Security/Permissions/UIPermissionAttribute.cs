using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Allows security actions for <see cref="T:System.Security.Permissions.UIPermission" /> to be applied to code using declarative security. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class UIPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        /// <summary>Gets or sets the type of access to the window resources that is permitted.</summary><returns>One of the <see cref="T:System.Security.Permissions.UIPermissionWindow" /> values.</returns>
        public UIPermissionWindow Window
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the type of access to the clipboard that is permitted.</summary><returns>One of the <see cref="T:System.Security.Permissions.UIPermissionClipboard" /> values.</returns>
        public UIPermissionClipboard Clipboard
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.UIPermissionAttribute" /> class with the specified <see cref="T:System.Security.Permissions.SecurityAction" />.</summary><param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param>
        public UIPermissionAttribute(SecurityAction action)
            : base(action)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission CreatePermission()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
