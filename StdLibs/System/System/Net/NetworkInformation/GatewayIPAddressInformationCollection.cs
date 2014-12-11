using System.Collections.Generic;

namespace System.Net.NetworkInformation
{
    public class GatewayIPAddressInformationCollection : ICollection<GatewayIPAddressInformation>, IEnumerable<GatewayIPAddressInformation>
    {
    
        public virtual int Count
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual GatewayIPAddressInformation this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected GatewayIPAddressInformationCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void CopyTo(GatewayIPAddressInformation[] array, int offset)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Add(GatewayIPAddressInformation address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool Contains(GatewayIPAddressInformation address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IEnumerator<GatewayIPAddressInformation> GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool Remove(GatewayIPAddressInformation address)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Clear()
        {
             throw new NotImplementedException();
        }



        void ICollection<GatewayIPAddressInformation>.Add(GatewayIPAddressInformation item)
        {
            throw new NotImplementedException();
        }

        void ICollection<GatewayIPAddressInformation>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<GatewayIPAddressInformation>.Contains(GatewayIPAddressInformation item)
        {
            throw new NotImplementedException();
        }

        void ICollection<GatewayIPAddressInformation>.CopyTo(GatewayIPAddressInformation[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ICollection<GatewayIPAddressInformation>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<GatewayIPAddressInformation>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<GatewayIPAddressInformation>.Remove(GatewayIPAddressInformation item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<GatewayIPAddressInformation> IEnumerable<GatewayIPAddressInformation>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Collections.IEnumerator Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
