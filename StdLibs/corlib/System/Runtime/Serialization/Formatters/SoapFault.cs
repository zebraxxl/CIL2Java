using System.Runtime.Remoting.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Runtime.Serialization.Formatters
{
    /// <summary>Carries error and status information within a SOAP message. This class cannot be inherited.</summary>
    [Serializable]
    [SoapTypeAttribute(Embedded = true)]
    [ComVisibleAttribute(true)]
    public sealed class SoapFault : ISerializable
    {
    
        /// <summary>Gets or sets the fault code for the <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</summary><returns>The fault code for this <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</returns>
        public string FaultCode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the fault message for the <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</summary><returns>The fault message for the <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</returns>
        public string FaultString
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the fault actor for the <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</summary><returns>The fault actor for the <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</returns>
        public string FaultActor
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets additional information required for the <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</summary><returns>Additional information required for the <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</returns>
        public object Detail
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public SoapFault()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" /> class, setting the properties to specified values.</summary><param name="faultCode">The fault code for the new instance of <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />. The fault code identifies the type of the fault that occurred. </param><param name="faultString">The fault string for the new instance of <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />. The fault string provides a human readable explanation of the fault. </param><param name="faultActor">The URI of the object that generated the fault. </param><param name="serverFault">The description of a common language runtime exception. This information is also present in the <see cref="P:System.Runtime.Serialization.Formatters.SoapFault.Detail" /> property. </param>
        public SoapFault(string faultCode, string faultString, string faultActor, ServerFault serverFault)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Populates the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data to serialize the <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" /> object.</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data. </param><param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext" />) for the current serialization. </param>
        [SecurityCriticalAttribute()]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
