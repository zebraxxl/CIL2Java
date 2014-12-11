using System.Runtime.InteropServices;
using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Provides the managed definition of the IConnectionPointContainer interface.</summary>
    [GuidAttribute("B196B284-BAB4-101A-B69C-00AA00341D07")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IConnectionPointContainer
    {
        void EnumConnectionPoints(ref IEnumConnectionPoints ppEnum);
        
        
        void FindConnectionPoint(ref Guid riid, ref IConnectionPoint ppCP);
        
        
    }
}
