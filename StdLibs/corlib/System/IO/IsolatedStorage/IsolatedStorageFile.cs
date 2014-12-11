using System.Runtime.InteropServices;
using System;
using System.Security;
using System.Security.Policy;
using System.IO;
using System.Collections;
using System.Security.Permissions;

namespace System.IO.IsolatedStorage
{
    /// <summary>Represents an isolated storage area containing files and directories.</summary>
    [ComVisibleAttribute(true)]
    public sealed class IsolatedStorageFile : IsolatedStorage, IDisposable
    {
    
        /// <summary>Gets a value that represents the amount of the space used for isolated storage.</summary><returns>The used isolated storage space, in bytes.</returns><exception cref="T:System.InvalidOperationException">The isolated store has been closed.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception>
        public override long UsedSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the current size of the isolated storage.</summary><returns>The total number of bytes of storage currently in use within the isolated storage scope.</returns><exception cref="T:System.InvalidOperationException">The property is unavailable. The current store has a roaming scope or is not open. </exception><exception cref="T:System.ObjectDisposedException">The current object size is undefined.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ObsoleteAttribute("IsolatedStorageFile.CurrentSize has been deprecated because it is not CLS Compliant.  To get the current size use IsolatedStorageFile.UsedSize")]
        public override ulong CurrentSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that represents the amount of free space available for isolated storage.</summary><returns>The available free space for isolated storage, in bytes.</returns><exception cref="T:System.InvalidOperationException">The isolated store is closed.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed. -or-Isolated storage is disabled.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception>
        [ComVisibleAttribute(false)]
        public override long AvailableFreeSpace
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that represents the maximum amount of space available for isolated storage.</summary><returns>The limit of isolated storage space, in bytes.</returns><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed. -or-Isolated storage is disabled.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception>
        [ComVisibleAttribute(false)]
        public override long Quota
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that indicates whether isolated storage is enabled.</summary><returns>true in all cases.</returns>
        [ComVisibleAttribute(false)]
        public static bool IsEnabled
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value representing the maximum amount of space available for isolated storage within the limits established by the quota.</summary><returns>The limit of isolated storage space in bytes.</returns><exception cref="T:System.InvalidOperationException">The property is unavailable. <see cref="P:System.IO.IsolatedStorage.IsolatedStorageFile.MaximumSize" /> cannot be determined without evidence from the assembly's creation. The evidence could not be determined when the object was created. </exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">An isolated storage error occurred.</exception>
        [ObsoleteAttribute("IsolatedStorageFile.MaximumSize has been deprecated because it is not CLS Compliant.  To get the maximum size use IsolatedStorageFile.Quota")]
        public override ulong MaximumSize
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static IsolatedStorageFile GetUserStoreForDomain()
        {
             throw new NotImplementedException();
        }
        
        
        public static IsolatedStorageFile GetUserStoreForAssembly()
        {
             throw new NotImplementedException();
        }
        
        
        public static IsolatedStorageFile GetUserStoreForApplication()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public static IsolatedStorageFile GetUserStoreForSite()
        {
             throw new NotImplementedException();
        }
        
        
        public static IsolatedStorageFile GetMachineStoreForDomain()
        {
             throw new NotImplementedException();
        }
        
        
        public static IsolatedStorageFile GetMachineStoreForAssembly()
        {
             throw new NotImplementedException();
        }
        
        
        public static IsolatedStorageFile GetMachineStoreForApplication()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Obtains isolated storage corresponding to the isolated storage scope given the application domain and assembly evidence types.</summary><returns>An object that represents the parameters.</returns><param name="scope">A bitwise combination of the enumeration values. </param><param name="domainEvidenceType">The type of the <see cref="T:System.Security.Policy.Evidence" /> that you can chose from the list of <see cref="T:System.Security.Policy.Evidence" /> present in the domain of the calling application. null lets the <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> object choose the evidence. </param><param name="assemblyEvidenceType">The type of the <see cref="T:System.Security.Policy.Evidence" /> that you can chose from the list of <see cref="T:System.Security.Policy.Evidence" /> present in the domain of the calling application. null lets the <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> object choose the evidence. </param><exception cref="T:System.Security.SecurityException">Sufficient isolated storage permissions have not been granted. </exception><exception cref="T:System.ArgumentException">The <paramref name="scope" /> is invalid. </exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The evidence type provided is missing in the assembly evidence list. -or-An isolated storage location cannot be initialized.-or-<paramref name="scope" /> contains the enumeration value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Application" />, but the application identity of the caller cannot be determined, because the <see cref="P:System.AppDomain.ActivationContext" /> for  the current application domain returned null.-or-<paramref name="scope" /> contains the value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Domain" />, but the permissions for the application domain cannot be determined.-or-<paramref name="scope" /> contains <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Assembly" />, but the permissions for the calling assembly cannot be determined.</exception><PermissionSet><IPermission class="System.Security.Permissions.IsolatedStorageFilePermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, Type domainEvidenceType, Type assemblyEvidenceType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Obtains the isolated storage corresponding to the given application domain and assembly evidence objects.</summary><returns>An object that represents the parameters.</returns><param name="scope">A bitwise combination of the enumeration values. </param><param name="domainIdentity">An object that contains evidence for the application domain identity. </param><param name="assemblyIdentity">An object that contains evidence for the code assembly identity. </param><exception cref="T:System.Security.SecurityException">Sufficient isolated storage permissions have not been granted. </exception><exception cref="T:System.ArgumentNullException">Neither <paramref name="domainIdentity" /> nor <paramref name="assemblyIdentity" /> has been passed in. This verifies that the correct constructor is being used.-or- Either <paramref name="domainIdentity" /> or <paramref name="assemblyIdentity" /> is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="scope" /> is invalid. </exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">An isolated storage location cannot be initialized. -or-<paramref name="scope" /> contains the enumeration value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Application" />, but the application identity of the caller cannot be determined, because the <see cref="P:System.AppDomain.ActivationContext" /> for  the current application domain returned null.-or-<paramref name="scope" /> contains the value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Domain" />, but the permissions for the application domain cannot be determined.-or-<paramref name="scope" /> contains the value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Assembly" />, but the permissions for the calling assembly cannot be determined.</exception><PermissionSet><IPermission class="System.Security.Permissions.IsolatedStorageFilePermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, object domainIdentity, object assemblyIdentity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Obtains isolated storage corresponding to the given application domain and the assembly evidence objects and types.</summary><returns>An object that represents the parameters.</returns><param name="scope">A bitwise combination of the enumeration values. </param><param name="domainEvidence">An object that contains the application domain identity. </param><param name="domainEvidenceType">The identity type to choose from the application domain evidence. </param><param name="assemblyEvidence">An object that contains the code assembly identity. </param><param name="assemblyEvidenceType">The identity type to choose from the application code assembly evidence. </param><exception cref="T:System.Security.SecurityException">Sufficient isolated storage permissions have not been granted. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="domainEvidence" /> or <paramref name="assemblyEvidence" /> identity has not been passed in. </exception><exception cref="T:System.ArgumentException">The <paramref name="scope" /> is invalid. </exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">An isolated storage location cannot be initialized. -or-<paramref name="scope" /> contains the enumeration value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Application" />, but the application identity of the caller cannot be determined, because the <see cref="P:System.AppDomain.ActivationContext" /> for  the current application domain returned null.-or-<paramref name="scope" /> contains the value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Domain" />, but the permissions for the application domain cannot be determined.-or-<paramref name="scope" /> contains the value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Assembly" />, but the permissions for the calling assembly cannot be determined.</exception><PermissionSet><IPermission class="System.Security.Permissions.IsolatedStorageFilePermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, Evidence domainEvidence, Type domainEvidenceType, Evidence assemblyEvidence, Type assemblyEvidenceType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Obtains isolated storage corresponding to the isolation scope and the application identity object.</summary><returns>An object that represents the parameters.</returns><param name="scope">A bitwise combination of the enumeration values. </param><param name="applicationEvidenceType">An object that contains the application identity. </param><exception cref="T:System.Security.SecurityException">Sufficient isolated storage permissions have not been granted. </exception><exception cref="T:System.ArgumentNullException">The   <paramref name="applicationEvidence" />  identity has not been passed in. </exception><exception cref="T:System.ArgumentException">The <paramref name="scope" /> is invalid. </exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">An isolated storage location cannot be initialized. -or-<paramref name="scope" /> contains the enumeration value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Application" />, but the application identity of the caller cannot be determined, because the <see cref="P:System.AppDomain.ActivationContext" /> for  the current application domain returned null.-or-<paramref name="scope" /> contains the value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Domain" />, but the permissions for the application domain cannot be determined.-or-<paramref name="scope" /> contains the value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Assembly" />, but the permissions for the calling assembly cannot be determined.</exception><PermissionSet><IPermission class="System.Security.Permissions.IsolatedStorageFilePermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, Type applicationEvidenceType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Obtains isolated storage corresponding to the given application identity.</summary><returns>An object that represents the parameters.</returns><param name="scope">A bitwise combination of the enumeration values. </param><param name="applicationIdentity">An object that contains evidence for the application identity. </param><exception cref="T:System.Security.SecurityException">Sufficient isolated storage permissions have not been granted. </exception><exception cref="T:System.ArgumentNullException">The  <paramref name="applicationIdentity" /> identity has not been passed in. </exception><exception cref="T:System.ArgumentException">The <paramref name="scope" /> is invalid. </exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">An isolated storage location cannot be initialized. -or-<paramref name="scope" /> contains the enumeration value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Application" />, but the application identity of the caller cannot be determined,because the <see cref="P:System.AppDomain.ActivationContext" /> for  the current application domain returned null.-or-<paramref name="scope" /> contains the value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Domain" />, but the permissions for the application domain cannot be determined.-or-<paramref name="scope" /> contains the value <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Assembly" />, but the permissions for the calling assembly cannot be determined.</exception><PermissionSet><IPermission class="System.Security.Permissions.IsolatedStorageFilePermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static IsolatedStorageFile GetStore(IsolatedStorageScope scope, object applicationIdentity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Enables an application to explicitly request a larger quota size, in bytes. </summary><returns>true if the new quota is accepted; otherwise, false.</returns><param name="newQuotaSize">The requested size, in bytes.</param><exception cref="T:System.ArgumentException"><paramref name="newQuotaSize" /> is less than current quota size.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="newQuotaSize" /> is less than zero, or less than or equal to the current quota size. </exception><exception cref="T:System.InvalidOperationException">The isolated store has been closed.</exception><exception cref="T:System.NotSupportedException">The current scope is not for an application user.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed.-or-Isolated storage is disabled.</exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public override bool IncreaseQuotaTo(long newQuotaSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deletes a file in the isolated storage scope.</summary><param name="file">The relative path of the file to delete within the isolated storage scope. </param><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The target file is open or the path is incorrect. </exception><exception cref="T:System.ArgumentNullException">The file path is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void DeleteFile(string file)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified path refers to an existing file in the isolated store.</summary><returns>true if <paramref name="path" /> refers to an existing file in the isolated store and is not null; otherwise, false.</returns><param name="path">The path and file name to test.</param><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null.</exception><exception cref="T:System.InvalidOperationException">The isolated store is closed.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed. </exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public bool FileExists(string path)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether the specified path refers to an existing directory in the isolated store.</summary><returns>true if <paramref name="path" /> refers to an existing directory in the isolated store and is not null; otherwise, false.</returns><param name="path">The path to test.</param><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null.</exception><exception cref="T:System.InvalidOperationException">The isolated store is closed.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed. -or-Isolated storage is disabled.</exception>
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        public bool DirectoryExists(string path)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a directory in the isolated storage scope.</summary><param name="dir">The relative path of the directory to create within the isolated storage scope. </param><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The current code has insufficient permissions to create isolated storage directory. </exception><exception cref="T:System.ArgumentNullException">The directory path is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void CreateDirectory(string dir)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the creation date and time of a specified file or directory.</summary><returns>The creation date and time for the specified file or directory. This value is expressed in local time.</returns><param name="path">The path to the file or directory for which to obtain creation date and time information.</param><exception cref="T:System.ArgumentException"><paramref name="path " />is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception><exception cref="T:System.ArgumentNullException"><paramref name="path " />is null.</exception><exception cref="T:System.InvalidOperationException">The isolated store has been closed.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed.-or-Isolated storage is disabled.</exception>
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        public DateTimeOffset GetCreationTime(string path)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the date and time a specified file or directory was last accessed.</summary><returns>The date and time that the specified file or directory was last accessed. This value is expressed in local time.</returns><param name="path">The path to the file or directory for which to obtain last access date and time information.</param><exception cref="T:System.ArgumentException"><paramref name="path " />is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception><exception cref="T:System.ArgumentNullException"><paramref name="path " />is null.</exception><exception cref="T:System.InvalidOperationException">The isolated store has been closed.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed.-or-Isolated storage is disabled.</exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public DateTimeOffset GetLastAccessTime(string path)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the date and time a specified file or directory was last written to.</summary><returns>The date and time that the specified file or directory was last written to. This value is expressed in local time.</returns><param name="path">The path to the file or directory for which to obtain last write date and time information.</param><exception cref="T:System.ArgumentException"><paramref name="path " />is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception><exception cref="T:System.ArgumentNullException"><paramref name="path " />is null.</exception><exception cref="T:System.InvalidOperationException">The isolated store has been closed.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed.-or-Isolated storage is disabled.</exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public DateTimeOffset GetLastWriteTime(string path)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies an existing file to a new file.  </summary><param name="sourceFileName">The name of the file to copy.</param><param name="destinationFileName">The name of the destination file. This cannot be a directory or an existing file.</param><exception cref="T:System.ArgumentException"><paramref name="sourceFileName " />or<paramref name=" destinationFileName " />is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception><exception cref="T:System.ArgumentNullException"><paramref name="sourceFileName " />or<paramref name=" destinationFileName " />is null.</exception><exception cref="T:System.InvalidOperationException">The isolated store has been closed.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="sourceFileName " />was not found.</exception><exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="sourceFileName " />was not found.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed.-or-Isolated storage is disabled.-or-<paramref name="destinationFileName" /> exists.-or-An I/O error has occurred.</exception>
        [ComVisibleAttribute(false)]
        public void CopyFile(string sourceFileName, string destinationFileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Copies an existing file to a new file, and optionally overwrites an existing file.</summary><param name="sourceFileName">The name of the file to copy.</param><param name="destinationFileName">The name of the destination file. This cannot be a directory.</param><param name="overwrite">true if the destination file can be overwritten; otherwise, false.</param><exception cref="T:System.ArgumentException"><paramref name="sourceFileName " />or<paramref name=" destinationFileName " />is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception><exception cref="T:System.ArgumentNullException"><paramref name="sourceFileName " />or<paramref name=" destinationFileName " />is null.</exception><exception cref="T:System.InvalidOperationException">The isolated store has been closed.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="sourceFileName " />was not found.</exception><exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="sourceFileName " />was not found.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed.-or-Isolated storage is disabled.-or-An I/O error has occurred.</exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public void CopyFile(string sourceFileName, string destinationFileName, bool overwrite)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Moves a specified file to a new location, and optionally lets you specify a new file name.</summary><param name="sourceFileName">The name of the file to move.</param><param name="destinationFileName">The path to the new location for the file. If a file name is included, the moved file will have that name.</param><exception cref="T:System.ArgumentException"><paramref name="sourceFileName " />or<paramref name=" destinationFileName " />is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception><exception cref="T:System.ArgumentNullException"><paramref name="sourceFileName " />or<paramref name=" destinationFileName " />is null.</exception><exception cref="T:System.InvalidOperationException">The isolated store has been closed.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception><exception cref="T:System.IO.FileNotFoundException"><paramref name="sourceFileName" /> was not found.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed.-or-Isolated storage is disabled.</exception>
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        public void MoveFile(string sourceFileName, string destinationFileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Moves a specified directory and its contents to a new location.</summary><param name="sourceDirectoryName">The name of the directory to move.</param><param name="destinationDirectoryName">The path to the new location for <paramref name="sourceDirectoryName" />. This cannot be the path to an existing directory.</param><exception cref="T:System.ArgumentException"><paramref name="sourceFileName " />or<paramref name=" destinationFileName " />is a zero-length string, contains only white space, or contains one or more invalid characters defined by the <see cref="M:System.IO.Path.GetInvalidPathChars" /> method.</exception><exception cref="T:System.ArgumentNullException"><paramref name="sourceFileName " />or<paramref name=" destinationFileName " />is null.</exception><exception cref="T:System.InvalidOperationException">The isolated store has been closed.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception><exception cref="T:System.IO.DirectoryNotFoundException"><paramref name="sourceDirectoryName" /> does not exist.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed.-or-Isolated storage is disabled.-or-<paramref name="destinationDirectoryName" /> already exists.-or-<paramref name="sourceDirectoryName" /> and <paramref name="destinationDirectoryName" /> refer to the same directory.</exception>
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        public void MoveDirectory(string sourceDirectoryName, string destinationDirectoryName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deletes a directory in the isolated storage scope.</summary><param name="dir">The relative path of the directory to delete within the isolated storage scope. </param><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The directory could not be deleted. </exception><exception cref="T:System.ArgumentNullException">The directory path was null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void DeleteDirectory(string dir)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public string[] GetFileNames()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the file names that match a search pattern.</summary><returns>An array of relative paths of files in the isolated storage scope that match <paramref name="searchPattern" />. A zero-length array specifies that there are no files that match.</returns><param name="searchPattern">A search pattern. Both single-character ("?") and multi-character ("*") wildcards are supported. </param><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed. </exception><exception cref="T:System.IO.DirectoryNotFoundException">The file path specified by <paramref name="searchPattern" /> cannot be found. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public string[] GetFileNames(string searchPattern)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public string[] GetDirectoryNames()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Enumerates the directories in an isolated storage scope that match a given search pattern.</summary><returns>An array of the relative paths of directories in the isolated storage scope that match <paramref name="searchPattern" />. A zero-length array specifies that there are no directories that match.</returns><param name="searchPattern">A search pattern. Both single-character ("?") and multi-character ("*") wildcards are supported. </param><exception cref="T:System.ArgumentNullException"><paramref name="searchPattern" /> is null. </exception><exception cref="T:System.InvalidOperationException">The isolated store is closed.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception><exception cref="T:System.UnauthorizedAccessException">Caller does not have permission to enumerate directories resolved from <paramref name="searchPattern" />.</exception><exception cref="T:System.IO.DirectoryNotFoundException">The directory or directories specified by <paramref name="searchPattern" /> are not found.</exception><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public string[] GetDirectoryNames(string searchPattern)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Opens a file in the specified mode.</summary><returns>A file that is opened in the specified mode, with read/write access, and is unshared.</returns><param name="path">The relative path of the file within the isolated store.</param><param name="mode">One of the enumeration values that specifies how to open the file. </param><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed. -or-Isolated storage is disabled.</exception><exception cref="T:System.ArgumentException"><paramref name="path" /> is malformed.</exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null.</exception><exception cref="T:System.IO.DirectoryNotFoundException">The directory in <paramref name="path" /> does not exist.</exception><exception cref="T:System.IO.FileNotFoundException">No file was found and the <paramref name="mode" /> is set to <see cref="F:System.IO.FileMode.Open" />.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception>
        [ComVisibleAttribute(false)]
        public IsolatedStorageFileStream OpenFile(string path, FileMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Opens a file in the specified mode with the specified read/write access.</summary><returns>A file that is opened in the specified mode and access, and is unshared.</returns><param name="path">The relative path of the file within the isolated store.</param><param name="mode">One of the enumeration values that specifies how to open the file.</param><param name="access">One of the enumeration values that specifies whether the file will be opened with read, write, or read/write access.</param><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed. -or-Isolated storage is disabled.</exception><exception cref="T:System.ArgumentException"><paramref name="path" /> is malformed.</exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null.</exception><exception cref="T:System.IO.DirectoryNotFoundException">The directory in <paramref name="path" /> does not exist.</exception><exception cref="T:System.IO.FileNotFoundException">No file was found and the <paramref name="mode" /> is set to <see cref="F:System.IO.FileMode.Open" />. </exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception>
        [ComVisibleAttribute(false)]
        public IsolatedStorageFileStream OpenFile(string path, FileMode mode, FileAccess access)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Opens a file in the specified mode, with the specified read/write access and sharing permission.</summary><returns>A file that is opened in the specified mode and access, and with the specified sharing options.</returns><param name="path">The relative path of the file within the isolated store.</param><param name="mode">One of the enumeration values that specifies how to open or create the file.</param><param name="access">One of the enumeration values that specifies whether the file will be opened with read, write, or read/write access</param><param name="share">A bitwise combination of enumeration values that specify the type of access other <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFileStream" />   objects have to this file.</param><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed. -or-Isolated storage is disabled.</exception><exception cref="T:System.ArgumentException"><paramref name="path" /> is malformed.</exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null.</exception><exception cref="T:System.IO.DirectoryNotFoundException">The directory in <paramref name="path" /> does not exist.</exception><exception cref="T:System.IO.FileNotFoundException">No file was found and the <paramref name="mode" /> is set to <see cref="M:System.IO.FileInfo.Open(System.IO.FileMode)" />.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception>
        [ComVisibleAttribute(false)]
        public IsolatedStorageFileStream OpenFile(string path, FileMode mode, FileAccess access, FileShare share)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a file in the isolated store.</summary><returns>A new isolated storage file.</returns><param name="path">The relative path of the file to create.</param><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store has been removed. -or-Isolated storage is disabled.</exception><exception cref="T:System.ArgumentException"><paramref name="path" /> is malformed.</exception><exception cref="T:System.ArgumentNullException"><paramref name="path" /> is null.</exception><exception cref="T:System.IO.DirectoryNotFoundException">The directory in <paramref name="path" /> does not exist.</exception><exception cref="T:System.ObjectDisposedException">The isolated store has been disposed.</exception>
        [ComVisibleAttribute(false)]
        public IsolatedStorageFileStream CreateFile(string path)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override void Remove()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        ~IsolatedStorageFile()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the specified isolated storage scope for all identities.</summary><param name="scope">A bitwise combination of the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" /> values. </param><exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">The isolated store cannot be removed. </exception><PermissionSet><IPermission class="System.Security.Permissions.IsolatedStorageFilePermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void Remove(IsolatedStorageScope scope)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Gets the enumerator for the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFile" /> stores within an isolated storage scope.</summary><returns>Enumerator for the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageFile" /> stores within the specified isolated storage scope.</returns><param name="scope">Represents the <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" /> for which to return isolated stores. User and User|Roaming are the only IsolatedStorageScope combinations supported. </param><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.IsolatedStorageFilePermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static IEnumerator GetEnumerator(IsolatedStorageScope scope)
        {
             throw new NotImplementedException();
        }
        
        
        protected override IsolatedStoragePermission GetPermission(PermissionSet ps)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
