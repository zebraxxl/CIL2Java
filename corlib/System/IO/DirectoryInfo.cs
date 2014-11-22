using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Collections.Generic;

namespace System.IO
{
    /// <summary>Exposes instance methods for creating, moving, and enumerating through directories and subdirectories. This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class DirectoryInfo : FileSystemInfo
    {
    
        /// <summary>Gets the name of this <see cref="T:System.IO.DirectoryInfo" /> instance.</summary><returns>The directory name.</returns><filterpriority>1</filterpriority>
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the parent directory of a specified subdirectory.</summary><returns>The parent directory, or null if the path is null or if the file path denotes a root (such as "\", "C:", or * "\\server\share").</returns><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public DirectoryInfo Parent
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the directory exists.</summary><returns>true if the directory exists; otherwise, false.</returns><filterpriority>1</filterpriority>
        public override bool Exists
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the root portion of a path.</summary><returns>A <see cref="T:System.IO.DirectoryInfo" /> object representing the root of a path.</returns><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public DirectoryInfo Root
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.IO.DirectoryInfo" /> class on the specified path.</summary><param name="path">A string specifying the path on which to create the DirectoryInfo. </param><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null. </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.ArgumentException"><paramref name="path" /> contains invalid characters such as ", &lt;, &gt;, or |. </exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. The specified path, file name, or both are too long.</exception>
        [SecuritySafeCriticalAttribute()]
        public DirectoryInfo(string path)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a subdirectory or subdirectories on the specified path. The specified path can be relative to this instance of the <see cref="T:System.IO.DirectoryInfo" /> class.</summary><returns>The last directory specified in <paramref name="path" />.</returns><param name="path">The specified path. This cannot be a different disk volume or Universal Naming Convention (UNC) name. </param><exception cref="T:System.ArgumentException"><paramref name="path" /> does not specify a valid file path or contains invalid DirectoryInfo characters. </exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception><exception cref="T:System.IO.IOException">The subdirectory cannot be created.-or- A file or directory already has the name specified by <paramref name="path" />. </exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. The specified path, file name, or both are too long.</exception><exception cref="T:System.Security.SecurityException">The caller does not have code access permission to create the directory.-or-The caller does not have code access permission to read the directory described by the returned <see cref="T:System.IO.DirectoryInfo" /> object.  This can occur when the <paramref name="path" /> parameter describes an existing directory.</exception><exception cref="T:System.NotSupportedException"><paramref name="path" /> contains a colon character (:) that is not part of a drive label ("C:\").</exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public DirectoryInfo CreateSubdirectory(string path)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a subdirectory or subdirectories on the specified path with the specified security. The specified path can be relative to this instance of the <see cref="T:System.IO.DirectoryInfo" /> class.</summary><returns>The last directory specified in <paramref name="path" />.</returns><param name="path">The specified path. This cannot be a different disk volume or Universal Naming Convention (UNC) name.</param><param name="directorySecurity">The security to apply.</param><exception cref="T:System.ArgumentException"><paramref name="path" /> does not specify a valid file path or contains invalid DirectoryInfo characters. </exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception><exception cref="T:System.IO.IOException">The subdirectory cannot be created.-or- A file or directory already has the name specified by <paramref name="path" />. </exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. The specified path, file name, or both are too long.</exception><exception cref="T:System.Security.SecurityException">The caller does not have code access permission to create the directory.-or-The caller does not have code access permission to read the directory described by the returned <see cref="T:System.IO.DirectoryInfo" /> object.  This can occur when the <paramref name="path" /> parameter describes an existing directory.</exception><exception cref="T:System.NotSupportedException"><paramref name="path" /> contains a colon character (:) that is not part of a drive label ("C:\").</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public DirectoryInfo CreateSubdirectory(string path, DirectorySecurity directorySecurity)
        {
             throw new NotImplementedException();
        }
        
        
        public void Create()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a directory using a <see cref="T:System.Security.AccessControl.DirectorySecurity" /> object.</summary><param name="directorySecurity">The access control to apply to the directory.</param><exception cref="T:System.IO.IOException">The directory specified by <paramref name="path" /> is read-only or is not empty. </exception><exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception><exception cref="T:System.ArgumentException"><paramref name="path" /> is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null. </exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive. </exception><exception cref="T:System.NotSupportedException">Creating a directory with only the colon (:) character was attempted. </exception><exception cref="T:System.IO.IOException">The directory specified by <paramref name="path" /> is read-only or is not empty. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public void Create(DirectorySecurity directorySecurity)
        {
             throw new NotImplementedException();
        }
        
        
        public DirectorySecurity GetAccessControl()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets a <see cref="T:System.Security.AccessControl.DirectorySecurity" /> object that encapsulates the specified type of access control list (ACL) entries for the directory described by the current <see cref="T:System.IO.DirectoryInfo" /> object.</summary><returns>A <see cref="T:System.Security.AccessControl.DirectorySecurity" /> object that encapsulates the access control rules for the file described by the <paramref name="path" /> parameter.ExceptionsException typeCondition<see cref="T:System.SystemException" />The directory could not be found or modified.<see cref="T:System.UnauthorizedAccessException" />The current process does not have access to open the directory.<see cref="T:System.IO.IOException" />An I/O error occurred while opening the directory.<see cref="T:System.PlatformNotSupportedException" />The current operating system is not Microsoft Windows 2000 or later.<see cref="T:System.UnauthorizedAccessException" />The directory is read-only.-or- This operation is not supported on the current platform.-or- The caller does not have the required permission.</returns><param name="includeSections">One of the <see cref="T:System.Security.AccessControl.AccessControlSections" /> values that specifies the type of access control list (ACL) information to receive.</param><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public DirectorySecurity GetAccessControl(AccessControlSections includeSections)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Applies access control list (ACL) entries described by a <see cref="T:System.Security.AccessControl.DirectorySecurity" /> object to the directory described by the current <see cref="T:System.IO.DirectoryInfo" /> object.</summary><param name="directorySecurity">An object that describes an ACL entry to apply to the directory described by the <paramref name="path" /> parameter.</param><exception cref="T:System.ArgumentNullException">The <paramref name="directorySecurity" /> parameter is null.</exception><exception cref="T:System.SystemException">The file could not be found or modified.</exception><exception cref="T:System.UnauthorizedAccessException">The current process does not have access to open the file.</exception><exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows 2000 or later.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public void SetAccessControl(DirectorySecurity directorySecurity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a file list from the current directory matching the given search pattern.</summary><returns>An array of type <see cref="T:System.IO.FileInfo" />.</returns><param name="searchPattern">The search string, such as "*.txt". </param><exception cref="T:System.ArgumentException"><paramref name="searchPattern " />contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method. </exception><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public FileInfo[] GetFiles(string searchPattern)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a file list from the current directory matching the given search pattern and using a value to determine whether to search subdirectories.</summary><returns>An array of type <see cref="T:System.IO.FileInfo" />.</returns><param name="searchPattern">The search string. For example, "System*" can be used to search for all directories that begin with the word "System".</param><param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories.</param><exception cref="T:System.ArgumentException"><paramref name="searchPattern " />contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method. </exception><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception><exception cref="T:System.IO.DirectoryNotFoundException">The path is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public FileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
        {
             throw new NotImplementedException();
        }
        
        
        public FileInfo[] GetFiles()
        {
             throw new NotImplementedException();
        }
        
        
        public DirectoryInfo[] GetDirectories()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of strongly typed <see cref="T:System.IO.FileSystemInfo" /> objects representing the files and subdirectories that match the specified search criteria.</summary><returns>An array of strongly typed FileSystemInfo objects matching the search criteria.</returns><param name="searchPattern">The search string. For example, "System*" can be used to search for all directories that begin with the word "System". </param><exception cref="T:System.ArgumentException"><paramref name="searchPattern " />contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method. </exception><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><filterpriority>2</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public FileSystemInfo[] GetFileSystemInfos(string searchPattern)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves an array of <see cref="T:System.IO.FileSystemInfo" /> objects that represent the files and subdirectories matching the specified search criteria.</summary><returns>An array of file system entries that match the search criteria.</returns><param name="searchPattern">The search string. The default pattern is "*", which returns all files and directories.</param><param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param><exception cref="T:System.ArgumentException"><paramref name="searchPattern " />contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method. </exception><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public FileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
             throw new NotImplementedException();
        }
        
        
        public FileSystemInfo[] GetFileSystemInfos()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an array of directories in the current <see cref="T:System.IO.DirectoryInfo" /> matching the given search criteria.</summary><returns>An array of type DirectoryInfo matching <paramref name="searchPattern" />.</returns><param name="searchPattern">The search string. For example, "System*" can be used to search for all directories that begin with the word "System". </param><exception cref="T:System.ArgumentException"><paramref name="searchPattern " />contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method. </exception><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the DirectoryInfo object is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public DirectoryInfo[] GetDirectories(string searchPattern)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an array of directories in the current <see cref="T:System.IO.DirectoryInfo" /> matching the given search criteria and using a value to determine whether to search subdirectories.</summary><returns>An array of type DirectoryInfo matching <paramref name="searchPattern" />.</returns><param name="searchPattern">The search string. For example, "System*" can be used to search for all directories that begin with the word "System".</param><param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories.</param><exception cref="T:System.ArgumentException"><paramref name="searchPattern " />contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method. </exception><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception><exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the DirectoryInfo object is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission. </exception>
        public DirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerable<DirectoryInfo> EnumerateDirectories()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an enumerable collection of directory information that matches a specified search pattern.</summary><returns>An enumerable collection of directories that matches <paramref name="searchPattern" />.</returns><param name="searchPattern">The search string. The default pattern is "*", which returns all directories. </param><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an enumerable collection of directory information that matches a specified search pattern and search subdirectory option. </summary><returns>An enumerable collection of directories that matches <paramref name="searchPattern" /> and <paramref name="searchOption" />.</returns><param name="searchPattern">The search string. The default pattern is "*", which returns all directories.</param><param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception><exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.DirectoryInfo" /> object is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerable<FileInfo> EnumerateFiles()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an enumerable collection of file information that matches a search pattern.</summary><returns>An enumerable collection of files that matches <paramref name="searchPattern" />.</returns><param name="searchPattern">The search string. The default pattern is "*", which returns all files.</param><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.FileInfo" /> object is invalid, (for example, it is on an unmapped drive). </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public IEnumerable<FileInfo> EnumerateFiles(string searchPattern)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an enumerable collection of file information that matches a specified search pattern and search subdirectory option.</summary><returns>An enumerable collection of files that matches <paramref name="searchPattern" /> and <paramref name="searchOption" />.</returns><param name="searchPattern">The search string. The default pattern is "*", which returns all files.</param><param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception><exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.FileInfo" /> object is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an enumerable collection of file system information that matches a specified search pattern.</summary><returns>An enumerable collection of file system information objects that matches <paramref name="searchPattern" />.</returns><param name="searchPattern">The search string. The default pattern is "*", which returns all files and directories.</param><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.FileSystemInfo" /> object is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns an enumerable collection of file system information that matches a specified search pattern and search subdirectory option.</summary><returns>An enumerable collection of file system information objects that matches <paramref name="searchPattern" /> and <paramref name="searchOption" />.</returns><param name="searchPattern">The search string. The default pattern is "*", which returns all files or directories.</param><param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="F:System.IO.SearchOption.TopDirectoryOnly" />.</param><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="searchOption" /> is not a valid <see cref="T:System.IO.SearchOption" /> value.</exception><exception cref="T:System.IO.DirectoryNotFoundException">The path encapsulated in the <see cref="T:System.IO.FileSystemInfo" /> object is invalid (for example, it is on an unmapped drive). </exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Moves a <see cref="T:System.IO.DirectoryInfo" /> instance and its contents to a new path.</summary><param name="destDirName">The name and path to which to move this directory. The destination cannot be another disk volume or a directory with the identical name. It can be an existing directory to which you want to add this directory as a subdirectory. </param><exception cref="T:System.ArgumentNullException"><paramref name="destDirName" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="destDirName" /> is an empty string (''"). </exception><exception cref="T:System.IO.IOException">An attempt was made to move a directory to a different volume. -or-<paramref name="destDirName" /> already exists.-or-You are not authorized to access this path.-or- The directory being moved and the destination directory have the same name.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The destination directory cannot be found.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void MoveTo(string destDirName)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override void Delete()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deletes this instance of a <see cref="T:System.IO.DirectoryInfo" />, specifying whether to delete subdirectories and files.</summary><param name="recursive">true to delete this directory, its subdirectories, and all files; otherwise, false. </param><exception cref="T:System.UnauthorizedAccessException">The directory contains a read-only file.</exception><exception cref="T:System.IO.DirectoryNotFoundException">The directory described by this <see cref="T:System.IO.DirectoryInfo" /> object does not exist or could not be found.</exception><exception cref="T:System.IO.IOException">The directory is read-only.-or- The directory contains one or more files or subdirectories and <paramref name="recursive" /> is false.-or-The directory is the application's current working directory. -or-There is an open handle on the directory or on one of its files, and the operating system is Windows XP or earlier. This open handle can result from enumerating directories and files. For more information, see How to: Enumerate Directories and Files.</exception><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void Delete(bool recursive)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
