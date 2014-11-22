using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
    /// <summary>Identifies a type or member that is not part of the user code for an application.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Property, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class DebuggerNonUserCodeAttribute : Attribute
    {
        public DebuggerNonUserCodeAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
