using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
    /// <summary>Indicates that a class should be treated as if it has global scope.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Class)]
    [ComVisibleAttribute(true)]
    public class CompilerGlobalScopeAttribute : Attribute
    {
        public CompilerGlobalScopeAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
