using System.Runtime.InteropServices;
using System.Collections;

namespace System.ComponentModel
{
    [ComVisibleAttribute(true)]
    public class ComponentCollection : ReadOnlyCollectionBase
    {
        public virtual IComponent this[string name]
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual IComponent this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ComponentCollection(IComponent[] components)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(IComponent[] array, int index)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
