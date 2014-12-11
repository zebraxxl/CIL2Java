using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Instructs a compiler to use a specific version number for the Win32 file version resource. The Win32 file version is not required to be the same as the assembly's version number.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    public sealed class AssemblyFileVersionAttribute : Attribute
    {
    
        /// <summary>Gets the Win32 file version resource name.</summary><returns>A string containing the file version resource name.</returns>
        public string Version
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyFileVersionAttribute" /> class, specifying the file version.</summary><param name="version">The file version. </param><exception cref="T:System.ArgumentNullException"><paramref name="version" /> is null. </exception>
        public AssemblyFileVersionAttribute(string version)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
