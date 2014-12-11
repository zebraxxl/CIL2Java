using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
    /// <summary>Specifies a bitwise combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags for an assembly, describing just-in-time (JIT) compiler options, whether the assembly is retargetable, and whether it has a full or tokenized public key. This class cannot be inherited.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class AssemblyFlagsAttribute : Attribute
    {
    
        /// <summary>Gets an unsigned integer value representing the combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags specified when this attribute instance was created.</summary><returns>An unsigned integer value representing a bitwise combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags.</returns>
        [ObsoleteAttribute("This property has been deprecated. Please use AssemblyFlags instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public uint Flags
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets an integer value representing the combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags specified when this attribute instance was created.</summary><returns>An integer value representing a bitwise combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags.</returns>
        public int AssemblyFlags
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyFlagsAttribute" /> class with the specified combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags, cast as an unsigned integer value.</summary><param name="flags">A bitwise combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags, cast as an unsigned integer value, representing just-in-time (JIT) compiler options, longevity, whether an assembly is retargetable, and whether it has a full or tokenized public key.</param>
        [ObsoleteAttribute("This constructor has been deprecated. Please use AssemblyFlagsAttribute(AssemblyNameFlags) instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public AssemblyFlagsAttribute(uint flags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyFlagsAttribute" /> class with the specified combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags, cast as an integer value.</summary><param name="assemblyFlags">A bitwise combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags, cast as an integer value, representing just-in-time (JIT) compiler options, longevity, whether an assembly is retargetable, and whether it has a full or tokenized public key.</param>
        [ObsoleteAttribute("This constructor has been deprecated. Please use AssemblyFlagsAttribute(AssemblyNameFlags) instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public AssemblyFlagsAttribute(int assemblyFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyFlagsAttribute" /> class with the specified combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags.</summary><param name="assemblyFlags">A bitwise combination of <see cref="T:System.Reflection.AssemblyNameFlags" /> flags representing just-in-time (JIT) compiler options, longevity, whether an assembly is retargetable, and whether it has a full or tokenized public key.</param>
        public AssemblyFlagsAttribute(AssemblyNameFlags assemblyFlags)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
