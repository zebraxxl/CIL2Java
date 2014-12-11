using System.Collections;
using System;

namespace System.Diagnostics
{
    public class InstanceDataCollectionCollection : DictionaryBase
    {
        public InstanceDataCollection this[string counterName]
        {
            get { throw new NotImplementedException(); }
        }
    
        public ICollection Keys
        {
            get { throw new NotImplementedException(); }
        }
    
        public ICollection Values
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [ObsoleteAttribute("This constructor has been deprecated.  Please use System.Diagnostics.PerformanceCounterCategory.ReadCategory() to get an instance of this collection instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public InstanceDataCollectionCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(string counterName)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(InstanceDataCollection[] counters, int index)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
