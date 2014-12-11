using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Security.Principal
{
    /// <summary>Represents the Windows user prior to an impersonation operation.</summary>
    [ComVisibleAttribute(true)]
    public class WindowsImpersonationContext : IDisposable
    {
    
        [SecuritySafeCriticalAttribute()]
        public void Undo()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Principal.WindowsImpersonationContext" /> and optionally releases the managed resources. </summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
