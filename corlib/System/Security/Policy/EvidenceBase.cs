using System.Runtime.InteropServices;
using System.Security;

namespace System.Security.Policy
{
    /// <summary>Provides a base class from which all objects to be used as evidence must derive. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class EvidenceBase
    {
        protected EvidenceBase()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual EvidenceBase Clone()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
