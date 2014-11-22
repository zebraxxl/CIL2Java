using System;

namespace System.Runtime.ConstrainedExecution
{
    /// <summary>Defines a contract for reliability between the author of some code, and the developers who have a dependency on that code.</summary>
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method|AttributeTargets.Interface, Inherited = false)]
    public sealed class ReliabilityContractAttribute : Attribute
    {
    
        /// <summary>Gets the value of the <see cref="T:System.Runtime.ConstrainedExecution.Consistency" /> reliability contract. </summary><returns>One of the <see cref="T:System.Runtime.ConstrainedExecution.Consistency" /> values.</returns>
        public Consistency ConsistencyGuarantee
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the value that determines the behavior of a method, type, or assembly when called under a Constrained Execution Region (CER). </summary><returns>One of the <see cref="T:System.Runtime.ConstrainedExecution.Cer" /> values.</returns>
        public Cer Cer
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.ConstrainedExecution.ReliabilityContractAttribute" /> class with the specified <see cref="T:System.Runtime.ConstrainedExecution.Consistency" /> guarantee and <see cref="T:System.Runtime.ConstrainedExecution.Cer" /> value.</summary><param name="consistencyGuarantee">One of the <see cref="T:System.Runtime.ConstrainedExecution.Consistency" /> values. </param><param name="cer">One of the <see cref="T:System.Runtime.ConstrainedExecution.Cer" /> values. </param>
        public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
