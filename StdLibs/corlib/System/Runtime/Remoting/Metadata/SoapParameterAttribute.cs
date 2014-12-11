using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata
{
    /// <summary>Customizes SOAP generation and processing for a parameter. This class cannot be inherited.</summary>
    [AttributeUsageAttribute(AttributeTargets.Parameter)]
    [ComVisibleAttribute(true)]
    public sealed class SoapParameterAttribute : SoapAttribute
    {
        public SoapParameterAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
