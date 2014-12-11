using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Allows security actions for <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" /> to be applied to code using declarative security. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class StrongNameIdentityPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        /// <summary>Gets or sets the name of the strong name identity.</summary><returns>A name to compare against the name specified by the security provider.</returns>
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the version of the strong name identity.</summary><returns>The version number of the strong name identity.</returns>
        public string Version
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the public key value of the strong name identity expressed as a hexadecimal string.</summary><returns>The public key value of the strong name identity expressed as a hexadecimal string.</returns>
        public string PublicKey
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.StrongNameIdentityPermissionAttribute" /> class with the specified <see cref="T:System.Security.Permissions.SecurityAction" />.</summary><param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param>
        public StrongNameIdentityPermissionAttribute(SecurityAction action)
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
