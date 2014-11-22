using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.IConnectionPointContainer" /> instead.</summary>
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IConnectionPointContainer instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [GuidAttribute("B196B284-BAB4-101A-B69C-00AA00341D07")]
    public interface UCOMIConnectionPointContainer
    {
        void EnumConnectionPoints(ref UCOMIEnumConnectionPoints ppEnum);
        
        
        void FindConnectionPoint(ref Guid riid, ref UCOMIConnectionPoint ppCP);
        
        
    }
}
