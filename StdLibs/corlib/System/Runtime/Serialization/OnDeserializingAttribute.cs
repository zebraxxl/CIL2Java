using System.Runtime.InteropServices;
using System;

namespace System.Runtime.Serialization
{
    /// <summary>When applied to a method, specifies that the method is called during deserialization of an object in an object graph. The order of deserialization relative to other objects in the graph is non-deterministic.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Method, Inherited = false)]
    public sealed class OnDeserializingAttribute : Attribute
    {
        public OnDeserializingAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
