using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
    /// <summary>Specifies the name of a key container within the CSP containing the key pair used to generate a strong name.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class AssemblyKeyNameAttribute : Attribute
    {
    
        /// <summary>Gets the name of the container having the key pair that is used to generate a strong name for the attributed assembly.</summary><returns>A string containing the name of the container that has the relevant key pair.</returns>
        public string KeyName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyKeyNameAttribute" /> class with the name of the container holding the key pair used to generate a strong name for the assembly being attributed.</summary><param name="keyName">The name of the container containing the key pair. </param>
        public AssemblyKeyNameAttribute(string keyName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
