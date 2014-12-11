using System.Xml;

namespace System.Configuration
{
    public class NameValueSectionHandler : IConfigurationSectionHandler
    {
    
        protected virtual string KeyAttributeName
        {
            get { throw new NotImplementedException(); }
        }
    
        protected virtual string ValueAttributeName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public object Create(object parent, object context, XmlNode section)
        {
             throw new NotImplementedException();
        }
        
        
        public NameValueSectionHandler()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
