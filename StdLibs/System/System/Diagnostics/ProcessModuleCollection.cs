using System.Collections;

namespace System.Diagnostics
{
    public class ProcessModuleCollection : ReadOnlyCollectionBase
    {
        public ProcessModule this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected ProcessModuleCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public ProcessModuleCollection(ProcessModule[] processModules)
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOf(ProcessModule module)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(ProcessModule module)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(ProcessModule[] array, int index)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
