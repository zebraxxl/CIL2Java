using System;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Allows security actions for <see cref="T:System.Security.Permissions.RegistryPermission" /> to be applied to code using declarative security. This class cannot be inherited.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class RegistryPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        /// <summary>Gets or sets read access for the specified registry keys.</summary><returns>A semicolon-separated list of registry key paths, for read access. </returns>
        public string Read
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets write access for the specified registry keys.</summary><returns>A semicolon-separated list of registry key paths, for write access. </returns>
        public string Write
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets create-level access for the specified registry keys. </summary><returns>A semicolon-separated list of registry key paths, for create-level access. </returns>
        public string Create
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets view access control for the specified registry keys.</summary><returns>A semicolon-separated list of registry key paths, for view access control.</returns>
        public string ViewAccessControl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets change access control for the specified registry keys.</summary><returns>A semicolon-separated list of registry key paths, for change access control. .</returns>
        public string ChangeAccessControl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a specified set of registry keys that can be viewed and modified.</summary><returns>A semicolon-separated list of registry key paths, for create, read, and write access. </returns><exception cref="T:System.NotSupportedException">The get accessor is called; it is only provided for C# compiler compatibility. </exception>
        public string ViewAndModify
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets full access for the specified registry keys.</summary><returns>A semicolon-separated list of registry key paths, for full access. </returns><exception cref="T:System.NotSupportedException">The get accessor is called; it is only provided for C# compiler compatibility.</exception>
        [ObsoleteAttribute("Please use the ViewAndModify property instead.")]
        public string All
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.RegistryPermissionAttribute" /> class with the specified <see cref="T:System.Security.Permissions.SecurityAction" />.</summary><param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param><exception cref="T:System.ArgumentException">The <paramref name="action" /> parameter is not a valid <see cref="T:System.Security.Permissions.SecurityAction" />. </exception>
        public RegistryPermissionAttribute(SecurityAction action)
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
