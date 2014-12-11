using System.Reflection;
using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Exposes the <see cref="T:System.Reflection.ParameterInfo" /> class to unmanaged code.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [TypeLibImportClassAttribute(typeof(ParameterInfo))]
    [GuidAttribute("993634C4-E47A-32CC-BE08-85F567DC27D6")]
    [ComVisibleAttribute(true)]
    public interface _ParameterInfo
    {
        void GetTypeInfoCount(ref uint pcTInfo);
        
        
        /// <summary>Retrieves the type information for an object, which can be used to get the type information for an interface.</summary><param name="iTInfo">The type information to return.</param><param name="lcid">The locale identifier for the type information.</param><param name="ppTInfo">A pointer to the requested type information object.</param>
        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
        
        
        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
        
        
        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
        
        
    }
}
