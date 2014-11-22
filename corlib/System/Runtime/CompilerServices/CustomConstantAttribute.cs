using System;
using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
    /// <summary>Defines a constant value that a compiler can persist for a field or method parameter.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Field|AttributeTargets.Parameter, Inherited = false)]
    [ComVisibleAttribute(true)]
    public abstract class CustomConstantAttribute : Attribute
    {
        /// <summary>Gets the constant value stored by this attribute.</summary><returns>The constant value stored by this attribute.</returns>
        public abstract object Value
        {
            get;
        }
    
    
        protected CustomConstantAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
