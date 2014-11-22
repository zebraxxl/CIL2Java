using System;
using System.Threading;
using System.Security.Principal;

namespace System.Security
{
    /// <summary>Encapsulates and propagates all security-related data for execution contexts transferred across threads. This class cannot be inherited.</summary>
    public sealed class SecurityContext : IDisposable
    {
    
    
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static AsyncFlowControl SuppressFlow()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static AsyncFlowControl SuppressFlowWindowsIdentity()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static void RestoreFlow()
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsFlowSuppressed()
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsWindowsIdentityFlowSuppressed()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Runs the specified method in the specified security context on the current thread.</summary><param name="securityContext">The security context to set.</param><param name="callback">The delegate that represents the method to run in the specified security context.</param><param name="state">The object to pass to the callback method.</param><exception cref="T:System.InvalidOperationException"><paramref name="securityContext" /> is null.-or-<paramref name="securityContext" /> was not acquired through a capture operation. -or-<paramref name="securityContext" /> has already been used as the argument to a <see cref="M:System.Security.SecurityContext.Run(System.Security.SecurityContext,System.Threading.ContextCallback,System.Object)" /> method call.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Run(SecurityContext securityContext, ContextCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public SecurityContext CreateCopy()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static SecurityContext Capture()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
