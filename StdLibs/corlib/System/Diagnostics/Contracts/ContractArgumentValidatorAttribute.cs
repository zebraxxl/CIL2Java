using System.Diagnostics;
using System;

namespace System.Diagnostics.Contracts
{
    /// <summary>Enables the factoring of legacy if-then-throw code into separate methods for reuse, and provides full control over thrown exceptions and arguments.</summary>
    [ConditionalAttribute("CONTRACTS_FULL")]
    [AttributeUsageAttribute(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class ContractArgumentValidatorAttribute : Attribute
    {
        public ContractArgumentValidatorAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
