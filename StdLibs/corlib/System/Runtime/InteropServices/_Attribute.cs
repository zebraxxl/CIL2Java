using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Exposes the <see cref="T:System.Attribute" /> class to unmanaged code.</summary>
    [TypeLibImportClassAttribute(typeof(Attribute))]
    [ComVisibleAttribute(true)]
    [GuidAttribute("917B14D0-2D9E-38B8-92A9-381ACF52F7C0")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface _Attribute
    {
        void GetTypeInfoCount(ref uint pcTInfo);
        
        
        /// <summary>Retrieves the type information for an object, which can be used to get the type information for an interface.</summary><param name="iTInfo">The type information to return.</param><param name="lcid">The locale identifier for the type information.</param><param name="ppTInfo">A pointer to the requested type information object.</param>
        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
        
        
        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
        
        
        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
        
        
    }
}
