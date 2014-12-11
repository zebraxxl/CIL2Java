using System;
using System.Collections.Specialized;

namespace System.Configuration
{
    public sealed class ConfigurationSettings
    {
        [ObsoleteAttribute("This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.AppSettings")]
        public static NameValueCollection AppSettings
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [ObsoleteAttribute("This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.GetSection")]
        public static object GetConfig(string sectionName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
