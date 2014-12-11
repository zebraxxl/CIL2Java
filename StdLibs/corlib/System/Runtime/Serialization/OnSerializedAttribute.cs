using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
    /// <summary>When applied to a method, specifies that the method is called after serialization of an object in an object graph. The order of serialization relative to other objects in the graph is non-deterministic.</summary>
    [AttributeUsageAttribute(AttributeTargets.Method, Inherited = false)]
    [ComVisibleAttribute(true)]
    public sealed class OnSerializedAttribute : Attribute
    {
        public OnSerializedAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
