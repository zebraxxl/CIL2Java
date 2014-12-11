
namespace System.Net.NetworkInformation
{
    public abstract class IPv6InterfaceProperties
    {
        public abstract int Index
        {
            get;
        }
    
        public abstract int Mtu
        {
            get;
        }
    
    
        public virtual long GetScopeId(ScopeLevel scopeLevel)
        {
             throw new NotImplementedException();
        }
        
        
        protected IPv6InterfaceProperties()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
