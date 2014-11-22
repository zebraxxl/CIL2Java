using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Defines the base class for all context-bound classes.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public abstract class ContextBoundObject : MarshalByRefObject
    {
        protected ContextBoundObject()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
