using System.Collections;
using System.Runtime.Serialization;
using System;

namespace System.Collections.Specialized
{
    [Serializable]
    public abstract class NameObjectCollectionBase : ICollection, ISerializable, IDeserializationCallback
    {
        [Serializable]
        public class KeysCollection : ICollection
        {
        
            public string this[int index]
            {
                get { throw new NotImplementedException(); }
            }
        
            public int Count
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public virtual string Get(int index)
            {
                 throw new NotImplementedException();
            }
            
            
            public IEnumerator GetEnumerator()
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
    
    
        protected bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual KeysCollection Keys
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected NameObjectCollectionBase()
        {
             throw new NotImplementedException();
        }
        
        
        protected NameObjectCollectionBase(IEqualityComparer equalityComparer)
        {
             throw new NotImplementedException();
        }
        
        
        protected NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Please use NameObjectCollectionBase(IEqualityComparer) instead.")]
        protected NameObjectCollectionBase(IHashCodeProvider hashProvider, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("Please use NameObjectCollectionBase(Int32, IEqualityComparer) instead.")]
        protected NameObjectCollectionBase(int capacity, IHashCodeProvider hashProvider, IComparer comparer)
        {
             throw new NotImplementedException();
        }
        
        
        protected NameObjectCollectionBase(int capacity)
        {
             throw new NotImplementedException();
        }
        
        
        protected NameObjectCollectionBase(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void OnDeserialization(object sender)
        {
             throw new NotImplementedException();
        }
        
        
        protected bool BaseHasKeys()
        {
             throw new NotImplementedException();
        }
        
        
        protected void BaseAdd(string name, object value)
        {
             throw new NotImplementedException();
        }
        
        
        protected void BaseRemove(string name)
        {
             throw new NotImplementedException();
        }
        
        
        protected void BaseRemoveAt(int index)
        {
             throw new NotImplementedException();
        }
        
        
        protected void BaseClear()
        {
             throw new NotImplementedException();
        }
        
        
        protected object BaseGet(string name)
        {
             throw new NotImplementedException();
        }
        
        
        protected void BaseSet(string name, object value)
        {
             throw new NotImplementedException();
        }
        
        
        protected object BaseGet(int index)
        {
             throw new NotImplementedException();
        }
        
        
        protected string BaseGetKey(int index)
        {
             throw new NotImplementedException();
        }
        
        
        protected void BaseSet(int index, object value)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        protected string[] BaseGetAllKeys()
        {
             throw new NotImplementedException();
        }
        
        
        protected object[] BaseGetAllValues()
        {
             throw new NotImplementedException();
        }
        
        
        protected object[] BaseGetAllValues(Type type)
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
