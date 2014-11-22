using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Indicates whether the <see cref="M:System.Runtime.InteropServices.Marshal.GetComInterfaceForObject(System.Object,System.Type,System.Runtime.InteropServices.CustomQueryInterfaceMode)" /> method's IUnknown::QueryInterface calls can use the <see cref="T:System.Runtime.InteropServices.ICustomQueryInterface" /> interface.</summary>
    [Serializable]
    public enum CustomQueryInterfaceMode : int
    {
        /// <summary>IUnknown::QueryInterface method calls should ignore the <see cref="T:System.Runtime.InteropServices.ICustomQueryInterface" /> interface.</summary>
        Ignore = 0,
        /// <summary>IUnknown::QueryInterface method calls can use the <see cref="T:System.Runtime.InteropServices.ICustomQueryInterface" /> interface. When you use this value, the <see cref="M:System.Runtime.InteropServices.Marshal.GetComInterfaceForObject(System.Object,System.Type,System.Runtime.InteropServices.CustomQueryInterfaceMode)" /> method overload functions like the <see cref="M:System.Runtime.InteropServices.Marshal.GetComInterfaceForObject(System.Object,System.Type)" /> overload.</summary>
        Allow = 1
    }
}
