using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Indicates that a field of a serializable class should not be serialized. This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    [AttributeUsageAttribute(AttributeTargets.Field, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class NonSerializedAttribute : Attribute
    {
        public NonSerializedAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
