using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
    /// <summary>Specifies the name of a file containing the key pair used to generate a strong name.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class AssemblyKeyFileAttribute : Attribute
    {
    
        /// <summary>Gets the name of the file containing the key pair used to generate a strong name for the attributed assembly.</summary><returns>A string containing the name of the file that contains the key pair.</returns>
        public string KeyFile
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the AssemblyKeyFileAttribute class with the name of the file containing the key pair to generate a strong name for the assembly being attributed.</summary><param name="keyFile">The name of the file containing the key pair. </param>
        public AssemblyKeyFileAttribute(string keyFile)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
