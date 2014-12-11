using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Defines the out-of-band data for a call.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class Header
    {
        /// <summary>Contains the name of the <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</summary>
        public string Name;
        /// <summary>Contains the value for the <see cref="T:System.Runtime.Remoting.Messaging.Header" />.</summary>
        public object Value;
        /// <summary>Indicates whether the receiving end must understand the out-of-band data.</summary>
        public bool MustUnderstand;
        /// <summary>Indicates the XML namespace that the current <see cref="T:System.Runtime.Remoting.Messaging.Header" /> belongs to.</summary>
        public string HeaderNamespace;
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.Header" /> class with the given name and value.</summary><param name="_Name">The name of the <see cref="T:System.Runtime.Remoting.Messaging.Header" />. </param><param name="_Value">The object that contains the value for the <see cref="T:System.Runtime.Remoting.Messaging.Header" />. </param>
        public Header(string _Name, object _Value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.Header" /> class with the given name, value, and additional configuration information.</summary><param name="_Name">The name of the <see cref="T:System.Runtime.Remoting.Messaging.Header" />. </param><param name="_Value">The object that contains the value for the <see cref="T:System.Runtime.Remoting.Messaging.Header" />. </param><param name="_MustUnderstand">Indicates whether the receiving end must understand the out-of-band data. </param>
        public Header(string _Name, object _Value, bool _MustUnderstand)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.Header" /> class.</summary><param name="_Name">The name of the <see cref="T:System.Runtime.Remoting.Messaging.Header" />. </param><param name="_Value">The object that contains the value of the <see cref="T:System.Runtime.Remoting.Messaging.Header" />. </param><param name="_MustUnderstand">Indicates whether the receiving end must understand out-of-band data. </param><param name="_HeaderNamespace">The <see cref="T:System.Runtime.Remoting.Messaging.Header" /> XML namespace. </param>
        public Header(string _Name, object _Value, bool _MustUnderstand, string _HeaderNamespace)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
