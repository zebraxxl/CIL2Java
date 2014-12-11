using System.Runtime.InteropServices;
using System;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting
{
    /// <summary>Holds values for an object type registered on the service end as a server-activated type object (single call or singleton).</summary>
    [ComVisibleAttribute(true)]
    public class WellKnownServiceTypeEntry : TypeEntry
    {
    
        /// <summary>Gets the URI of the well-known service type.</summary><returns>The URI of the server-activated service type.</returns>
        public string ObjectUri
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the server-activated service type.</summary><returns>The <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the server-activated service type.</returns>
        public WellKnownObjectMode Mode
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Type" /> of the server-activated service type.</summary><returns>The <see cref="T:System.Type" /> of the server-activated service type.</returns>
        public Type ObjectType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the context attributes for the server-activated service type.</summary><returns>Gets or sets the context attributes for the server-activated service type.</returns>
        public IContextAttribute[] ContextAttributes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.WellKnownServiceTypeEntry" /> class with the given type name, assembly name, object URI, and <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" />.</summary><param name="typeName">The full type name of the server-activated service type. </param><param name="assemblyName">The assembly name of the server-activated service type. </param><param name="objectUri">The URI of the server-activated object. </param><param name="mode">The <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the type, which defines how the object is activated. </param>
        public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.WellKnownServiceTypeEntry" /> class with the given <see cref="T:System.Type" />, object URI, and <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" />.</summary><param name="type">The <see cref="T:System.Type" /> of the server-activated service type object. </param><param name="objectUri">The URI of the server-activated type. </param><param name="mode">The <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the type, which defines how the object is activated. </param>
        public WellKnownServiceTypeEntry(Type type, string objectUri, WellKnownObjectMode mode)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
