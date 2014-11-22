using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Provides the managed definition of the ITypeComp interface.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("00020403-0000-0000-C000-000000000046")]
    public interface ITypeComp
    {
        void Bind(string szName, int lHashVal, short wFlags, ref ITypeInfo ppTInfo, ref DESCKIND pDescKind, ref BINDPTR pBindPtr);
        
        
        void BindType(string szName, int lHashVal, ref ITypeInfo ppTInfo, ref ITypeComp ppTComp);
        
        
    }
}
