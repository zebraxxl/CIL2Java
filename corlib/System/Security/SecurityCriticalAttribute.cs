using System;

namespace System.Security
{
    /// <summary>Specifies that code or an assembly performs security-critical operations.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Field|AttributeTargets.Interface|AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
    public sealed class SecurityCriticalAttribute : Attribute
    {
    
        /// <summary>Gets the scope for the attribute.</summary><returns>One of the enumeration values that specifies the scope of the attribute. The default is <see cref="F:System.Security.SecurityCriticalScope.Explicit" />, which indicates that the attribute applies only to the immediate target.</returns>
        [ObsoleteAttribute("SecurityCriticalScope is only used for .NET 2.0 transparency compatibility.")]
        public SecurityCriticalScope Scope
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public SecurityCriticalAttribute()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityCriticalAttribute" /> class with the specified scope. </summary><param name="scope">One of the enumeration values that specifies the scope of the attribute. </param>
        public SecurityCriticalAttribute(SecurityCriticalScope scope)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
