using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Specifies whether the type should be marshaled using the Automation marshaler or a custom proxy and stub.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Interface, Inherited = false)]
    public sealed class AutomationProxyAttribute : Attribute
    {
    
        /// <summary>Gets a value indicating the type of marshaler to use.</summary><returns>true if the class should be marshaled using the Automation Marshaler; false if a proxy stub marshaler should be used.</returns>
        public bool Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.AutomationProxyAttribute" /> class.</summary><param name="val">true if the class should be marshaled using the Automation Marshaler; false if a proxy stub marshaler should be used. </param>
        public AutomationProxyAttribute(bool val)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
