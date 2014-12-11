using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Threading
{
    /// <summary>Represents a handle that has been registered when calling <see cref="M:System.Threading.ThreadPool.RegisterWaitForSingleObject(System.Threading.WaitHandle,System.Threading.WaitOrTimerCallback,System.Object,System.UInt32,System.Boolean)" />. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public sealed class RegisteredWaitHandle : MarshalByRefObject
    {
    
        /// <summary>Cancels a registered wait operation issued by the <see cref="M:System.Threading.ThreadPool.RegisterWaitForSingleObject(System.Threading.WaitHandle,System.Threading.WaitOrTimerCallback,System.Object,System.UInt32,System.Boolean)" /> method.</summary><returns>true if the function succeeds; otherwise, false.</returns><param name="waitObject">The <see cref="T:System.Threading.WaitHandle" /> to be signaled. </param><filterpriority>2</filterpriority>
        [ComVisibleAttribute(true)]
        [SecuritySafeCriticalAttribute()]
        public bool Unregister(WaitHandle waitObject)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
