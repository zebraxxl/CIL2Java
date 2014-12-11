using System.Configuration;
using System.Net.Sockets;

namespace System.Net.Configuration
{
    public sealed class SocketElement : ConfigurationElement
    {
    
        //[ConfigurationPropertyAttribute("alwaysUseCompletionPortsForAccept", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool AlwaysUseCompletionPortsForAccept
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("alwaysUseCompletionPortsForConnect", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool AlwaysUseCompletionPortsForConnect
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("ipProtectionLevel", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public IPProtectionLevel IPProtectionLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SocketElement()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void PostDeserialize()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
