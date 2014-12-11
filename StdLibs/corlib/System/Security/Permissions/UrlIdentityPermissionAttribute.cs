using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Allows security actions for <see cref="T:System.Security.Permissions.UrlIdentityPermission" /> to be applied to code using declarative security. This class cannot be inherited.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class UrlIdentityPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        /// <summary>Gets or sets the full URL of the calling code.</summary><returns>The URL to match with the URL specified by the host.</returns>
        public string Url
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.UrlIdentityPermissionAttribute" /> class with the specified <see cref="T:System.Security.Permissions.SecurityAction" />.</summary><param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param>
        public UrlIdentityPermissionAttribute(SecurityAction action)
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
