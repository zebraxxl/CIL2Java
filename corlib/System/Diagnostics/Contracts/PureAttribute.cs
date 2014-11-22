using System;
using System.Diagnostics;

namespace System.Diagnostics.Contracts
{
    /// <summary>Indicates that a type or method is pure, that is, it does not make any visible state changes.</summary>
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Property|AttributeTargets.Event|AttributeTargets.Parameter|AttributeTargets.Delegate, AllowMultiple = false, Inherited = true)]
    [ConditionalAttribute("CONTRACTS_FULL")]
    public sealed class PureAttribute : Attribute
    {
        public PureAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
