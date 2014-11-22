using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Indicates that a class can be serialized. This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Delegate, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class SerializableAttribute : Attribute
    {
        public SerializableAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
