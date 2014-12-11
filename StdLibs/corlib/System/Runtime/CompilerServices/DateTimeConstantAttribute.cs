using System.Runtime.InteropServices;
using System;

namespace System.Runtime.CompilerServices
{
    /// <summary>Persists an 8-byte <see cref="T:System.DateTime" /> constant for a field or parameter.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Field|AttributeTargets.Parameter, Inherited = false)]
    public sealed class DateTimeConstantAttribute : CustomConstantAttribute
    {
    
        /// <summary>Gets the number of 100-nanosecond ticks that represent the date and time of this instance.</summary><returns>The number of 100-nanosecond ticks that represent the date and time of this instance.</returns>
        public override object Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the DateTimeConstantAttribute class with the number of 100-nanosecond ticks that represent the date and time of this instance.</summary><param name="ticks">The number of 100-nanosecond ticks that represent the date and time of this instance. </param>
        public DateTimeConstantAttribute(long ticks)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
