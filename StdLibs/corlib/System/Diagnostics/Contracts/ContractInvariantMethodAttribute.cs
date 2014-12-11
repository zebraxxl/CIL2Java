using System.Diagnostics;
using System;

namespace System.Diagnostics.Contracts
{
    /// <summary>Marks a method as being the invariant method for a class.</summary>
    [ConditionalAttribute("CONTRACTS_FULL")]
    [AttributeUsageAttribute(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class ContractInvariantMethodAttribute : Attribute
    {
        public ContractInvariantMethodAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
