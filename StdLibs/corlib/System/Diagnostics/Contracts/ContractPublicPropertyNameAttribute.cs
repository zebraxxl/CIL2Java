using System.Diagnostics;
using System;

namespace System.Diagnostics.Contracts
{
    /// <summary>Specifies that a field can be used in method contracts when the field has less visibility than the method. </summary>
    [ConditionalAttribute("CONTRACTS_FULL")]
    [AttributeUsageAttribute(AttributeTargets.Field)]
    public sealed class ContractPublicPropertyNameAttribute : Attribute
    {
    
        /// <summary>Gets the property name to be applied to the field.</summary><returns>The property name to be applied to the field.</returns>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Contracts.ContractPublicPropertyNameAttribute" /> class. </summary><param name="name">The property name to apply to the field.</param>
        public ContractPublicPropertyNameAttribute(string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
