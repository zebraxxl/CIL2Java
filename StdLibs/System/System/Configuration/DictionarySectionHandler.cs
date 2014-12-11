using System.Xml;

namespace System.Configuration
{
    public class DictionarySectionHandler : IConfigurationSectionHandler
    {
        protected virtual string KeyAttributeName
        {
            get { throw new NotImplementedException(); }
        }
    
        protected virtual string ValueAttributeName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public virtual object Create(object parent, object context, XmlNode section)
        {
             throw new NotImplementedException();
        }
        
        
        public DictionarySectionHandler()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
