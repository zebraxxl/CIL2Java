using System;
using System.Runtime.InteropServices;

namespace System.Resources
{
    /// <summary>Informs the resource manager of an app's default culture. This class cannot be inherited.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly, AllowMultiple = false)]
    [ComVisibleAttribute(true)]
    public sealed class NeutralResourcesLanguageAttribute : Attribute
    {
    
        /// <summary>Gets the culture name.</summary><returns>The name of the default culture for the main assembly.</returns>
        public string CultureName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the location for the <see cref="T:System.Resources.ResourceManager" /> class to use to retrieve neutral resources by using the resource fallback process.</summary><returns>One of the enumeration values that indicates the location (main assembly or satellite) from which to retrieve neutral resources.</returns>
        public UltimateResourceFallbackLocation Location
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.NeutralResourcesLanguageAttribute" /> class.</summary><param name="cultureName">The name of the culture that the current assembly's neutral resources were written in. </param><exception cref="T:System.ArgumentNullException">The <paramref name="cultureName" /> parameter is null. </exception>
        public NeutralResourcesLanguageAttribute(string cultureName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.NeutralResourcesLanguageAttribute" /> class with the specified ultimate resource fallback location.</summary><param name="cultureName">The name of the culture that the current assembly's neutral resources were written in.</param><param name="location">One of the enumeration values that indicates the location from which to retrieve neutral fallback resources.</param><exception cref="T:System.ArgumentNullException"><paramref name="cultureName" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="location" /> is not a member of <see cref="T:System.Resources.UltimateResourceFallbackLocation" />.</exception>
        public NeutralResourcesLanguageAttribute(string cultureName, UltimateResourceFallbackLocation location)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
