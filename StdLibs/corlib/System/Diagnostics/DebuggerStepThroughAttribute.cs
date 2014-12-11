using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
    /// <summary>Instructs the debugger to step through the code instead of stepping into the code. This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class DebuggerStepThroughAttribute : Attribute
    {
        public DebuggerStepThroughAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
