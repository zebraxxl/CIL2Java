using System;
using System.Collections;
using System.Runtime.Serialization;

namespace System.Collections.Specialized
{
    [Serializable]
    public class NameValueCollection : NameObjectCollectionBase
    {
    
        public string this[string name]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string[] AllKeys
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public NameValueCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public NameValueCollection(NameValueCollection col)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Please use NameValueCollection(IEqualityComparer) instead.")]
        public NameValueCollection(IHashCodeProvider hashProvider, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public NameValueCollection(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        public NameValueCollection(IEqualityComparer equalityComparer)
        {
             throw new NotImplementedException();
        }
        
        
        public NameValueCollection(int capacity, IEqualityComparer equalityComparer)
        {
             throw new NotImplementedException();
        }
        
        
        public NameValueCollection(int capacity, NameValueCollection col)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Please use NameValueCollection(Int32, IEqualityComparer) instead.")]
        public NameValueCollection(int capacity, IHashCodeProvider hashProvider, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        protected NameValueCollection(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        protected void InvalidateCachedArrays()
        {
             throw new NotImplementedException();
        }
        
        
        public void Add(NameValueCollection c)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(Array dest, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public bool HasKeys()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Add(string name, string value)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string Get(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string[] GetValues(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Set(string name, string value)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Remove(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string Get(int index)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string[] GetValues(int index)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string GetKey(int index)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
