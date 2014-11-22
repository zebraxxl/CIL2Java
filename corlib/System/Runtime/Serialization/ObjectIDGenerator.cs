using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
    /// <summary>Generates IDs for objects.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class ObjectIDGenerator
    {
    
        public ObjectIDGenerator()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual long GetId(object obj, ref bool firstTime)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual long HasId(object obj, ref bool firstTime)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
