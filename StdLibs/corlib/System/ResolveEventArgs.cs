using System.Runtime.InteropServices;
using System.Reflection;

namespace System
{
    /// <summary>Provides data for loader resolution events, such as the <see cref="E:System.AppDomain.TypeResolve" />, <see cref="E:System.AppDomain.ResourceResolve" />, <see cref="E:System.AppDomain.ReflectionOnlyAssemblyResolve" />, and <see cref="E:System.AppDomain.AssemblyResolve" /> events.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public class ResolveEventArgs : EventArgs
    {
    
        /// <summary>Gets the name of the item to resolve.</summary><returns>The name of the item to resolve.</returns><filterpriority>2</filterpriority>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the assembly whose dependency is being resolved.</summary><returns>The assembly that requested the item specified by the <see cref="P:System.ResolveEventArgs.Name" /> property.</returns>
        public Assembly RequestingAssembly
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.ResolveEventArgs" /> class, specifying the name of the item to resolve.</summary><param name="name">The name of an item to resolve. </param>
        public ResolveEventArgs(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.ResolveEventArgs" /> class, specifying the name of the item to resolve and the assembly whose dependency is being resolved.</summary><param name="name">The name of an item to resolve. </param><param name="requestingAssembly">The assembly whose dependency is being resolved.</param>
        public ResolveEventArgs(string name, Assembly requestingAssembly)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
