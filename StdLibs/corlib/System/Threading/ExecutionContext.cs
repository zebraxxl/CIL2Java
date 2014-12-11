using System;
using System.Runtime.Serialization;
using System.Security;
using System.Runtime.Remoting.Messaging;

namespace System.Threading
{
    /// <summary>Manages the execution context for the current thread. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [Serializable]
    public sealed class ExecutionContext : IDisposable, ISerializable
    {
    
    
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Runs a method in a specified execution context on the current thread.</summary><param name="executionContext">The <see cref="T:System.Threading.ExecutionContext" /> to set.</param><param name="callback">A <see cref="T:System.Threading.ContextCallback" /> delegate that represents the method to be run in the provided execution context.</param><param name="state">The object to pass to the callback method.</param><exception cref="T:System.InvalidOperationException"><paramref name="executionContext" /> is null.-or-<paramref name="executionContext" /> was not acquired through a capture operation. -or-<paramref name="executionContext" /> has already been used as the argument to a <see cref="M:System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext,System.Threading.ContextCallback,System.Object)" /> call.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void Run(ExecutionContext executionContext, ContextCallback callback, object state)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public ExecutionContext CreateCopy()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static AsyncFlowControl SuppressFlow()
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
        
        
        [SecuritySafeCriticalAttribute()]
        public static ExecutionContext Capture()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the logical context information needed to recreate an instance of the current execution context.</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to be populated with serialization information. </param><param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure representing the destination context of the serialization. </param><exception cref="T:System.ArgumentNullException"><paramref name="info" /> is null. </exception><filterpriority>2</filterpriority>
        [SecurityCriticalAttribute()]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
