using System.Collections.Generic;

namespace System.Net.NetworkInformation
{
    public class MulticastIPAddressInformationCollection : ICollection<MulticastIPAddressInformation>, IEnumerable<MulticastIPAddressInformation>
    {
    
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual MulticastIPAddressInformation this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected MulticastIPAddressInformationCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void CopyTo(MulticastIPAddressInformation[] array, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Add(MulticastIPAddressInformation address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool Contains(MulticastIPAddressInformation address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IEnumerator<MulticastIPAddressInformation> GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool Remove(MulticastIPAddressInformation address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Clear()
        {
             throw new NotImplementedException();
        }



        void ICollection<MulticastIPAddressInformation>.Add(MulticastIPAddressInformation item)
        {
            throw new NotImplementedException();
        }

        void ICollection<MulticastIPAddressInformation>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<MulticastIPAddressInformation>.Contains(MulticastIPAddressInformation item)
        {
            throw new NotImplementedException();
        }

        void ICollection<MulticastIPAddressInformation>.CopyTo(MulticastIPAddressInformation[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ICollection<MulticastIPAddressInformation>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<MulticastIPAddressInformation>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<MulticastIPAddressInformation>.Remove(MulticastIPAddressInformation item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<MulticastIPAddressInformation> IEnumerable<MulticastIPAddressInformation>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Collections.IEnumerator Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
