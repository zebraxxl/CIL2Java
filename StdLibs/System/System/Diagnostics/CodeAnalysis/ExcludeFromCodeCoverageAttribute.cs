using System;

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Property|AttributeTargets.Event, Inherited = false, AllowMultiple = false)]
    public sealed class ExcludeFromCodeCoverageAttribute : Attribute
    {
        public ExcludeFromCodeCoverageAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
