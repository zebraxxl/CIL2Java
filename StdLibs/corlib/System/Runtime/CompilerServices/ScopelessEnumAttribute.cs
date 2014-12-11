using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Indicates that a native enumeration is not qualified by the enumeration type name. This class cannot be inherited.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Enum)]
    public sealed class ScopelessEnumAttribute : Attribute
    {
        public ScopelessEnumAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
