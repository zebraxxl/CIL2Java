using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Indicates whether a program element is compliant with the Common Language Specification (CLS). This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    [ComVisibleAttribute(true)]
    public sealed class CLSCompliantAttribute : Attribute
    {
    
        /// <summary>Gets the Boolean value indicating whether the indicated program element is CLS-compliant.</summary><returns>true if the program element is CLS-compliant; otherwise, false.</returns><filterpriority>2</filterpriority>
        public bool IsCompliant
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes an instance of the <see cref="T:System.CLSCompliantAttribute" /> class with a Boolean value indicating whether the indicated program element is CLS-compliant.</summary><param name="isCompliant">true if CLS-compliant; otherwise, false. </param>
        public CLSCompliantAttribute(bool isCompliant)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
