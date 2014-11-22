using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
    /// <summary>Indicates the code following the attribute is to be executed in run, not step, mode.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Constructor|AttributeTargets.Method, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class DebuggerStepperBoundaryAttribute : Attribute
    {
        public DebuggerStepperBoundaryAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
