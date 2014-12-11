using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Indicates that the COM threading model for an application is multithreaded apartment (MTA). </summary><filterpriority>1</filterpriority>
    [AttributeUsageAttribute(AttributeTargets.Method)]
    [ComVisibleAttribute(true)]
    public sealed class MTAThreadAttribute : Attribute
    {
        public MTAThreadAttribute()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
