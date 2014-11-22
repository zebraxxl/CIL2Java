using System;
using System.Runtime.InteropServices;

namespace System.Resources
{
    /// <summary>Instructs a <see cref="T:System.Resources.ResourceManager" /> object to ask for a particular version of a satellite assembly.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, AllowMultiple = false)]
    [ComVisibleAttribute(true)]
    public sealed class SatelliteContractVersionAttribute : Attribute
    {
    
        /// <summary>Gets the version of the satellite assemblies with the required resources.</summary><returns>A string that contains the version of the satellite assemblies with the required resources.</returns>
        public string Version
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.SatelliteContractVersionAttribute" /> class.</summary><param name="version">A string that specifies the version of the satellite assemblies to load. </param><exception cref="T:System.ArgumentNullException">The <paramref name="version" /> parameter is null. </exception>
        public SatelliteContractVersionAttribute(string version)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
