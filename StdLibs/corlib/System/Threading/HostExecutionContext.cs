using System;
using System.Security;

namespace System.Threading
{
    /// <summary>Encapsulates and propagates the host execution context across threads. </summary><filterpriority>2</filterpriority>
    public class HostExecutionContext : IDisposable
    {
    
        /// <summary>Gets or sets the state of the host execution context.</summary><returns>An object representing the host execution context state.</returns>
        protected object State
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public HostExecutionContext()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Threading.HostExecutionContext" /> class using the specified state. </summary><param name="state">An object representing the host execution context state.</param>
        public HostExecutionContext(object state)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual HostExecutionContext CreateCopy()
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, releases the unmanaged resources used by the <see cref="T:System.Threading.WaitHandle" />, and optionally releases the managed resources. </summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        public virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
