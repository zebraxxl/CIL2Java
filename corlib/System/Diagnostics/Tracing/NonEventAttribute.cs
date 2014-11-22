using System;

namespace System.Diagnostics.Tracing
{
    /// <summary>Identifies a method that is not generating an event.</summary>
    [AttributeUsageAttribute(AttributeTargets.Method)]
    public sealed class NonEventAttribute : Attribute
    {
        public NonEventAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
