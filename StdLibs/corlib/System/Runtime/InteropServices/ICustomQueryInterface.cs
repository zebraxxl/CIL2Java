using System.Security;
using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Enables developers to provide a custom, managed implementation of the IUnknown::QueryInterface(REFIID riid, void **ppvObject) method.</summary>
    [ComVisibleAttribute(false)]
    public interface ICustomQueryInterface
    {
        [SecurityCriticalAttribute()]
        CustomQueryInterfaceResult GetInterface(ref Guid iid, ref IntPtr ppv);
        
        
    }
}
