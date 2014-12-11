using System.Runtime.InteropServices;
using System;

namespace System.Diagnostics
{
    /// <summary>Specifies the <see cref="T:System.Diagnostics.DebuggerHiddenAttribute" />. This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Property, Inherited = false)]
    public sealed class DebuggerHiddenAttribute : Attribute
    {
        public DebuggerHiddenAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
