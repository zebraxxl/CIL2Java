using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Specifies the version of the assembly being attributed.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    public sealed class AssemblyVersionAttribute : Attribute
    {
    
        /// <summary>Gets the version number of the attributed assembly.</summary><returns>A string containing the assembly version number.</returns>
        public string Version
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the AssemblyVersionAttribute class with the version number of the assembly being attributed.</summary><param name="version">The version number of the attributed assembly. </param>
        public AssemblyVersionAttribute(string version)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
