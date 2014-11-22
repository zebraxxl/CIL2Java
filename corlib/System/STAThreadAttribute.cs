using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Indicates that the COM threading model for an application is single-threaded apartment (STA). </summary><filterpriority>1</filterpriority>
    [AttributeUsageAttribute(AttributeTargets.Method)]
    [ComVisibleAttribute(true)]
    public sealed class STAThreadAttribute : Attribute
    {
        public STAThreadAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
