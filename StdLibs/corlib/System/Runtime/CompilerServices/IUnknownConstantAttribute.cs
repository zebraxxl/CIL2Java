using System.Runtime.InteropServices;
using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Indicates that the default value for the attributed field or parameter is an instance of <see cref="T:System.Runtime.InteropServices.UnknownWrapper" />, where the <see cref="P:System.Runtime.InteropServices.UnknownWrapper.WrappedObject" /> is null. This class cannot be inherited. </summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Field|AttributeTargets.Parameter, Inherited = false)]
    public sealed class IUnknownConstantAttribute : CustomConstantAttribute
    {
        /// <summary>Gets the IUnknown constant stored in this attribute.</summary><returns>The IUnknown constant stored in this attribute. Only null is allowed for an IUnknown constant value.</returns>
        public override object Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public IUnknownConstantAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
