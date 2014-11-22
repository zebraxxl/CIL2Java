using System;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Marks a method as one way, without a return value and out or ref parameters.</summary>
    [AttributeUsageAttribute(AttributeTargets.Method)]
    [ComVisibleAttribute(true)]
    public class OneWayAttribute : Attribute
    {
        public OneWayAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
