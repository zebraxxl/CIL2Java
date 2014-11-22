using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Identifies an assembly as a reference assembly, which contains metadata but no executable code.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly, AllowMultiple = false)]
    public sealed class ReferenceAssemblyAttribute : Attribute
    {
    
        /// <summary>Gets the description of the reference assembly.</summary><returns>The description of the reference assembly.</returns>
        public string Description
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ReferenceAssemblyAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.ReferenceAssemblyAttribute" /> class by using the specified description. </summary><param name="description">The description of the reference assembly. </param>
        public ReferenceAssemblyAttribute(string description)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
