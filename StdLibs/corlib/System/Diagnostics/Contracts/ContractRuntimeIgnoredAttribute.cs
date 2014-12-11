using System.Diagnostics;
using System;

namespace System.Diagnostics.Contracts
{
    /// <summary>Identifies a member that has no run-time behavior.</summary>
    [ConditionalAttribute("CONTRACTS_FULL")]
    [AttributeUsageAttribute(AttributeTargets.Method|AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class ContractRuntimeIgnoredAttribute : Attribute
    {
        public ContractRuntimeIgnoredAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
