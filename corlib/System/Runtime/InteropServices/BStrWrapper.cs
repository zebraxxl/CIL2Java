using System.Security;

namespace System.Runtime.InteropServices
{
    /// <summary>Marshals data of type VT_BSTR from managed to unmanaged code. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class BStrWrapper
    {
    
        /// <summary>Gets the wrapped <see cref="T:System.String" /> object to marshal as type VT_BSTR.</summary><returns>The object that is wrapped by <see cref="T:System.Runtime.InteropServices.BStrWrapper" />.</returns>
        public string WrappedObject
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.BStrWrapper" /> class with the specified <see cref="T:System.String" /> object.</summary><param name="value">The object to wrap and marshal as VT_BSTR.</param>
        [SecuritySafeCriticalAttribute()]
        public BStrWrapper(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.BStrWrapper" /> class with the specified <see cref="T:System.Object" /> object.</summary><param name="value">The object to wrap and marshal as VT_BSTR.</param>
        [SecuritySafeCriticalAttribute()]
        public BStrWrapper(object value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
