using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;

namespace System.Threading
{
    /// <summary>Represents a thread synchronization event.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public class EventWaitHandle : WaitHandle
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.EventWaitHandle" /> class, specifying whether the wait handle is initially signaled, and whether it resets automatically or manually.</summary><param name="initialState">true to set the initial state to signaled; false to set it to nonsignaled.</param><param name="mode">One of the <see cref="T:System.Threading.EventResetMode" /> values that determines whether the event resets automatically or manually.</param>
        [SecuritySafeCriticalAttribute()]
        public EventWaitHandle(bool initialState, EventResetMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.EventWaitHandle" /> class, specifying whether the wait handle is initially signaled if created as a result of this call, whether it resets automatically or manually, and the name of a system synchronization event.</summary><param name="initialState">true to set the initial state to signaled if the named event is created as a result of this call; false to set it to nonsignaled.</param><param name="mode">One of the <see cref="T:System.Threading.EventResetMode" /> values that determines whether the event resets automatically or manually.</param><param name="name">The name of a system-wide synchronization event.</param><exception cref="T:System.IO.IOException">A Win32 error occurred.</exception><exception cref="T:System.UnauthorizedAccessException">The named event exists and has access control security, but the user does not have <see cref="F:System.Security.AccessControl.EventWaitHandleRights.FullControl" />.</exception><exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">The named event cannot be created, perhaps because a wait handle of a different type has the same name.</exception><exception cref="T:System.ArgumentException"><paramref name="name" /> is longer than 260 characters.</exception>
        [SecurityCriticalAttribute()]
        public EventWaitHandle(bool initialState, EventResetMode mode, string name)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public EventWaitHandle(bool initialState, EventResetMode mode, string name, ref bool createdNew)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public EventWaitHandle(bool initialState, EventResetMode mode, string name, ref bool createdNew, EventWaitHandleSecurity eventSecurity)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Opens the specified named synchronization event, if it already exists.</summary><returns>An  object that represents the named system event.</returns><param name="name">The name of the system synchronization event to open.</param><exception cref="T:System.ArgumentException"><paramref name="name" /> is an empty string. -or-<paramref name="name" /> is longer than 260 characters.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.</exception><exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">The named system event does not exist.</exception><exception cref="T:System.IO.IOException">A Win32 error occurred.</exception><exception cref="T:System.UnauthorizedAccessException">The named event exists, but the user does not have the security access required to use it.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static EventWaitHandle OpenExisting(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Opens the specified named synchronization event, if it already exists, with the desired security access.</summary><returns>An object that represents the named system event.</returns><param name="name">The name of the system synchronization event to open.</param><param name="rights">A bitwise combination of the enumeration values that represent the desired security access.</param><exception cref="T:System.ArgumentException"><paramref name="name" /> is an empty string.-or-<paramref name="name" /> is longer than 260 characters.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> is null.</exception><exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">The named system event does not exist.</exception><exception cref="T:System.IO.IOException">A Win32 error occurred.</exception><exception cref="T:System.UnauthorizedAccessException">The named event exists, but the user does not have the desired security access.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static EventWaitHandle OpenExisting(string name, EventWaitHandleRights rights)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static bool TryOpenExisting(string name, ref EventWaitHandle result)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static bool TryOpenExisting(string name, EventWaitHandleRights rights, ref EventWaitHandle result)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public bool Reset()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public bool Set()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public EventWaitHandleSecurity GetAccessControl()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the access control security for a named system event.</summary><param name="eventSecurity">An <see cref="T:System.Security.AccessControl.EventWaitHandleSecurity" />  object that represents the access control security to be applied to the named system event.</param><exception cref="T:System.ArgumentNullException"><paramref name="eventSecurity" /> is null.</exception><exception cref="T:System.UnauthorizedAccessException">The user does not have <see cref="F:System.Security.AccessControl.EventWaitHandleRights.ChangePermissions" />.-or-The event was not opened with <see cref="F:System.Security.AccessControl.EventWaitHandleRights.ChangePermissions" />.</exception><exception cref="T:System.SystemException">The current <see cref="T:System.Threading.EventWaitHandle" /> object does not represent a named system event.</exception><exception cref="T:System.ObjectDisposedException">The <see cref="M:System.Threading.EventWaitHandle.Close" /> method was previously called on this <see cref="T:System.Threading.EventWaitHandle" />.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public void SetAccessControl(EventWaitHandleSecurity eventSecurity)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
