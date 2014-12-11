using System.Collections;
using System;

namespace System.ComponentModel
{
    public class PropertyDescriptorCollection : IList, IDictionary
    {
        public static readonly PropertyDescriptorCollection Empty;
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual PropertyDescriptor this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual PropertyDescriptor this[string name]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public PropertyDescriptorCollection(PropertyDescriptor[] properties)
        {
             throw new NotImplementedException();
        }
        
        
        public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly)
        {
             throw new NotImplementedException();
        }
        
        
        public int Add(PropertyDescriptor value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(PropertyDescriptor value)
        {
             throw new NotImplementedException();
        }
        
        
        public void CopyTo(Array array, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual PropertyDescriptor Find(string name, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOf(PropertyDescriptor value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Insert(int index, PropertyDescriptor value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(PropertyDescriptor value)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveAt(int index)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual PropertyDescriptorCollection Sort()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual PropertyDescriptorCollection Sort(string[] names)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual PropertyDescriptorCollection Sort(string[] names, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual PropertyDescriptorCollection Sort(IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        protected void InternalSort(string[] names)
        {
             throw new NotImplementedException();
        }
        
        
        protected void InternalSort(IComparer sorter)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }



        int IList.Add(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Clear()
        {
            throw new NotImplementedException();
        }

        bool IList.Contains(object value)
        {
            throw new NotImplementedException();
        }

        int IList.IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        void IList.Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        bool IList.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        bool IList.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        void IList.Remove(object value)
        {
            throw new NotImplementedException();
        }

        void IList.RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        object IList.this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
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

        void IDictionary.Add(object key, object value)
        {
            throw new NotImplementedException();
        }

        void IDictionary.Clear()
        {
            throw new NotImplementedException();
        }

        bool IDictionary.Contains(object key)
        {
            throw new NotImplementedException();
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        bool IDictionary.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        ICollection IDictionary.Keys
        {
            get { throw new NotImplementedException(); }
        }

        void IDictionary.Remove(object key)
        {
            throw new NotImplementedException();
        }

        ICollection IDictionary.Values
        {
            get { throw new NotImplementedException(); }
        }

        object IDictionary.this[object key]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
