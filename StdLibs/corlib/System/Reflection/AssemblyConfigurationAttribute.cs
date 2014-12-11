using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
    /// <summary>Specifies the build configuration, such as retail or debug, for an assembly.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class AssemblyConfigurationAttribute : Attribute
    {
    
        /// <summary>Gets assembly configuration information.</summary><returns>A string containing the assembly configuration information.</returns>
        public string Configuration
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyConfigurationAttribute" /> class.</summary><param name="configuration">The assembly configuration. </param>
        public AssemblyConfigurationAttribute(string configuration)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
