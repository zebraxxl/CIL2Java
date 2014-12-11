using System.Runtime.InteropServices;
using System;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting
{
    /// <summary>Holds values for an object type registered on the service end as one that can be activated on request from a client.</summary>
    [ComVisibleAttribute(true)]
    public class ActivatedServiceTypeEntry : TypeEntry
    {
    
        /// <summary>Gets the <see cref="T:System.Type" /> of the client-activated service type.</summary><returns>The <see cref="T:System.Type" /> of the client-activated service type.</returns>
        public Type ObjectType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the context attributes for the client-activated service type.</summary><returns>The context attributes for the client-activated service type.</returns>
        public IContextAttribute[] ContextAttributes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.ActivatedServiceTypeEntry" /> class with the given type name and assembly name.</summary><param name="typeName">The type name of the client-activated service type. </param><param name="assemblyName">The assembly name of the client-activated service type. </param>
        public ActivatedServiceTypeEntry(string typeName, string assemblyName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.ActivatedServiceTypeEntry" /> class with the given <see cref="T:System.Type" />.</summary><param name="type">The <see cref="T:System.Type" /> of the client-activated service type. </param>
        public ActivatedServiceTypeEntry(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
