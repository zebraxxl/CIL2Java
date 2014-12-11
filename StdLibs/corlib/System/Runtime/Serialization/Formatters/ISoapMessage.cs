using System.Runtime.InteropServices;
using System;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Serialization.Formatters
{
    /// <summary>Provides an interface for an object that contains the names and types of parameters required during serialization of a SOAP RPC (Remote Procedure Call).</summary>
    [ComVisibleAttribute(true)]
    public interface ISoapMessage
    {
        /// <summary>Gets or sets the parameter names of the method call.</summary><returns>The parameter names of the method call.</returns>
        string[] ParamNames
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the parameter values of a method call.</summary><returns>The parameter values of a method call.</returns>
        object[] ParamValues
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the parameter types of a method call.</summary><returns>The parameter types of a method call.</returns>
        Type[] ParamTypes
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the name of the called method.</summary><returns>The name of the called method.</returns>
        string MethodName
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the XML namespace of the SOAP RPC (Remote Procedure Call) <see cref="P:System.Runtime.Serialization.Formatters.ISoapMessage.MethodName" /> element.</summary><returns>The XML namespace name where the object that contains the called method is located.</returns>
        string XmlNameSpace
        {
            get;
            set;
        }
    
        /// <summary>Gets or sets the out-of-band data of the method call.</summary><returns>The out-of-band data of the method call.</returns>
        Header[] Headers
        {
            get;
            set;
        }
    
    
    }
}
