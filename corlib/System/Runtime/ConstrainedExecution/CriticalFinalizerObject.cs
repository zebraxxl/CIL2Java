using System.Runtime.InteropServices;

namespace System.Runtime.ConstrainedExecution
{
    /// <summary>Ensures that all finalization code in derived classes is marked as critical.</summary>
    [ComVisibleAttribute(true)]
    public abstract class CriticalFinalizerObject
    {
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        protected CriticalFinalizerObject()
        {
             throw new NotImplementedException();
        }
        
        
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        ~CriticalFinalizerObject()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
