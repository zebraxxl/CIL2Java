using System.Xml;
using System.Configuration.Internal;

namespace System.Configuration
{
    public sealed class ConfigXmlDocument : XmlDocument, IConfigErrorInfo
    {
    
        public int LineNumber
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Filename
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public override void Load(string filename)
        {
             throw new NotImplementedException();
        }
        
        
        public void LoadSingleElement(string filename, XmlTextReader sourceReader)
        {
             throw new NotImplementedException();
        }
        
        
        public override XmlAttribute CreateAttribute(string prefix, string localName, string namespaceUri)
        {
             throw new NotImplementedException();
        }
        
        
        public override XmlElement CreateElement(string prefix, string localName, string namespaceUri)
        {
             throw new NotImplementedException();
        }
        
        
        public override XmlText CreateTextNode(string text)
        {
             throw new NotImplementedException();
        }
        
        
        public override XmlCDataSection CreateCDataSection(string data)
        {
             throw new NotImplementedException();
        }
        
        
        public override XmlComment CreateComment(string data)
        {
             throw new NotImplementedException();
        }
        
        
        public override XmlSignificantWhitespace CreateSignificantWhitespace(string data)
        {
             throw new NotImplementedException();
        }
        
        
        public override XmlWhitespace CreateWhitespace(string data)
        {
             throw new NotImplementedException();
        }
        
        
        public ConfigXmlDocument()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
