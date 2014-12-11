using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
    /// <summary>Defines a product name custom attribute for an assembly manifest.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class AssemblyProductAttribute : Attribute
    {
    
        /// <summary>Gets product name information.</summary><returns>A string containing the product name.</returns>
        public string Product
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyProductAttribute" /> class.</summary><param name="product">The product name information. </param>
        public AssemblyProductAttribute(string product)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
