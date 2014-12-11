using System.Collections.Generic;
using System.Net;

namespace System.Net.NetworkInformation
{
    public class IPAddressCollection : ICollection<IPAddress>, IEnumerable<IPAddress>
    {
    
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual IPAddress this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected IPAddressCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void CopyTo(IPAddress[] array, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Add(IPAddress address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool Contains(IPAddress address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IEnumerator<IPAddress> GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool Remove(IPAddress address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Clear()
        {
             throw new NotImplementedException();
        }



        void ICollection<IPAddress>.Add(IPAddress item)
        {
            throw new NotImplementedException();
        }

        void ICollection<IPAddress>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<IPAddress>.Contains(IPAddress item)
        {
            throw new NotImplementedException();
        }

        void ICollection<IPAddress>.CopyTo(IPAddress[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ICollection<IPAddress>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<IPAddress>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<IPAddress>.Remove(IPAddress item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<IPAddress> IEnumerable<IPAddress>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Collections.IEnumerator Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
