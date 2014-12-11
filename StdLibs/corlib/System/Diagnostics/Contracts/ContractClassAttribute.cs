using System;
using System.Diagnostics;

namespace System.Diagnostics.Contracts
{
    /// <summary>Specifies that a separate type contains the code contracts for this type.</summary>
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Interface|AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
    [ConditionalAttribute("CONTRACTS_FULL")]
    [ConditionalAttribute("DEBUG")]
    public sealed class ContractClassAttribute : Attribute
    {
    
        /// <summary>Gets the type that contains the code contracts for this type.</summary><returns>The type that contains the code contracts for this type. </returns>
        public Type TypeContainingContracts
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Contracts.ContractClassAttribute" /> class. </summary><param name="typeContainingContracts">The type that contains the code contracts for this type.</param>
        public ContractClassAttribute(Type typeContainingContracts)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
