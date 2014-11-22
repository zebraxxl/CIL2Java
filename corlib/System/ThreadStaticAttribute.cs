using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Indicates that the value of a static field is unique for each thread.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Field, Inherited = false)]
    public class ThreadStaticAttribute : Attribute
    {
        public ThreadStaticAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
