using System;

namespace System.Security
{
    /// <summary>Identifies which of the nonpublic <see cref="T:System.Security.SecurityCriticalAttribute" /> members are accessible by transparent code within the assembly. </summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Field|AttributeTargets.Interface|AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
    [ObsoleteAttribute("SecurityTreatAsSafe is only used for .NET 2.0 transparency compatibility.  Please use the SecuritySafeCriticalAttribute instead.")]
    public sealed class SecurityTreatAsSafeAttribute : Attribute
    {
        public SecurityTreatAsSafeAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
