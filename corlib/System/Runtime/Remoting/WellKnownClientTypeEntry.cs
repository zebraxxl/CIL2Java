using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Remoting
{
    /// <summary>Holds values for an object type registered on the client as a server-activated type (single call or singleton).</summary>
    [ComVisibleAttribute(true)]
    public class WellKnownClientTypeEntry : TypeEntry
    {
    
        /// <summary>Gets the URL of the server-activated client object.</summary><returns>The URL of the server-activated client object.</returns>
        public string ObjectUrl
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the <see cref="T:System.Type" /> of the server-activated client type.</summary><returns>Gets the <see cref="T:System.Type" /> of the server-activated client type.</returns>
        public Type ObjectType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the URL of the application to activate the type in.</summary><returns>The URL of the application to activate the type in.</returns>
        public string ApplicationUrl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> class with the given type, assembly name, and URL.</summary><param name="typeName">The type name of the server-activated type. </param><param name="assemblyName">The assembly name of the server-activated type. </param><param name="objectUrl">The URL of the server-activated type. </param>
        public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> class with the given type and URL.</summary><param name="type">The <see cref="T:System.Type" /> of the server-activated type. </param><param name="objectUrl">The URL of the server-activated type. </param>
        public WellKnownClientTypeEntry(Type type, string objectUrl)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
