using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Specifies the COM dispatch identifier (DISPID) of a method, field, or property.</summary>
    [AttributeUsageAttribute(AttributeTargets.Method|AttributeTargets.Property|AttributeTargets.Field|AttributeTargets.Event, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class DispIdAttribute : Attribute
    {
    
        /// <summary>Gets the DISPID for the member.</summary><returns>The DISPID for the member.</returns>
        public int Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the DispIdAttribute class with the specified DISPID.</summary><param name="dispId">The DISPID for the member. </param>
        public DispIdAttribute(int dispId)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
