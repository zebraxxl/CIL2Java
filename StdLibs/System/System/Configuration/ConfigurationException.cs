using System;
using System.Runtime.Serialization;
using System.Xml;

namespace System.Configuration
{
    [Serializable]
    public class ConfigurationException : SystemException
    {
    
        public override string Message
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string BareMessage
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string Filename
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual int Line
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected ConfigurationException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
        public ConfigurationException()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
        public ConfigurationException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
        public ConfigurationException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
        public ConfigurationException(string message, XmlNode node)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
        public ConfigurationException(string message, Exception inner, XmlNode node)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
        public ConfigurationException(string message, string filename, int line)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This class is obsolete, to create a new exception create a System.Configuration!System.Configuration.ConfigurationErrorsException")]
        public ConfigurationException(string message, Exception inner, string filename, int line)
        {
             throw new NotImplementedException();
        }
        
        
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This class is obsolete, use System.Configuration!System.Configuration.ConfigurationErrorsException.GetFilename instead")]
        public static string GetXmlNodeFilename(XmlNode node)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This class is obsolete, use System.Configuration!System.Configuration.ConfigurationErrorsException.GetLinenumber instead")]
        public static int GetXmlNodeLineNumber(XmlNode node)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
