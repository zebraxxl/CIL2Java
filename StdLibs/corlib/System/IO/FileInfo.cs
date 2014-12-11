using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;

namespace System.IO
{
    /// <summary>Provides properties and instance methods for the creation, copying, deletion, moving, and opening of files, and aids in the creation of <see cref="T:System.IO.FileStream" /> objects. This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class FileInfo : FileSystemInfo
    {
    
        /// <summary>Gets the name of the file.</summary><returns>The name of the file.</returns><filterpriority>1</filterpriority>
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the size, in bytes, of the current file.</summary><returns>The size of the current file in bytes.</returns><exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh" /> cannot update the state of the file or directory. </exception><exception cref="T:System.IO.FileNotFoundException">The file does not exist.-or- The Length property is called for a directory. </exception><filterpriority>1</filterpriority>
        public long Length
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a string representing the directory's full path.</summary><returns>A string representing the directory's full path.</returns><exception cref="T:System.ArgumentNullException">null was passed in for the directory name. </exception><exception cref="T:System.IO.PathTooLongException">The fully qualified path is 260 or more characters.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public string DirectoryName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an instance of the parent directory.</summary><returns>A <see cref="T:System.IO.DirectoryInfo" /> object representing the parent directory of this file.</returns><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public DirectoryInfo Directory
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value that determines if the current file is read only.</summary><returns>true if the current file is read only; otherwise, false.</returns><exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="T:System.IO.FileInfo" /> object could not be found.</exception><exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception><exception cref="T:System.UnauthorizedAccessException">This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception><exception cref="T:System.ArgumentException">The user does not have write permission, but attempted to set this property to false.</exception><filterpriority>1</filterpriority>
        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether a file exists.</summary><returns>true if the file exists; false if the file does not exist or if the file is a directory.</returns><filterpriority>1</filterpriority>
        public override bool Exists
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.FileInfo" /> class, which acts as a wrapper for a file path.</summary><param name="fileName">The fully qualified name of the new file, or the relative file name. Do not end the path with the directory separator character.</param><exception cref="T:System.ArgumentNullException"><paramref name="fileName" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.ArgumentException">The file name is empty, contains only white spaces, or contains invalid characters. </exception><exception cref="T:System.UnauthorizedAccessException">Access to <paramref name="fileName" /> is denied. </exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception><exception cref="T:System.NotSupportedException"><paramref name="fileName" /> contains a colon (:) in the middle of the string. </exception>
        [SecuritySafeCriticalAttribute()]
        public FileInfo(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public FileSecurity GetAccessControl()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a <see cref="T:System.Security.AccessControl.FileSecurity" /> object that encapsulates the specified type of access control list (ACL) entries for the file described by the current <see cref="T:System.IO.FileInfo" /> object.</summary><returns>A <see cref="T:System.Security.AccessControl.FileSecurity" /> object that encapsulates the access control rules for the current file.     </returns><param name="includeSections">One of the <see cref="T:System.Security.AccessControl.AccessControlSections" /> values that specifies which group of access control entries to retrieve. </param><exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception><exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows 2000 or later.</exception><exception cref="T:System.Security.AccessControl.PrivilegeNotHeldException">The current system account does not have administrative privileges.</exception><exception cref="T:System.SystemException">The file could not be found.</exception><exception cref="T:System.UnauthorizedAccessException">This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public FileSecurity GetAccessControl(AccessControlSections includeSections)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Applies access control list (ACL) entries described by a <see cref="T:System.Security.AccessControl.FileSecurity" /> object to the file described by the current <see cref="T:System.IO.FileInfo" /> object.</summary><param name="fileSecurity">A <see cref="T:System.Security.AccessControl.FileSecurity" /> object that describes an access control list (ACL) entry to apply to the current file.</param><exception cref="T:System.ArgumentNullException">The <paramref name="fileSecurity" /> parameter is null.</exception><exception cref="T:System.SystemException">The file could not be found or modified.</exception><exception cref="T:System.UnauthorizedAccessException">The current process does not have access to open the file.</exception><exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows 2000 or later.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public void SetAccessControl(FileSecurity fileSecurity)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public StreamReader OpenText()
        {
             throw new NotImplementedException();
        }
        
        
        public StreamWriter CreateText()
        {
             throw new NotImplementedException();
        }
        
        
        public StreamWriter AppendText()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies an existing file to a new file, disallowing the overwriting of an existing file.</summary><returns>A new file with a fully qualified path.</returns><param name="destFileName">The name of the new file to copy to. </param><exception cref="T:System.ArgumentException"><paramref name="destFileName" /> is empty, contains only white spaces, or contains invalid characters. </exception><exception cref="T:System.IO.IOException">An error occurs, or the destination file already exists. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.ArgumentNullException"><paramref name="destFileName" /> is null. </exception><exception cref="T:System.UnauthorizedAccessException">A directory path is passed in, or the file is being moved to a different drive. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The directory specified in <paramref name="destFileName" /> does not exist.</exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception><exception cref="T:System.NotSupportedException"><paramref name="destFileName" /> contains a colon (:) within the string but does not specify the volume. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public FileInfo CopyTo(string destFileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies an existing file to a new file, allowing the overwriting of an existing file.</summary><returns>A new file, or an overwrite of an existing file if <paramref name="overwrite" /> is true. If the file exists and <paramref name="overwrite" /> is false, an <see cref="T:System.IO.IOException" /> is thrown.</returns><param name="destFileName">The name of the new file to copy to. </param><param name="overwrite">true to allow an existing file to be overwritten; otherwise, false. </param><exception cref="T:System.ArgumentException"><paramref name="destFileName" /> is empty, contains only white spaces, or contains invalid characters. </exception><exception cref="T:System.IO.IOException">An error occurs, or the destination file already exists and <paramref name="overwrite" /> is false. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.ArgumentNullException"><paramref name="destFileName" /> is null. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The directory specified in <paramref name="destFileName" /> does not exist.</exception><exception cref="T:System.UnauthorizedAccessException">A directory path is passed in, or the file is being moved to a different drive. </exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception><exception cref="T:System.NotSupportedException"><paramref name="destFileName" /> contains a colon (:) in the middle of the string. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public FileInfo CopyTo(string destFileName, bool overwrite)
        {
             throw new NotImplementedException();
        }
        
        
        public FileStream Create()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override void Delete()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void Decrypt()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void Encrypt()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Opens a file in the specified mode.</summary><returns>A file opened in the specified mode, with read/write access and unshared.</returns><param name="mode">A <see cref="T:System.IO.FileMode" /> constant specifying the mode (for example, Open or Append) in which to open the file. </param><exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception><exception cref="T:System.UnauthorizedAccessException">The file is read-only or is a directory. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception><exception cref="T:System.IO.IOException">The file is already open. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public FileStream Open(FileMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Opens a file in the specified mode with read, write, or read/write access.</summary><returns>A <see cref="T:System.IO.FileStream" /> object opened in the specified mode and access, and unshared.</returns><param name="mode">A <see cref="T:System.IO.FileMode" /> constant specifying the mode (for example, Open or Append) in which to open the file. </param><param name="access">A <see cref="T:System.IO.FileAccess" /> constant specifying whether to open the file with Read, Write, or ReadWrite file access. </param><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.ArgumentException"><paramref name="path" /> is empty or contains only white spaces. </exception><exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception><exception cref="T:System.ArgumentNullException">One or more arguments is null. </exception><exception cref="T:System.UnauthorizedAccessException"><paramref name="path" /> is read-only or is a directory. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception><exception cref="T:System.IO.IOException">The file is already open. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public FileStream Open(FileMode mode, FileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Opens a file in the specified mode with read, write, or read/write access and the specified sharing option.</summary><returns>A <see cref="T:System.IO.FileStream" /> object opened with the specified mode, access, and sharing options.</returns><param name="mode">A <see cref="T:System.IO.FileMode" /> constant specifying the mode (for example, Open or Append) in which to open the file. </param><param name="access">A <see cref="T:System.IO.FileAccess" /> constant specifying whether to open the file with Read, Write, or ReadWrite file access. </param><param name="share">A <see cref="T:System.IO.FileShare" /> constant specifying the type of access other FileStream objects have to this file. </param><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.ArgumentException"><paramref name="path" /> is empty or contains only white spaces. </exception><exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception><exception cref="T:System.ArgumentNullException">One or more arguments is null. </exception><exception cref="T:System.UnauthorizedAccessException"><paramref name="path" /> is read-only or is a directory. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception><exception cref="T:System.IO.IOException">The file is already open. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public FileStream Open(FileMode mode, FileAccess access, FileShare share)
        {
             throw new NotImplementedException();
        }
        
        
        public FileStream OpenRead()
        {
             throw new NotImplementedException();
        }
        
        
        public FileStream OpenWrite()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Moves a specified file to a new location, providing the option to specify a new file name.</summary><param name="destFileName">The path to move the file to, which can specify a different file name. </param><exception cref="T:System.IO.IOException">An I/O error occurs, such as the destination file already exists or the destination device is not ready. </exception><exception cref="T:System.ArgumentNullException"><paramref name="destFileName" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="destFileName" /> is empty, contains only white spaces, or contains invalid characters. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.UnauthorizedAccessException"><paramref name="destFileName" /> is read-only or is a directory. </exception><exception cref="T:System.IO.FileNotFoundException">The file is not found. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception><exception cref="T:System.NotSupportedException"><paramref name="destFileName" /> contains a colon (:) in the middle of the string. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void MoveTo(string destFileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Replaces the contents of a specified file with the file described by the current <see cref="T:System.IO.FileInfo" /> object, deleting the original file, and creating a backup of the replaced file.</summary><returns>A <see cref="T:System.IO.FileInfo" /> object that encapsulates information about the file described by the <paramref name="destFileName" /> parameter.</returns><param name="destinationFileName">The name of a file to replace with the current file.</param><param name="destinationBackupFileName">The name of a file with which to create a backup of the file described by the <paramref name="destFileName" /> parameter.</param><exception cref="T:System.ArgumentException">The path described by the <paramref name="destFileName" /> parameter was not of a legal form.-or-The path described by the <paramref name="destBackupFileName" /> parameter was not of a legal form.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="destFileName" /> parameter is null.</exception><exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="T:System.IO.FileInfo" /> object could not be found.-or-The file described by the <paramref name="destinationFileName" /> parameter could not be found. </exception><exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [ComVisibleAttribute(false)]
        public FileInfo Replace(string destinationFileName, string destinationBackupFileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Replaces the contents of a specified file with the file described by the current <see cref="T:System.IO.FileInfo" /> object, deleting the original file, and creating a backup of the replaced file.  Also specifies whether to ignore merge errors. </summary><returns>A <see cref="T:System.IO.FileInfo" /> object that encapsulates information about the file described by the <paramref name="destFileName" /> parameter.</returns><param name="destinationFileName">The name of a file to replace with the current file.</param><param name="destinationBackupFileName">The name of a file with which to create a backup of the file described by the <paramref name="destFileName" /> parameter.</param><param name="ignoreMetadataErrors">true to ignore merge errors (such as attributes and ACLs) from the replaced file to the replacement file; otherwise false. </param><exception cref="T:System.ArgumentException">The path described by the <paramref name="destFileName" /> parameter was not of a legal form.-or-The path described by the <paramref name="destBackupFileName" /> parameter was not of a legal form.</exception><exception cref="T:System.ArgumentNullException">The <paramref name="destFileName" /> parameter is null.</exception><exception cref="T:System.IO.FileNotFoundException">The file described by the current <see cref="T:System.IO.FileInfo" /> object could not be found.-or-The file described by the <paramref name="destinationFileName" /> parameter could not be found. </exception><exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows NT or later.</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [ComVisibleAttribute(false)]
        public FileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
