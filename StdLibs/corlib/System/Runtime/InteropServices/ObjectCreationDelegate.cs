using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Creates a COM object.</summary><returns>An <see cref="T:System.IntPtr" /> object that represents the IUnknown interface of the COM object.</returns><param name="aggregator">A pointer to the managed object's IUnknown interface. </param>
    [ComVisibleAttribute(true)]
    public delegate IntPtr ObjectCreationDelegate(IntPtr aggregator);
}
