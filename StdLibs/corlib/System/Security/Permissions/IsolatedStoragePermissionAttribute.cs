using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
    /// <summary>Allows security actions for <see cref="T:System.Security.Permissions.IsolatedStoragePermission" /> to be applied to code using declarative security.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    [ComVisibleAttribute(true)]
    public abstract class IsolatedStoragePermissionAttribute : CodeAccessSecurityAttribute
    {
    
        /// <summary>Gets or sets the maximum user storage quota size.</summary><returns>The maximum user storage quota size in bytes.</returns>
        public long UserQuota
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the level of isolated storage that should be declared.</summary><returns>One of the <see cref="T:System.Security.Permissions.IsolatedStorageContainment" /> values.</returns>
        public IsolatedStorageContainment UsageAllowed
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.IsolatedStoragePermissionAttribute" /> class with the specified <see cref="T:System.Security.Permissions.SecurityAction" />.</summary><param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param>
        protected IsolatedStoragePermissionAttribute(SecurityAction action)
            : base(action)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
