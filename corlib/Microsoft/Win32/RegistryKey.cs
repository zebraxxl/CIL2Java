using System.Runtime.InteropServices;
using System;
using System.Security;
using Microsoft.Win32.SafeHandles;
using System.Security.AccessControl;

namespace Microsoft.Win32
{
    /// <summary>Represents a key-level node in the Windows registry. This class is a registry encapsulation.</summary>
    [ComVisibleAttribute(true)]
    public sealed class RegistryKey : MarshalByRefObject, IDisposable
    {
    
        /// <summary>Retrieves the count of subkeys of the current key.</summary><returns>The number of subkeys of the current key.</returns><exception cref="T:System.Security.SecurityException">The user does not have read permission for the key. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being manipulated is closed (closed keys cannot be accessed). </exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><exception cref="T:System.IO.IOException">A system error occurred, for example the current key has been deleted.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public int SubKeyCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the view that was used to create the registry key. </summary><returns>The view that was used to create the registry key.-or-<see cref="F:Microsoft.Win32.RegistryView.Default" />, if no view was used.</returns>
        [ComVisibleAttribute(false)]
        public RegistryView View
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:Microsoft.Win32.SafeHandles.SafeRegistryHandle" /> object that represents the registry key that the current <see cref="T:Microsoft.Win32.RegistryKey" /> object encapsulates.</summary><returns>The handle to the registry key.</returns><exception cref="T:System.ObjectDisposedException">The registry key is closed. Closed keys cannot be accessed.</exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><exception cref="T:System.IO.IOException">A system error occurred, such as deletion of the current key.</exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read the key.</exception>
        [ComVisibleAttribute(false)]
        public SafeRegistryHandle Handle
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the count of values in the key.</summary><returns>The number of name/value pairs in the key.</returns><exception cref="T:System.Security.SecurityException">The user does not have read permission for the key. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being manipulated is closed (closed keys cannot be accessed). </exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><exception cref="T:System.IO.IOException">A system error occurred, for example the current key has been deleted.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        public int ValueCount
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the name of the key.</summary><returns>The absolute (qualified) name of the key.</returns><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> is closed (closed keys cannot be accessed). </exception>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Flush()
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new subkey or opens an existing subkey for write access.  </summary><returns>The newly created subkey, or null if the operation failed. If a zero-length string is specified for <paramref name="subkey" />, the current <see cref="T:Microsoft.Win32.RegistryKey" /> object is returned.</returns><param name="subkey">The name or path of the subkey to create or open. This string is not case-sensitive.</param><exception cref="T:System.ArgumentNullException"><paramref name="subkey" /> is null. </exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to create or open the registry key. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> on which this method is being invoked is closed (closed keys cannot be accessed). </exception><exception cref="T:System.UnauthorizedAccessException">The <see cref="T:Microsoft.Win32.RegistryKey" /> cannot be written to; for example, it was not opened as a writable key , or the user does not have the necessary access rights. </exception><exception cref="T:System.IO.IOException">The nesting level exceeds 510.-or-A system error occurred, such as deletion of the key, or an attempt to create a key in the <see cref="F:Microsoft.Win32.Registry.LocalMachine" /> root.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public RegistryKey CreateSubKey(string subkey)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new subkey or opens an existing subkey for write access, using the specified permission check option. </summary><returns>The newly created subkey, or null if the operation failed. If a zero-length string is specified for <paramref name="subkey" />, the current <see cref="T:Microsoft.Win32.RegistryKey" /> object is returned.</returns><param name="subkey">The name or path of the subkey to create or open. This string is not case-sensitive.</param><param name="permissionCheck">One of the enumeration values that specifies whether the key is opened for read or read/write access.</param><exception cref="T:System.ArgumentNullException"><paramref name="subkey" /> is null. </exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to create or open the registry key. </exception><exception cref="T:System.ArgumentException"><paramref name="permissionCheck" /> contains an invalid value.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> on which this method is being invoked is closed (closed keys cannot be accessed). </exception><exception cref="T:System.UnauthorizedAccessException">The <see cref="T:Microsoft.Win32.RegistryKey" /> cannot be written to; for example, it was not opened as a writable key, or the user does not have the necessary access rights. </exception><exception cref="T:System.IO.IOException">The nesting level exceeds 510.-or-A system error occurred, such as deletion of the key, or an attempt to create a key in the <see cref="F:Microsoft.Win32.Registry.LocalMachine" /> root.</exception>
        [ComVisibleAttribute(false)]
        public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a subkey or opens a subkey for write access, using the specified permission check and registry options. </summary><returns>The newly created subkey, or null if the operation failed.</returns><param name="subkey">The name or path of the subkey to create or open. </param><param name="permissionCheck">One of the enumeration values that specifies whether the key is opened for read or read/write access.</param><param name="options">The registry option to use; for example, that creates a volatile key. </param><exception cref="T:System.ArgumentNullException"><paramref name="subkey " />is null.</exception><exception cref="T:System.ObjectDisposedException">The current <see cref="T:Microsoft.Win32.RegistryKey" /> object is closed (closed keys cannot be accessed). </exception><exception cref="T:System.UnauthorizedAccessException">The current <see cref="T:Microsoft.Win32.RegistryKey" /> object cannot be written to; for example, it was not opened as a writable key, or the user does not have the required access rights.</exception><exception cref="T:System.IO.IOException">The nesting level exceeds 510.-or-A system error occurred, such as deletion of the key or an attempt to create a key in the <see cref="F:Microsoft.Win32.Registry.LocalMachine" /> root. </exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to create or open the registry key.</exception>
        [ComVisibleAttribute(false)]
        public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistryOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new subkey or opens an existing subkey for write access, using the specified permission check option and registry security. </summary><returns>The newly created subkey, or null if the operation failed. If a zero-length string is specified for <paramref name="subkey" />, the current <see cref="T:Microsoft.Win32.RegistryKey" /> object is returned.</returns><param name="subkey">The name or path of the subkey to create or open. This string is not case-sensitive.</param><param name="permissionCheck">One of the enumeration values that specifies whether the key is opened for read or read/write access.</param><param name="registrySecurity">The access control security for the new key.</param><exception cref="T:System.ArgumentNullException"><paramref name="subkey" /> is null. </exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to create or open the registry key. </exception><exception cref="T:System.ArgumentException"><paramref name="permissionCheck" /> contains an invalid value.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> on which this method is being invoked is closed (closed keys cannot be accessed). </exception><exception cref="T:System.UnauthorizedAccessException">The current <see cref="T:Microsoft.Win32.RegistryKey" /> cannot be written to; for example, it was not opened as a writable key, or the user does not have the necessary access rights.</exception><exception cref="T:System.IO.IOException">The nesting level exceeds 510.-or-A system error occurred, such as deletion of the key, or an attempt to create a key in the <see cref="F:Microsoft.Win32.Registry.LocalMachine" /> root.</exception>
        [ComVisibleAttribute(false)]
        public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistrySecurity registrySecurity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a subkey or opens a subkey for write access, using the specified permission check option, registry option, and registry security.</summary><returns>The newly created subkey, or null if the operation failed.  </returns><param name="subkey">The name or path of the subkey to create or open.</param><param name="permissionCheck">One of the enumeration values that specifies whether the key is opened for read or read/write access.</param><param name="registryOptions">The registry option to use.</param><param name="registrySecurity">The access control security for the new subkey. </param><exception cref="T:System.ArgumentNullException"><paramref name="subkey " />is null.</exception><exception cref="T:System.ObjectDisposedException">The current <see cref="T:Microsoft.Win32.RegistryKey" /> object is closed. Closed keys cannot be accessed. </exception><exception cref="T:System.UnauthorizedAccessException">The current <see cref="T:Microsoft.Win32.RegistryKey" /> object cannot be written to; for example, it was not opened as a writable key, or the user does not have the required access rights.</exception><exception cref="T:System.IO.IOException">The nesting level exceeds 510.-or-A system error occurred, such as deletion of the key or an attempt to create a key in the <see cref="F:Microsoft.Win32.Registry.LocalMachine" /> root. </exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to create or open the registry key.</exception>
        [ComVisibleAttribute(false)]
        public RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistryOptions registryOptions, RegistrySecurity registrySecurity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deletes the specified subkey. </summary><param name="subkey">The name of the subkey to delete. This string is not case-sensitive.</param><exception cref="T:System.InvalidOperationException">The <paramref name="subkey" /> has child subkeys </exception><exception cref="T:System.ArgumentException">The <paramref name="subkey" /> parameter does not specify a valid registry key </exception><exception cref="T:System.ArgumentNullException"><paramref name="subkey" /> is null</exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to delete the key. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being manipulated is closed (closed keys cannot be accessed). </exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public void DeleteSubKey(string subkey)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deletes the specified subkey, and specifies whether an exception is raised if the subkey is not found. </summary><param name="subkey">The name of the subkey to delete. This string is not case-sensitive.</param><param name="throwOnMissingSubKey">Indicates whether an exception should be raised if the specified subkey cannot be found. If this argument is true and the specified subkey does not exist, an exception is raised. If this argument is false and the specified subkey does not exist, no action is taken. </param><exception cref="T:System.InvalidOperationException"><paramref name="subkey" /> has child subkeys. </exception><exception cref="T:System.ArgumentException"><paramref name="subkey" /> does not specify a valid registry key, and <paramref name="throwOnMissingSubKey" /> is true. </exception><exception cref="T:System.ArgumentNullException"><paramref name="subkey" /> is null.</exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to delete the key. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being manipulated is closed (closed keys cannot be accessed). </exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void DeleteSubKey(string subkey, bool throwOnMissingSubKey)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deletes a subkey and any child subkeys recursively. </summary><param name="subkey">The subkey to delete. This string is not case-sensitive.</param><exception cref="T:System.ArgumentNullException"><paramref name="subkey" /> is null. </exception><exception cref="T:System.ArgumentException">Deletion of a root hive is attempted.-or-<paramref name="subkey" /> does not specify a valid registry subkey. </exception><exception cref="T:System.IO.IOException">An I/O error has occurred.</exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to delete the key. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being manipulated is closed (closed keys cannot be accessed). </exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public void DeleteSubKeyTree(string subkey)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deletes the specified subkey and any child subkeys recursively, and specifies whether an exception is raised if the subkey is not found. </summary><param name="subkey">The name of the subkey to delete. This string is not case-sensitive.</param><param name="throwOnMissingSubKey">Indicates whether an exception should be raised if the specified subkey cannot be found. If this argument is true and the specified subkey does not exist, an exception is raised. If this argument is false and the specified subkey does not exist, no action is taken.</param><exception cref="T:System.ArgumentException">An attempt was made to delete the root hive of the tree.-or-<paramref name="subkey" /> does not specify a valid registry subkey, and <paramref name="throwOnMissingSubKey" /> is true.</exception><exception cref="T:System.ArgumentNullException"><paramref name="subkey" /> is null.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> is closed (closed keys cannot be accessed).</exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to delete the key.</exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deletes the specified value from this key.</summary><param name="name">The name of the value to delete. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> is not a valid reference to a value. </exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to delete the value. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being manipulated is closed (closed keys cannot be accessed). </exception><exception cref="T:System.UnauthorizedAccessException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being manipulated is read-only. </exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public void DeleteValue(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Deletes the specified value from this key, and specifies whether an exception is raised if the value is not found.</summary><param name="name">The name of the value to delete. </param><param name="throwOnMissingValue">Indicates whether an exception should be raised if the specified value cannot be found. If this argument is true and the specified value does not exist, an exception is raised. If this argument is false and the specified value does not exist, no action is taken. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> is not a valid reference to a value and <paramref name="throwOnMissingValue" /> is true. -or- <paramref name="name" /> is null.</exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to delete the value. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being manipulated is closed (closed keys cannot be accessed). </exception><exception cref="T:System.UnauthorizedAccessException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being manipulated is read-only. </exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void DeleteValue(string name, bool throwOnMissingValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Opens a new <see cref="T:Microsoft.Win32.RegistryKey" /> that represents the requested key on the local machine with the specified view.</summary><returns>The requested registry key.</returns><param name="hKey">The HKEY to open.</param><param name="view">The registry view to use.</param><exception cref="T:System.ArgumentException"><paramref name="hKey" /> or <paramref name="view" /> is invalid.</exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to perform this action.</exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Opens a new <see cref="T:Microsoft.Win32.RegistryKey" /> that represents the requested key on a remote machine.</summary><returns>The requested registry key.</returns><param name="hKey">The HKEY to open, from the <see cref="T:Microsoft.Win32.RegistryHive" /> enumeration. </param><param name="machineName">The remote machine. </param><exception cref="T:System.ArgumentException"><paramref name="hKey" /> is invalid.</exception><exception cref="T:System.IO.IOException"><paramref name="machineName" /> is not found.</exception><exception cref="T:System.ArgumentNullException"><paramref name="machineName" /> is null. </exception><exception cref="T:System.Security.SecurityException">The user does not have the proper permissions to perform this operation. </exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public static RegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Opens a new registry key that represents the requested key on a remote machine with the specified view.</summary><returns>The requested registry key.</returns><param name="hKey">The HKEY to open from the <see cref="T:Microsoft.Win32.RegistryHive" /> enumeration.. </param><param name="machineName">The remote machine.</param><param name="view">The registry view to use.</param><exception cref="T:System.ArgumentException"><paramref name="hKey" /> or <paramref name="view" /> is invalid.</exception><exception cref="T:System.IO.IOException"><paramref name="machineName" /> is not found.</exception><exception cref="T:System.ArgumentNullException"><paramref name="machineName" /> is null. </exception><exception cref="T:System.ArgumentNullException"><paramref name="machineName" /> is null. </exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><exception cref="T:System.Security.SecurityException">The user does not have the required permissions to perform this operation.</exception>
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        public static RegistryKey OpenRemoteBaseKey(RegistryHive hKey, string machineName, RegistryView view)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a specified subkey, and specifies whether write access is to be applied to the key. </summary><returns>The subkey requested, or null if the operation failed.</returns><param name="name">Name or path of the subkey to open. </param><param name="writable">Set to true if you need write access to the key. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> is closed (closed keys cannot be accessed). </exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to access the registry key in the specified mode. </exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public RegistryKey OpenSubKey(string name, bool writable)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the specified subkey for read or read/write access.</summary><returns>The subkey requested, or null if the operation failed.</returns><param name="name">The name or path of the subkey to create or open.</param><param name="permissionCheck">One of the enumeration values that specifies whether the key is opened for read or read/write access.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null</exception><exception cref="T:System.ArgumentException"><paramref name="permissionCheck" /> contains an invalid value.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> is closed (closed keys cannot be accessed). </exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read the registry key. </exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public RegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the specified subkey for read or read/write access, requesting the specified access rights.</summary><returns>The subkey requested, or null if the operation failed.</returns><param name="name">The name or path of the subkey to create or open.</param><param name="permissionCheck">One of the enumeration values that specifies whether the key is opened for read or read/write access.</param><param name="rights">A bitwise combination of enumeration values that specifies the desired security access.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null</exception><exception cref="T:System.ArgumentException"><paramref name="permissionCheck" /> contains an invalid value.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> is closed (closed keys cannot be accessed). </exception><exception cref="T:System.Security.SecurityException"><paramref name="rights" /> includes invalid registry rights values.-or-The user does not have the requested permissions. </exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public RegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck, RegistryRights rights)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a subkey as read-only.</summary><returns>The subkey requested, or null if the operation failed.</returns><param name="name">The name or path of the subkey to open as read-only. </param><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null</exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> is closed (closed keys cannot be accessed). </exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read the registry key. </exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" /></PermissionSet>
        public RegistryKey OpenSubKey(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a registry key from a specified handle.</summary><returns>A registry key.</returns><param name="handle">The handle to the registry key.</param><exception cref="T:System.ArgumentNullException"><paramref name="handle" /> is null.</exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to perform this action.</exception>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public static RegistryKey FromHandle(SafeRegistryHandle handle)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a registry key from a specified handle and registry view setting. </summary><returns>A registry key.</returns><param name="handle">The handle to the registry key.</param><param name="view">The registry view to use.</param><exception cref="T:System.ArgumentException"><paramref name="view" /> is invalid.</exception><exception cref="T:System.ArgumentNullException"><paramref name="handle" /> is null.</exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to perform this action.</exception>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public static RegistryKey FromHandle(SafeRegistryHandle handle, RegistryView view)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public string[] GetSubKeyNames()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public string[] GetValueNames()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the value associated with the specified name. Returns null if the name/value pair does not exist in the registry.</summary><returns>The value associated with <paramref name="name" />, or null if <paramref name="name" /> is not found.</returns><param name="name">The name of the value to retrieve. This string is not case-sensitive.</param><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read from the registry key. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value is closed (closed keys cannot be accessed). </exception><exception cref="T:System.IO.IOException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value has been marked for deletion. </exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public object GetValue(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the value associated with the specified name. If the name is not found, returns the default value that you provide.</summary><returns>The value associated with <paramref name="name" />, with any embedded environment variables left unexpanded, or <paramref name="defaultValue" /> if <paramref name="name" /> is not found.</returns><param name="name">The name of the value to retrieve. This string is not case-sensitive.</param><param name="defaultValue">The value to return if <paramref name="name" /> does not exist. </param><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read from the registry key. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value is closed (closed keys cannot be accessed). </exception><exception cref="T:System.IO.IOException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value has been marked for deletion. </exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public object GetValue(string name, object defaultValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the value associated with the specified name and retrieval options. If the name is not found, returns the default value that you provide.</summary><returns>The value associated with <paramref name="name" />, processed according to the specified <paramref name="options" />, or <paramref name="defaultValue" /> if <paramref name="name" /> is not found.</returns><param name="name">The name of the value to retrieve. This string is not case-sensitive.</param><param name="defaultValue">The value to return if <paramref name="name" /> does not exist. </param><param name="options">One of the enumeration values that specifies optional processing of the retrieved value.</param><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read from the registry key. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value is closed (closed keys cannot be accessed). </exception><exception cref="T:System.IO.IOException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value has been marked for deletion. </exception><exception cref="T:System.ArgumentException"><paramref name="options" /> is not a valid <see cref="T:Microsoft.Win32.RegistryValueOptions" /> value; for example, an invalid value is cast to <see cref="T:Microsoft.Win32.RegistryValueOptions" />.</exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public object GetValue(string name, object defaultValue, RegistryValueOptions options)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the registry data type of the value associated with the specified name.</summary><returns>The registry data type of the value associated with <paramref name="name" />.</returns><param name="name">The name of the value whose registry data type is to be retrieved. This string is not case-sensitive.</param><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to read from the registry key. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value is closed (closed keys cannot be accessed). </exception><exception cref="T:System.IO.IOException">The subkey that contains the specified value does not exist.-or-The name/value pair specified by <paramref name="name" /> does not exist.This exception is not thrown on Windows 95, Windows 98, or Windows Millennium Edition.</exception><exception cref="T:System.UnauthorizedAccessException">The user does not have the necessary registry rights.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public RegistryValueKind GetValueKind(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the specified name/value pair.</summary><param name="name">The name of the value to store. </param><param name="value">The data to be stored. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException"><paramref name="value" /> is an unsupported data type. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value is closed (closed keys cannot be accessed). </exception><exception cref="T:System.UnauthorizedAccessException">The <see cref="T:Microsoft.Win32.RegistryKey" /> is read-only, and cannot be written to; for example, the key has not been opened with write access. -or-The <see cref="T:Microsoft.Win32.RegistryKey" /> object represents a root-level node, and the operating system is Windows Millennium Edition or Windows 98.</exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to create or modify registry keys. </exception><exception cref="T:System.IO.IOException">The <see cref="T:Microsoft.Win32.RegistryKey" /> object represents a root-level node, and the operating system is Windows 2000, Windows XP, or Windows Server 2003.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        public void SetValue(string name, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the value of a name/value pair in the registry key, using the specified registry data type.</summary><param name="name">The name of the value to be stored. </param><param name="value">The data to be stored. </param><param name="valueKind">The registry data type to use when storing the data. </param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null. </exception><exception cref="T:System.ArgumentException">The type of <paramref name="value" /> did not match the registry data type specified by <paramref name="valueKind" />, therefore the data could not be converted properly. </exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> that contains the specified value is closed (closed keys cannot be accessed). </exception><exception cref="T:System.UnauthorizedAccessException">The <see cref="T:Microsoft.Win32.RegistryKey" /> is read-only, and cannot be written to; for example, the key has not been opened with write access.-or-The <see cref="T:Microsoft.Win32.RegistryKey" /> object represents a root-level node, and the operating system is Windows Millennium Edition or Windows 98. </exception><exception cref="T:System.Security.SecurityException">The user does not have the permissions required to create or modify registry keys. </exception><exception cref="T:System.IO.IOException">The <see cref="T:Microsoft.Win32.RegistryKey" /> object represents a root-level node, and the operating system is Windows 2000, Windows XP, or Windows Server 2003.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public void SetValue(string name, object value, RegistryValueKind valueKind)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public RegistrySecurity GetAccessControl()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the specified sections of the access control security for the current registry key.</summary><returns>An object that describes the access control permissions on the registry key represented by the current <see cref="T:Microsoft.Win32.RegistryKey" />.</returns><param name="includeSections">A bitwise combination of enumeration values that specifies the type of security information to get. </param><exception cref="T:System.Security.SecurityException">The user does not have the necessary permissions.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being manipulated is closed (closed keys cannot be accessed).</exception><exception cref="T:System.InvalidOperationException">The current key has been deleted.</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public RegistrySecurity GetAccessControl(AccessControlSections includeSections)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Applies Windows access control security to an existing registry key.</summary><param name="registrySecurity">The access control security to apply to the current subkey. </param><exception cref="T:System.UnauthorizedAccessException">The current <see cref="T:Microsoft.Win32.RegistryKey" /> object represents a key with access control security, and the caller does not have <see cref="F:System.Security.AccessControl.RegistryRights.ChangePermissions" /> rights.</exception><exception cref="T:System.ArgumentNullException"><paramref name="registrySecurity" /> is null.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="T:Microsoft.Win32.RegistryKey" /> being manipulated is closed (closed keys cannot be accessed).</exception><PermissionSet><IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void SetAccessControl(RegistrySecurity registrySecurity)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
