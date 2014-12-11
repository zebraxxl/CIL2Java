using System.Collections.Generic;

namespace System.Net.NetworkInformation
{
    public class IPAddressInformationCollection : ICollection<IPAddressInformation>, IEnumerable<IPAddressInformation>
    {
    
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual IPAddressInformation this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public virtual void CopyTo(IPAddressInformation[] array, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Add(IPAddressInformation address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool Contains(IPAddressInformation address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IEnumerator<IPAddressInformation> GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool Remove(IPAddressInformation address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Clear()
        {
             throw new NotImplementedException();
        }



        void ICollection<IPAddressInformation>.Add(IPAddressInformation item)
        {
            throw new NotImplementedException();
        }

        void ICollection<IPAddressInformation>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<IPAddressInformation>.Contains(IPAddressInformation item)
        {
            throw new NotImplementedException();
        }

        void ICollection<IPAddressInformation>.CopyTo(IPAddressInformation[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ICollection<IPAddressInformation>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<IPAddressInformation>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<IPAddressInformation>.Remove(IPAddressInformation item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<IPAddressInformation> IEnumerable<IPAddressInformation>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Collections.IEnumerator Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
