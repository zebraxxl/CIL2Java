using System.Runtime.InteropServices;
using System;
using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting
{
    /// <summary>Holds values for an object type registered on the client end as a type that can be activated on the server.</summary>
    [ComVisibleAttribute(true)]
    public class ActivatedClientTypeEntry : TypeEntry
    {
    
        /// <summary>Gets the URL of the application to activate the type in.</summary><returns>The URL of the application to activate the type in.</returns>
        public string ApplicationUrl
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Type" /> of the client-activated type.</summary><returns>Gets the <see cref="T:System.Type" /> of the client-activated type.</returns>
        public Type ObjectType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the context attributes for the client-activated type.</summary><returns>The context attributes for the client activated type.</returns>
        public IContextAttribute[] ContextAttributes
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> class with the given type name, assembly name, and application URL.</summary><param name="typeName">The type name of the client activated type. </param><param name="assemblyName">The assembly name of the client activated type. </param><param name="appUrl">The URL of the application to activate the type in. </param>
        public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> class with the given <see cref="T:System.Type" /> and application URL.</summary><param name="type">The <see cref="T:System.Type" /> of the client activated type. </param><param name="appUrl">The URL of the application to activate the type in. </param>
        public ActivatedClientTypeEntry(Type type, string appUrl)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
