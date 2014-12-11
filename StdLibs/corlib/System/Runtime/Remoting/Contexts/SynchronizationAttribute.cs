using System.Security;
using System;
using System.Runtime.InteropServices;
using System.Collections;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
    /// <summary>Enforces a synchronization domain for the current context and all contexts that share the same instance.</summary>
    [Serializable]
    [SecurityCriticalAttribute()]
    [AttributeUsageAttribute(AttributeTargets.Class)]
    [ComVisibleAttribute(true)]
    public class SynchronizationAttribute : ContextAttribute, IContributeServerContextSink, IContributeClientContextSink
    {
        /// <summary>Indicates that the class to which this attribute is applied cannot be created in a context that has synchronization. This field is constant.</summary>
        public const int NOT_SUPPORTED = 1;
        /// <summary>Indicates that the class to which this attribute is applied is not dependent on whether the context has synchronization. This field is constant.</summary>
        public const int SUPPORTED = 2;
        /// <summary>Indicates that the class to which this attribute is applied must be created in a context that has synchronization. This field is constant.</summary>
        public const int REQUIRED = 4;
        /// <summary>Indicates that the class to which this attribute is applied must be created in a context with a new instance of the synchronization property each time. This field is constant.</summary>
        public const int REQUIRES_NEW = 8;
    
        /// <summary>Gets or sets a Boolean value indicating whether the <see cref="T:System.Runtime.Remoting.Contexts.Context" /> implementing this instance of <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> is locked.</summary><returns>A Boolean value indicating whether the <see cref="T:System.Runtime.Remoting.Contexts.Context" /> implementing this instance of <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> is locked.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual bool Locked
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a Boolean value indicating whether reentry is required.</summary><returns>A Boolean value indicating whether reentry is required.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public virtual bool IsReEntrant
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SynchronizationAttribute()
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> class with a Boolean value indicating whether reentry is required.</summary><param name="reEntrant">A Boolean value indicating whether reentry is required. </param>
        public SynchronizationAttribute(bool reEntrant)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> class with a flag indicating the behavior of the object to which this attribute is applied.</summary><param name="flag">An integer value indicating the behavior of the object to which this attribute is applied. </param><exception cref="T:System.ArgumentException">The <paramref name="flag" /> parameter was not one of the defined flags. </exception>
        public SynchronizationAttribute(int flag)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> class with a flag indicating the behavior of the object to which this attribute is applied, and a Boolean value indicating whether reentry is required.</summary><param name="flag">An integer value indicating the behavior of the object to which this attribute is applied. </param><param name="reEntrant">true if reentry is required, and callouts must be intercepted and serialized; otherwise, false. </param><exception cref="T:System.ArgumentException">The <paramref name="flag" /> parameter was not one of the defined flags. </exception>
        public SynchronizationAttribute(int flag, bool reEntrant)
            : base(null)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a Boolean value indicating whether the context parameter meets the context attribute's requirements.</summary><returns>true if the passed in context is OK; otherwise, false.</returns><param name="ctx">The context to check. </param><param name="msg">Information gathered at construction time of the context bound object marked by this attribute. The <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> can inspect, add to, and remove properties from the context while determining if the context is acceptable to it. </param><exception cref="T:System.ArgumentNullException">The <paramref name="ctx" /> or <paramref name="msg" /> parameter is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public override bool IsContextOK(Context ctx, IConstructionCallMessage msg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds the Synchronized context property to the specified <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />.</summary><param name="ctorMsg">The <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" /> to which to add the property. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a synchronized dispatch sink and chains it in front of the provided chain of sinks at the context boundary on the server end of a remoting call.</summary><returns>The composite sink chain with the new synchronized dispatch sink.</returns><param name="nextSink">The chain of sinks composed so far. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual IMessageSink GetServerContextSink(IMessageSink nextSink)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a CallOut sink and chains it in front of the provided chain of sinks at the context boundary on the client end of a remoting call.</summary><returns>The composite sink chain with the new CallOut sink.</returns><param name="nextSink">The chain of sinks composed so far. </param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public virtual IMessageSink GetClientContextSink(IMessageSink nextSink)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
