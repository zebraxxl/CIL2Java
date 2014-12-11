using System.Security;

namespace System.Security.AccessControl
{
    /// <summary>Represents the access control and audit security for a directory. This class cannot be inherited.</summary>
    public sealed class DirectorySecurity : FileSystemSecurity
    {
        [SecuritySafeCriticalAttribute()]
        public DirectorySecurity()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.DirectorySecurity" /> class from a specified directory using the specified values of the <see cref="T:System.Security.AccessControl.AccessControlSections" /> enumeration.</summary><param name="name">The location of a directory to create a <see cref="T:System.Security.AccessControl.DirectorySecurity" /> object from.</param><param name="includeSections">One of the <see cref="T:System.Security.AccessControl.AccessControlSections" /> values that specifies the type of access control list (ACL) information to retrieve. </param><exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is a zero-length string, contains only white space, or contains one or more invalid characters as defined by <see cref="F:System.IO.Path.InvalidPathChars" />. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null.</exception><exception cref="T:System.IO.DirectoryNotFoundException">The specified path is invalid, (for example, it is on an unmapped drive). </exception><exception cref="T:System.IO.FileNotFoundException">The file specified in the <paramref name="name" /> parameter was not found. </exception><exception cref="T:System.IO.IOException">An I/O error occurred while opening the directory.</exception><exception cref="T:System.NotSupportedException">The <paramref name="name" /> parameter is in an invalid format. </exception><exception cref="T:System.PlatformNotSupportedException">The current operating system is not Microsoft Windows 2000 or later.</exception><exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception><exception cref="T:System.Security.AccessControl.PrivilegeNotHeldException">The current system account does not have administrative privileges.</exception><exception cref="T:System.SystemException">The directory could not be found.</exception><exception cref="T:System.UnauthorizedAccessException">The <paramref name="name" /> parameter specified a directory that is read-only.-or- This operation is not supported on the current platform.-or- The caller does not have the required permission.</exception>
        [SecuritySafeCriticalAttribute()]
        public DirectorySecurity(string name, AccessControlSections includeSections)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
