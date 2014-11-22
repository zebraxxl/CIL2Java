using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
    /// <summary>Defines a trademark custom attribute for an assembly manifest.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class AssemblyTrademarkAttribute : Attribute
    {
    
        /// <summary>Gets trademark information.</summary><returns>A String containing trademark information.</returns>
        public string Trademark
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyTrademarkAttribute" /> class.</summary><param name="trademark">The trademark information. </param>
        public AssemblyTrademarkAttribute(string trademark)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
