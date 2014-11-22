using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Security.Permissions
{
    /// <summary>Allows security actions for <see cref="T:System.Security.Permissions.FileIOPermission" /> to be applied to code using declarative security. This class cannot be inherited.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class FileIOPermissionAttribute : CodeAccessSecurityAttribute
    {
    
        /// <summary>Gets or sets read access for the file or directory specified by the string value.</summary><returns>The absolute path of the file or directory for read access.</returns>
        public string Read
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets write access for the file or directory specified by the string value.</summary><returns>The absolute path of the file or directory for write access.</returns>
        public string Write
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets append access for the file or directory that is specified by the string value.</summary><returns>The absolute path of the file or directory for append access.</returns>
        public string Append
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the file or directory to which to grant path discovery.</summary><returns>The absolute path of the file or directory.</returns>
        public string PathDiscovery
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the file or directory in which access control information can be viewed.</summary><returns>The absolute path of the file or directory in which access control information can be viewed.</returns>
        public string ViewAccessControl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the file or directory in which access control information can be changed.</summary><returns>The absolute path of the file or directory in which access control information can be changed.</returns>
        public string ChangeAccessControl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets full access for the file or directory that is specified by the string value.</summary><returns>The absolute path of the file or directory for full access.</returns><exception cref="T:System.NotSupportedException">The get method is not supported for this property.</exception>
        [ObsoleteAttribute("Please use the ViewAndModify property instead.")]
        public string All
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the file or directory in which file data can be viewed and modified.</summary><returns>The absolute path of the file or directory in which file data can be viewed and modified.</returns><exception cref="T:System.NotSupportedException">The get accessor is called. The accessor is provided only for C# compiler compatibility.</exception>
        public string ViewAndModify
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the permitted access to all files.</summary><returns>A bitwise combination of the <see cref="T:System.Security.Permissions.FileIOPermissionAccess" /> values that represents the permissions for all files. The default is <see cref="F:System.Security.Permissions.FileIOPermissionAccess.NoAccess" />.</returns>
        public FileIOPermissionAccess AllFiles
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the permitted access to all local files.</summary><returns>A bitwise combination of the <see cref="T:System.Security.Permissions.FileIOPermissionAccess" /> values that represents the permissions for all local files. The default is <see cref="F:System.Security.Permissions.FileIOPermissionAccess.NoAccess" />.</returns>
        public FileIOPermissionAccess AllLocalFiles
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.FileIOPermissionAttribute" /> class with the specified <see cref="T:System.Security.Permissions.SecurityAction" />.</summary><param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values. </param><exception cref="T:System.ArgumentException">The <paramref name="action" /> parameter is not a valid <see cref="T:System.Security.Permissions.SecurityAction" />. </exception>
        public FileIOPermissionAttribute(SecurityAction action)
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
