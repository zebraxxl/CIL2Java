using System.Runtime.InteropServices;
using System.Collections;

namespace System.ComponentModel
{
    [ComVisibleAttribute(true)]
    public class EventDescriptorCollection : IList
    {
        public static readonly EventDescriptorCollection Empty;
    
        public int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual EventDescriptor this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual EventDescriptor this[string name]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public EventDescriptorCollection(EventDescriptor[] events)
        {
             throw new NotImplementedException();
        }
        
        
        public EventDescriptorCollection(EventDescriptor[] events, bool readOnly)
        {
             throw new NotImplementedException();
        }
        
        
        public int Add(EventDescriptor value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Contains(EventDescriptor value)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual EventDescriptor Find(string name, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        public int IndexOf(EventDescriptor value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Insert(int index, EventDescriptor value)
        {
             throw new NotImplementedException();
        }
        
        
        public void Remove(EventDescriptor value)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveAt(int index)
        {
             throw new NotImplementedException();
        }
        
        
        public IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual EventDescriptorCollection Sort()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual EventDescriptorCollection Sort(string[] names)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual EventDescriptorCollection Sort(string[] names, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual EventDescriptorCollection Sort(IComparer comparer)
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
    }
}
