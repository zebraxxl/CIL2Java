using System.Runtime.InteropServices;
using System;

namespace System.Configuration.Assemblies
{
    /// <summary>Represents a hash of an assembly manifest's contents.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [ObsoleteAttribute("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
    public struct AssemblyHash : ICloneable
    {
        /// <summary>An empty <see cref="T:System.Configuration.Assemblies.AssemblyHash" /> object.</summary>
        [ObsoleteAttribute("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static readonly AssemblyHash Empty;
    
        /// <summary>Gets or sets the hash algorithm.</summary><returns>An assembly hash algorithm.</returns>
        [ObsoleteAttribute("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
        public AssemblyHashAlgorithm Algorithm
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Configuration.Assemblies.AssemblyHash" /> structure with the specified hash value. The hash algorithm defaults to <see cref="F:System.Configuration.Assemblies.AssemblyHashAlgorithm.SHA1" />.</summary><param name="value">The hash value. </param>
        [ObsoleteAttribute("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
        public AssemblyHash(byte[] value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Configuration.Assemblies.AssemblyHash" /> structure with the specified hash algorithm and the hash value.</summary><param name="algorithm">The algorithm used to generate the hash. Values for this parameter come from the <see cref="T:System.Configuration.Assemblies.AssemblyHashAlgorithm" /> enumeration. </param><param name="value">The hash value. </param>
        [ObsoleteAttribute("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
        public AssemblyHash(AssemblyHashAlgorithm algorithm, byte[] value)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
        public byte[] GetValue()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the hash value.</summary><param name="value">The hash value. </param>
        [ObsoleteAttribute("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void SetValue(byte[] value)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The AssemblyHash class has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
        public object Clone()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
