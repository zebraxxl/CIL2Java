using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.ITypeComp" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.ITypeComp instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [GuidAttribute("00020403-0000-0000-C000-000000000046")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface UCOMITypeComp
    {
        void Bind(string szName, int lHashVal, short wFlags, ref UCOMITypeInfo ppTInfo, ref DESCKIND pDescKind, ref BINDPTR pBindPtr);
        
        
        void BindType(string szName, int lHashVal, ref UCOMITypeInfo ppTInfo, ref UCOMITypeComp ppTComp);
        
        
    }
}
