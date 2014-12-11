using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Indicates that a type or member is treated in a special way by the runtime or tools.  This class cannot be inherited.</summary>
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Method|AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Event)]
    public sealed class SpecialNameAttribute : Attribute
    {
        public SpecialNameAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
