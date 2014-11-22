using System.Security;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System;
using System.Collections;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Implements the <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" /> interface to create a request message that constitutes a constructor call on a remote object.</summary>
    [Serializable]
    [SecurityCriticalAttribute()]
    [ComVisibleAttribute(true)]
    public class ConstructionCall : MethodCall, IConstructionCallMessage
    {
    
        /// <summary>Gets the call site activation attributes for the remote object. </summary><returns>An array of type <see cref="T:System.Object" /> containing the call site activation attributes for the remote object.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public object[] CallSiteActivationAttributes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type of the remote object to activate. </summary><returns>The <see cref="T:System.Type" /> of the remote object to activate.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public Type ActivationType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the full type name of the remote object to activate. </summary><returns>A <see cref="T:System.String" /> containing the full type name of the remote object to activate.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public string ActivationTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a list of properties that define the context in which the remote object is to be created. </summary><returns>A <see cref="T:System.Collections.IList" /> that contains a list of properties that define the context in which the remote object is to be created.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public IList ContextProperties
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties. </summary><returns>An <see cref="T:System.Collections.IDictionary" /> interface that represents a collection of the remoting message's properties.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public override IDictionary Properties
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the activator that activates the remote object. </summary><returns>The <see cref="T:System.Runtime.Remoting.Activation.IActivator" /> that activates the remote object.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public IActivator Activator
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.ConstructionCall" /> class from an array of remoting headers. </summary><param name="headers">An array of remoting headers that contain key-value pairs. This array is used to initialize <see cref="T:System.Runtime.Remoting.Messaging.ConstructionCall" /> fields for those headers that belong to the namespace "http://schemas.microsoft.com/clr/soap/messageProperties".</param>
        public ConstructionCall(Header[] headers)
            : base(headers)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.ConstructionCall" /> class by copying an existing message. </summary><param name="m">A remoting message.</param>
        public ConstructionCall(IMessage m)
            : base(m)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
