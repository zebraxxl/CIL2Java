using System;

namespace System.Runtime.ConstrainedExecution
{
    /// <summary>Instructs the native image generation service to prepare a method for inclusion in a constrained execution region (CER).</summary>
    [AttributeUsageAttribute(AttributeTargets.Constructor|AttributeTargets.Method, Inherited = false)]
    public sealed class PrePrepareMethodAttribute : Attribute
    {
        public PrePrepareMethodAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
