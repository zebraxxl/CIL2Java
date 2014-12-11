using System;
using System.Collections;

namespace System.Configuration
{
    public class SettingsPropertyCollection : ICloneable, ICollection
    {
    
        public SettingsProperty this[string name]
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }
    
        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SettingsPropertyCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(SettingsProperty property)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public object Clone()
        {
             throw new NotImplementedException();
        }
        
        
        public void SetReadOnly()
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnAdd(SettingsProperty property)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnAddComplete(SettingsProperty property)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnClear()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnClearComplete()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnRemove(SettingsProperty property)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnRemoveComplete(SettingsProperty property)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(Array array, int index)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
