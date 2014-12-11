using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Indicates that an enumeration can be treated as a bit field; that is, a set of flags.</summary><filterpriority>1</filterpriority>
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Enum, Inherited = false)]
    [ComVisibleAttribute(true)]
    public class FlagsAttribute : Attribute
    {
        public FlagsAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
