using System.Runtime.ConstrainedExecution;
using System;
using System.Security;

namespace System.Runtime
{
    /// <summary>Checks for sufficient memory resources before executing an operation. This class cannot be inherited.</summary>
    public sealed class MemoryFailPoint : CriticalFinalizerObject, IDisposable
    {
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.MemoryFailPoint" /> class, specifying the amount of memory required for successful execution. </summary><param name="sizeInMegabytes">The required memory size, in megabytes. This must be a positive value.</param><exception cref="T:System.ArgumentOutOfRangeException">The specified memory size is negative.</exception><exception cref="T:System.InsufficientMemoryException">There is insufficient memory to begin execution of the code protected by the gate.</exception>
        [SecurityCriticalAttribute()]
        public MemoryFailPoint(int sizeInMegabytes)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        ~MemoryFailPoint()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
