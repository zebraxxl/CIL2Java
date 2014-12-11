using System;

namespace System.Runtime.ConstrainedExecution
{
    /// <summary>Specifies a method's behavior when called within a constrained execution region.</summary>
    [Serializable]
    public enum Cer : int
    {
        /// <summary>The method, type, or assembly has no concept of a CER. It does not take advantage of CER guarantees. This implies the following:</summary>
        None = 0,
        /// <summary>In the face of exceptional conditions, the method might fail. In this case, the method will report back to the calling method whether it succeeded or failed. The method must have a CER around the method body to ensure that it can report the return value.</summary>
        MayFail = 1,
        /// <summary>In the face of exceptional conditions, the method is guaranteed to succeed. You should always construct a CER around the method that is called, even when it is called from within a non-CER region. A method is successful if it accomplishes what is intended. For example, marking <see cref="P:System.Collections.ArrayList.Count" /> with ReliabilityContractAttribute(Cer.Success) implies that when it is run under a CER, it always returns a count of the number of elements in the <see cref="T:System.Collections.ArrayList" /> and it can never leave the internal fields in an undetermined state.</summary>
        Success = 2
    }
}
