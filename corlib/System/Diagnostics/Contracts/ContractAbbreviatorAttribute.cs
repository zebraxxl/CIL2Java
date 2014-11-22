using System.Diagnostics;
using System;

namespace System.Diagnostics.Contracts
{
    /// <summary>Enables you to define abbreviations for contracts that can be used in place of the full contract syntax.</summary>
    [ConditionalAttribute("CONTRACTS_FULL")]
    [AttributeUsageAttribute(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class ContractAbbreviatorAttribute : Attribute
    {
        public ContractAbbreviatorAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
