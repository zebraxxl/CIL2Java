using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Allows you to obtain the method or property name of the caller to the method.</summary>
    [AttributeUsageAttribute(AttributeTargets.Parameter, Inherited = false)]
    public sealed class CallerMemberNameAttribute : Attribute
    {
        public CallerMemberNameAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
