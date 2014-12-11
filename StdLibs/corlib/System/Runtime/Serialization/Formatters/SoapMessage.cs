using System.Runtime.InteropServices;
using System;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Serialization.Formatters
{
    /// <summary>Holds the names and types of parameters required during serialization of a SOAP RPC (Remote Procedure Call).</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class SoapMessage : ISoapMessage
    {
    
        /// <summary>Gets or sets the parameter names for the called method.</summary><returns>The parameter names for the called method.</returns>
        public string[] ParamNames
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the parameter values for the called method.</summary><returns>Parameter values for the called method.</returns>
        public object[] ParamValues
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>This property is reserved. Use the <see cref="P:System.Runtime.Serialization.Formatters.SoapMessage.ParamNames" /> and/or <see cref="P:System.Runtime.Serialization.Formatters.SoapMessage.ParamValues" /> properties instead.</summary><returns>Parameter types for the called method.</returns>
        public Type[] ParamTypes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name of the called method.</summary><returns>The name of the called method.</returns>
        public string MethodName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the XML namespace name where the object that contains the called method is located.</summary><returns>The XML namespace name where the object that contains the called method is located.</returns>
        public string XmlNameSpace
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the out-of-band data of the called method.</summary><returns>The out-of-band data of the called method.</returns>
        public Header[] Headers
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SoapMessage()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
