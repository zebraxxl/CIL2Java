using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;

namespace System.Threading
{
    /// <summary>A synchronization primitive that can also be used for interprocess synchronization. </summary><filterpriority>1</filterpriority>
    [ComVisibleAttribute(true)]
    public sealed class Mutex : WaitHandle
    {
    
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public Mutex(bool initiallyOwned, string name, ref bool createdNew)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [SecurityCriticalAttribute()]
        public Mutex(bool initiallyOwned, string name, ref bool createdNew, MutexSecurity mutexSecurity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.Mutex" /> class with a Boolean value that indicates whether the calling thread should have initial ownership of the mutex, and a string that is the name of the mutex.</summary><param name="initiallyOwned">true to give the calling thread initial ownership of the named system mutex if the named system mutex is created as a result of this call; otherwise, false. </param><param name="name">The name of the <see cref="T:System.Threading.Mutex" />. If the value is null, the <see cref="T:System.Threading.Mutex" /> is unnamed. </param><exception cref="T:System.UnauthorizedAccessException">The named mutex exists and has access control security, but the user does not have <see cref="F:System.Security.AccessControl.MutexRights.FullControl" />.</exception><exception cref="T:System.IO.IOException">A Win32 error occurred.</exception><exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">The named mutex cannot be created, perhaps because a wait handle of a different type has the same name.</exception><exception cref="T:System.ArgumentException"><paramref name="name" /> is longer than 260 characters.</exception>
        [SecurityCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public Mutex(bool initiallyOwned, string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.Mutex" /> class with a Boolean value that indicates whether the calling thread should have initial ownership of the mutex.</summary><param name="initiallyOwned">true to give the calling thread initial ownership of the mutex; otherwise, false. </param>
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public Mutex(bool initiallyOwned)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        public Mutex()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Opens the specified named mutex, if it already exists.</summary><returns>An object that represents the named system mutex.</returns><param name="name">The name of the system mutex to open.</param><exception cref="T:System.ArgumentException"><paramref name="name" /> is an empty string.-or-<paramref name="name" /> is longer than 260 characters.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.</exception><exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">The named mutex does not exist.</exception><exception cref="T:System.IO.IOException">A Win32 error occurred.</exception><exception cref="T:System.UnauthorizedAccessException">The named mutex exists, but the user does not have the security access required to use it.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static Mutex OpenExisting(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Opens the specified named mutex, if it already exists, with the desired security access.</summary><returns>An object that represents the named system mutex.</returns><param name="name">The name of the system mutex to open.</param><param name="rights">A bitwise combination of the enumeration values that represent the desired security access.</param><exception cref="T:System.ArgumentException"><paramref name="name" /> is an empty string. -or-<paramref name="name" /> is longer than 260 characters.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.</exception><exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">The named mutex does not exist.</exception><exception cref="T:System.IO.IOException">A Win32 error occurred. </exception><exception cref="T:System.UnauthorizedAccessException">The named mutex exists, but the user does not have the desired security access.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static Mutex OpenExisting(string name, MutexRights rights)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static bool TryOpenExisting(string name, ref Mutex result)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static bool TryOpenExisting(string name, MutexRights rights, ref Mutex result)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        [SecuritySafeCriticalAttribute()]
        public void ReleaseMutex()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public MutexSecurity GetAccessControl()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the access control security for a named system mutex.</summary><param name="mutexSecurity">A <see cref="T:System.Security.AccessControl.MutexSecurity" />  object that represents the access control security to be applied to the named system mutex.</param><exception cref="T:System.ArgumentNullException"><paramref name="mutexSecurity" /> is null.</exception><exception cref="T:System.UnauthorizedAccessException">The user does not have <see cref="F:System.Security.AccessControl.MutexRights.ChangePermissions" />.-or-The mutex was not opened with <see cref="F:System.Security.AccessControl.MutexRights.ChangePermissions" />.</exception><exception cref="T:System.SystemException">The current <see cref="T:System.Threading.Mutex" /> object does not represent a named system mutex.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void SetAccessControl(MutexSecurity mutexSecurity)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
