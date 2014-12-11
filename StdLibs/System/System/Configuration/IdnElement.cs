using System;

namespace System.Configuration
{
    public sealed class IdnElement : ConfigurationElement
    {
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        //[ConfigurationPropertyAttribute("enabled", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public UriIdnScope Enabled
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public IdnElement()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
