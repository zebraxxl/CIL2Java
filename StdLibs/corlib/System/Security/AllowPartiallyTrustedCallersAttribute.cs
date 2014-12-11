using System.Runtime.InteropServices;
using System;

namespace System.Security
{
    /// <summary>Allows an assembly to be called by partially trusted code. Without this declaration, only fully trusted callers are able to use the assembly. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    public sealed class AllowPartiallyTrustedCallersAttribute : Attribute
    {
    
        /// <summary>Gets or sets the default partial trust visibility for code that is marked with the <see cref="T:System.Security.AllowPartiallyTrustedCallersAttribute" /> (APTCA) attribute.</summary><returns>One of the enumeration values. The default is <see cref="F:System.Security.PartialTrustVisibilityLevel.VisibleToAllHosts" />. </returns>
        public PartialTrustVisibilityLevel PartialTrustVisibilityLevel
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public AllowPartiallyTrustedCallersAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
