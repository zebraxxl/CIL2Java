using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
    /// <summary>Specifies that the assembly is not fully signed when created.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class AssemblyDelaySignAttribute : Attribute
    {
    
        /// <summary>Gets a value indicating the state of the attribute.</summary><returns>true if this assembly has been built as delay-signed; otherwise, false.</returns>
        public bool DelaySign
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyDelaySignAttribute" /> class.</summary><param name="delaySign">true if the feature this attribute represents is activated; otherwise, false. </param>
        public AssemblyDelaySignAttribute(bool delaySign)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
