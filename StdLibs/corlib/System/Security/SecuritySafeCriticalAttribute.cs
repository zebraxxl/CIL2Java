using System;

namespace System.Security
{
    /// <summary>Identifies types or members as security-critical and safely accessible by transparent code.</summary>
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Field|AttributeTargets.Interface|AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
    public sealed class SecuritySafeCriticalAttribute : Attribute
    {
        public SecuritySafeCriticalAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
