using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Used by <see cref="M:System.AppDomain.DoCallBack(System.CrossAppDomainDelegate)" /> for cross-application domain calls.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public delegate void CrossAppDomainDelegate();
}
