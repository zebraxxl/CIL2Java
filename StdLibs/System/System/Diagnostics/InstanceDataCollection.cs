using System.Collections;
using System;

namespace System.Diagnostics
{
    public class InstanceDataCollection : DictionaryBase
    {
    
        public string CounterName
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
    
        public InstanceData this[string instanceName]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [ObsoleteAttribute("This constructor has been deprecated.  Please use System.Diagnostics.InstanceDataCollectionCollection.get_Item to get an instance of this collection instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public InstanceDataCollection(string counterName)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(string instanceName)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(InstanceData[] instances, int index)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
