using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Runtime.ConstrainedExecution;

namespace System.Threading
{
    [ComVisibleAttribute(false)]
    public sealed class Semaphore : WaitHandle
    {
    
        public Semaphore(int initialCount, int maximumCount)
        {
             throw new NotImplementedException();
        }
        
        
        public Semaphore(int initialCount, int maximumCount, string name)
        {
             throw new NotImplementedException();
        }
        
        
        public Semaphore(int initialCount, int maximumCount, string name, ref bool createdNew)
        {
             throw new NotImplementedException();
        }
        
        
        public Semaphore(int initialCount, int maximumCount, string name, ref bool createdNew, SemaphoreSecurity semaphoreSecurity)
        {
             throw new NotImplementedException();
        }
        
        
        public static Semaphore OpenExisting(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public static Semaphore OpenExisting(string name, SemaphoreRights rights)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryOpenExisting(string name, ref Semaphore result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryOpenExisting(string name, SemaphoreRights rights, ref Semaphore result)
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [PrePrepareMethodAttribute()]
        public int Release()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        public int Release(int releaseCount)
        {
             throw new NotImplementedException();
        }
        
        
        public SemaphoreSecurity GetAccessControl()
        {
             throw new NotImplementedException();
        }
        
        
        public void SetAccessControl(SemaphoreSecurity semaphoreSecurity)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
