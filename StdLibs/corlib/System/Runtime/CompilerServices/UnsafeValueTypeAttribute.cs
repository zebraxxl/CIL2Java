using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Specifies that a type contains an unmanaged array that might potentially overflow. This class cannot be inherited.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Struct)]
    public sealed class UnsafeValueTypeAttribute : Attribute
    {
        public UnsafeValueTypeAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
