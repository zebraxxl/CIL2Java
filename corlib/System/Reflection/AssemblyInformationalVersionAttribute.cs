using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Defines additional version information for an assembly manifest.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    public sealed class AssemblyInformationalVersionAttribute : Attribute
    {
    
        /// <summary>Gets version information.</summary><returns>A string containing the version information.</returns>
        public string InformationalVersion
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyInformationalVersionAttribute" /> class.</summary><param name="informationalVersion">The assembly version information. </param>
        public AssemblyInformationalVersionAttribute(string informationalVersion)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
