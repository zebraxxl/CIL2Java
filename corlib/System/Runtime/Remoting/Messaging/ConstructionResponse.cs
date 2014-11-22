using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Remoting.Activation;
using System.Collections;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Implements the <see cref="T:System.Runtime.Remoting.Activation.IConstructionReturnMessage" /> interface to create a message that responds to a call to instantiate a remote object.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [SecurityCriticalAttribute()]
    public class ConstructionResponse : MethodResponse, IConstructionReturnMessage
    {
        /// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary><returns>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public override IDictionary Properties
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.ConstructionResponse" /> class from an array of remoting headers and a request message.</summary><param name="h">An array of remoting headers that contain key-value pairs. This array is used to initialize <see cref="T:System.Runtime.Remoting.Messaging.ConstructionResponse" /> fields for those headers that belong to the namespace "http://schemas.microsoft.com/clr/soap/messageProperties".</param><param name="mcm">A request message that constitutes a constructor call on a remote object.</param>
        public ConstructionResponse(Header[] h, IMethodCallMessage mcm)
            : base(h, mcm)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
