using System;
using System.Runtime.InteropServices;

namespace System.Security
{
    /// <summary>Marks modules containing unverifiable code. This class cannot be inherited.</summary>
    [AttributeUsageAttribute(AttributeTargets.Module, AllowMultiple = true, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class UnverifiableCodeAttribute : Attribute
    {
        public UnverifiableCodeAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
