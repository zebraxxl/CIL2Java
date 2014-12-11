using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class ConnectionManagementElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        [ConfigurationPropertyAttribute("address", IsRequired = true, IsKey = true)]
        public string Address
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("maxconnection", IsRequired = true, DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public int MaxConnection
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public ConnectionManagementElement()
        {
             throw new NotImplementedException();
        }
        
        
        public ConnectionManagementElement(string address, int maxConnection)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
