using System.Collections.Generic;

namespace System.Net.NetworkInformation
{
    public class UnicastIPAddressInformationCollection : ICollection<UnicastIPAddressInformation>, IEnumerable<UnicastIPAddressInformation>
    {
    
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual UnicastIPAddressInformation this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected UnicastIPAddressInformationCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void CopyTo(UnicastIPAddressInformation[] array, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Add(UnicastIPAddressInformation address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool Contains(UnicastIPAddressInformation address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IEnumerator<UnicastIPAddressInformation> GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool Remove(UnicastIPAddressInformation address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Clear()
        {
             throw new NotImplementedException();
        }



        void ICollection<UnicastIPAddressInformation>.Add(UnicastIPAddressInformation item)
        {
            throw new NotImplementedException();
        }

        void ICollection<UnicastIPAddressInformation>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<UnicastIPAddressInformation>.Contains(UnicastIPAddressInformation item)
        {
            throw new NotImplementedException();
        }

        void ICollection<UnicastIPAddressInformation>.CopyTo(UnicastIPAddressInformation[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ICollection<UnicastIPAddressInformation>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<UnicastIPAddressInformation>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<UnicastIPAddressInformation>.Remove(UnicastIPAddressInformation item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<UnicastIPAddressInformation> IEnumerable<UnicastIPAddressInformation>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Collections.IEnumerator Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
