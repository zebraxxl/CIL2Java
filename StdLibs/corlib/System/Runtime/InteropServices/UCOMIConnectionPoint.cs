using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.IConnectionPoint" /> instead.</summary>
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [ObsoleteAttribute("Use System.Runtime.InteropServices.ComTypes.IConnectionPoint instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
    [GuidAttribute("B196B286-BAB4-101A-B69C-00AA00341D07")]
    public interface UCOMIConnectionPoint
    {
        void GetConnectionInterface(ref Guid pIID);
        
        
        void GetConnectionPointContainer(ref UCOMIConnectionPointContainer ppCPC);
        
        
        void Advise(object pUnkSink, ref int pdwCookie);
        
        
        /// <summary>Terminates an advisory connection previously established through <see cref="M:System.Runtime.InteropServices.UCOMIConnectionPoint.Advise(System.Object,System.Int32@)" />.</summary><param name="dwCookie">The connection cookie previously returned from <see cref="M:System.Runtime.InteropServices.UCOMIConnectionPoint.Advise(System.Object,System.Int32@)" />. </param>
        void Unadvise(int dwCookie);
        
        
        void EnumConnections(ref UCOMIEnumConnections ppEnum);
        
        
    }
}
