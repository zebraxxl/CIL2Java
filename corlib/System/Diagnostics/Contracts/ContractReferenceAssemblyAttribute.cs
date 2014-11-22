using System;

namespace System.Diagnostics.Contracts
{
    /// <summary>Specifies that an assembly is a reference assembly that contains contracts.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly)]
    public sealed class ContractReferenceAssemblyAttribute : Attribute
    {
        public ContractReferenceAssemblyAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
