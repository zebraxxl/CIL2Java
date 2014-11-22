using System.Runtime.InteropServices;
using System;
using System.Configuration.Assemblies;

namespace System.Reflection
{
    /// <summary>Specifies an algorithm to hash all files in an assembly. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    public sealed class AssemblyAlgorithmIdAttribute : Attribute
    {
    
        /// <summary>Gets the hash algorithm of an assembly manifest's contents.</summary><returns>An unsigned integer representing the assembly hash algorithm.</returns>
        public uint AlgorithmId
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyAlgorithmIdAttribute" /> class with the specified hash algorithm, using one of the members of <see cref="T:System.Configuration.Assemblies.AssemblyHashAlgorithm" /> to represent the hash algorithm.</summary><param name="algorithmId">A member of AssemblyHashAlgorithm that represents the hash algorithm. </param>
        public AssemblyAlgorithmIdAttribute(AssemblyHashAlgorithm algorithmId)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyAlgorithmIdAttribute" /> class with the specified hash algorithm, using an unsigned integer to represent the hash algorithm.</summary><param name="algorithmId">An unsigned integer representing the hash algorithm. </param>
        public AssemblyAlgorithmIdAttribute(uint algorithmId)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
