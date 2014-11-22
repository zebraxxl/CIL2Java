using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Specifies the base attribute class for declarative security from which <see cref="T:System.Security.Permissions.CodeAccessSecurityAttribute" /> is derived.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    [ComVisibleAttribute(true)]
    public abstract class SecurityAttribute : Attribute
    {
    
        /// <summary>Gets or sets a security action.</summary><returns>One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values.</returns>
        public SecurityAction Action
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether full (unrestricted) permission to the resource protected by the attribute is declared.</summary><returns>true if full permission to the protected resource is declared; otherwise, false.</returns>
        public bool Unrestricted
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of <see cref="T:System.Security.Permissions.SecurityAttribute" /> with the specified <see cref="T:System.Security.Permissions.SecurityAction" />.</summary><param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param>
        protected SecurityAttribute(SecurityAction action)
        {
             throw new NotImplementedException();
        }
        
        
        public abstract IPermission CreatePermission();
        
        
    }
}
