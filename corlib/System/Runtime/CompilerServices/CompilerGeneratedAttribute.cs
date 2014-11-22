using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Distinguishes a compiler-generated element from a user-generated element. This class cannot be inherited.</summary>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.All, Inherited = true)]
    public sealed class CompilerGeneratedAttribute : Attribute
    {
        public CompilerGeneratedAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
