using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Indicates that the value of a static field is unique for a particular context.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Field, Inherited = false)]
    public class ContextStaticAttribute : Attribute
    {
        public ContextStaticAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
