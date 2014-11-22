using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Indicates that a method's unmanaged signature expects a locale identifier (LCID) parameter.</summary>
    [AttributeUsageAttribute(AttributeTargets.Method, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class LCIDConversionAttribute : Attribute
    {
    
        /// <summary>Gets the position of the LCID argument in the unmanaged signature.</summary><returns>The position of the LCID argument in the unmanaged signature, where 0 is the first argument.</returns>
        public int Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the LCIDConversionAttribute class with the position of the LCID in the unmanaged signature.</summary><param name="lcid">Indicates the position of the LCID argument in the unmanaged signature, where 0 is the first argument. </param>
        public LCIDConversionAttribute(int lcid)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
