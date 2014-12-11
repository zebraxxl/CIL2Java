using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Specifies the method to call when you register an assembly for use from COM; this enables the execution of user-written code during the registration process.</summary>
    [AttributeUsageAttribute(AttributeTargets.Method, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class ComRegisterFunctionAttribute : Attribute
    {
        public ComRegisterFunctionAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
