using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Indicates that a method will allow a variable number of arguments in its invocation. This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    [AttributeUsageAttribute(AttributeTargets.Parameter, Inherited = true, AllowMultiple = false)]
    [ComVisibleAttribute(true)]
    public sealed class ParamArrayAttribute : Attribute
    {
        public ParamArrayAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
