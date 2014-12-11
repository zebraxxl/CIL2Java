using System.Configuration;

namespace System.Net.Configuration
{
    public sealed class PerformanceCountersElement : ConfigurationElement
    {
    
        //[ConfigurationPropertyAttribute("enabled", DefaultValue = Mono.Cecil.CustomAttributeArgument)]
        public bool Enabled
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected override ConfigurationPropertyCollection Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public PerformanceCountersElement()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
