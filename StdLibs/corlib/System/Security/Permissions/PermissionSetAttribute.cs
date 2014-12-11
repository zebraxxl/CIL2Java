using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Allows security actions for a <see cref="T:System.Security.PermissionSet" /> to be applied to code using declarative security. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class PermissionSetAttribute : CodeAccessSecurityAttribute
    {
    
        /// <summary>Gets or sets a file containing the XML representation of a custom permission set to be declared.</summary><returns>The physical path to the file containing the XML representation of the permission set.</returns>
        public string File
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the file specified by <see cref="P:System.Security.Permissions.PermissionSetAttribute.File" /> is Unicode or ASCII encoded.</summary><returns>true if the file is Unicode encoded; otherwise, false.</returns>
        public bool UnicodeEncoded
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name of the permission set.</summary><returns>The name of an immutable <see cref="T:System.Security.NamedPermissionSet" /> (one of several permission sets that are contained in the default policy and cannot be altered).</returns>
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the XML representation of a permission set.</summary><returns>The XML representation of a permission set.</returns>
        public string XML
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the hexadecimal representation of the XML encoded permission set.</summary><returns>The hexadecimal representation of the XML encoded permission set.</returns>
        public string Hex
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.PermissionSetAttribute" /> class with the specified security action.</summary><param name="action">One of the enumeration values that specifies a security action. </param>
        public PermissionSetAttribute(SecurityAction action)
            : base(action)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission CreatePermission()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public PermissionSet CreatePermissionSet()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
