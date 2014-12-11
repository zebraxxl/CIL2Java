using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Specifies the method to call when you unregister an assembly for use from COM; this allows for the execution of user-written code during the unregistration process.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Method, Inherited = false)]
    public sealed class ComUnregisterFunctionAttribute : Attribute
    {
        public ComUnregisterFunctionAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
