using System.Diagnostics;
using System;

namespace System.Diagnostics.Contracts
{
    /// <summary>Instructs analysis tools to assume the correctness of an assembly, type, or member without performing static verification.</summary>
    [ConditionalAttribute("CONTRACTS_FULL")]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Property)]
    public sealed class ContractVerificationAttribute : Attribute
    {
    
        /// <summary>Gets the value that indicates whether to verify the contract of the target. </summary><returns>true if verification is required; otherwise, false.</returns>
        public bool Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.Contracts.ContractVerificationAttribute" /> class. </summary><param name="value">true to require verification; otherwise, false. </param>
        public ContractVerificationAttribute(bool value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
