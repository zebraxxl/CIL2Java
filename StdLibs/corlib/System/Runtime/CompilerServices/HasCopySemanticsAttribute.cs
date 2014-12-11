using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>This class is not used in the .NET Framework version 2.0 and is reserved for future use. This class cannot be inherited.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Struct)]
    public sealed class HasCopySemanticsAttribute : Attribute
    {
        public HasCopySemanticsAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
