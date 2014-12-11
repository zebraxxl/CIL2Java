using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
    /// <summary>Specifies the display proxy for a type.</summary><filterpriority>1</filterpriority>
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct, AllowMultiple = true)]
    [ComVisibleAttribute(true)]
    public sealed class DebuggerTypeProxyAttribute : Attribute
    {
    
        /// <summary>Gets the type name of the proxy type. </summary><returns>The type name of the proxy type.</returns><filterpriority>2</filterpriority>
        public string ProxyTypeName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the target type for the attribute.</summary><returns>The target type for the attribute.</returns><exception cref="T:System.ArgumentNullException"><see cref="P:System.Diagnostics.DebuggerTypeProxyAttribute.Target" /> is set to null.</exception><filterpriority>2</filterpriority>
        public Type Target
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the name of the target type.</summary><returns>The name of the target type.</returns><filterpriority>2</filterpriority>
        public string TargetTypeName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerTypeProxyAttribute" /> class using the type of the proxy. </summary><param name="type">The proxy type.</param><exception cref="T:System.ArgumentNullException"><paramref name="type" /> is null.</exception>
        public DebuggerTypeProxyAttribute(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerTypeProxyAttribute" /> class using the type name of the proxy. </summary><param name="typeName">The type name of the proxy type.</param>
        public DebuggerTypeProxyAttribute(string typeName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
