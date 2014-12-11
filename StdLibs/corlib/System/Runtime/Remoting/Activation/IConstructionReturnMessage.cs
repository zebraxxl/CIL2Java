using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Activation
{
    /// <summary>Identifies a <see cref="T:System.Runtime.Remoting.Messaging.IMethodReturnMessage" /> that is returned after attempting to activate a remote object.</summary>
    [ComVisibleAttribute(true)]
    public interface IConstructionReturnMessage : IMethodReturnMessage
    {
    }
}
