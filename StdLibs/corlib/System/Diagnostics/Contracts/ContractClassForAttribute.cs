using System;
using System.Diagnostics;

namespace System.Diagnostics.Contracts
{
    /// <summary>Specifies that a class is a contract for a type.</summary>
    [AttributeUsageAttribute(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [ConditionalAttribute("CONTRACTS_FULL")]
    public sealed class ContractClassForAttribute : Attribute
    {
    
        /// <summary>Gets the type that this code contract applies to. </summary><returns>The type that this contract applies to.</returns>
        public Type TypeContractsAreFor
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Contracts.ContractClassForAttribute" /> class, specifying the type the current class is a contract for. </summary><param name="typeContractsAreFor">The type the current class is a contract for.</param>
        public ContractClassForAttribute(Type typeContractsAreFor)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
