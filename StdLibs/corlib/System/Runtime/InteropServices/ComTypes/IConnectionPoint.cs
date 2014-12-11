using System.Runtime.InteropServices;
using System;

namespace System.Runtime.InteropServices.ComTypes
{
    /// <summary>Provides the managed definition of the IConnectionPoint interface.</summary>
    [GuidAttribute("B196B286-BAB4-101A-B69C-00AA00341D07")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IConnectionPoint
    {
        void GetConnectionInterface(ref Guid pIID);
        
        
        void GetConnectionPointContainer(ref IConnectionPointContainer ppCPC);
        
        
        void Advise(object pUnkSink, ref int pdwCookie);
        
        
        /// <summary>Terminates an advisory connection previously established through the <see cref="M:System.Runtime.InteropServices.ComTypes.IConnectionPoint.Advise(System.Object,System.Int32@)" /> method.</summary><param name="dwCookie">The connection cookie previously returned from the <see cref="M:System.Runtime.InteropServices.ComTypes.IConnectionPoint.Advise(System.Object,System.Int32@)" /> method. </param>
        void Unadvise(int dwCookie);
        
        
        void EnumConnections(ref IEnumConnections ppEnum);
        
        
    }
}
