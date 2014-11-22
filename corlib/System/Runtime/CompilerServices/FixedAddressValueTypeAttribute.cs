using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Fixes the address of a static value type field throughout its lifetime. This class cannot be inherited.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Field)]
    public sealed class FixedAddressValueTypeAttribute : Attribute
    {
        public FixedAddressValueTypeAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
