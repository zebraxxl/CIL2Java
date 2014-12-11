using System.Runtime.InteropServices;
using System.Collections;
using System;

namespace System.ComponentModel
{
    [ComVisibleAttribute(true)]
    public class AttributeCollection : ICollection
    {
        public static readonly AttributeCollection Empty;
    
        protected virtual Attribute[] Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual Attribute this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual Attribute this[Type attributeType]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public AttributeCollection(params  Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        protected AttributeCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public static AttributeCollection FromExisting(AttributeCollection existing, params  Attribute[] newAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(Attribute attribute)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        protected Attribute GetDefaultAttribute(Type attributeType)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Matches(Attribute attribute)
        {
             throw new NotImplementedException();
        }
        
        
        public bool Matches(Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(Array array, int index)
        {
             throw new NotImplementedException();
        }



        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        int ICollection.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection.IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        object ICollection.SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
