using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Remoting.Activation;

namespace System.Runtime.Remoting.Contexts
{
    /// <summary>Indicates that the implementing property is interested in participating in activation and might not have provided a message sink.</summary>
    [ComVisibleAttribute(true)]
    public interface IContextPropertyActivator
    {
        /// <summary>Indicates whether it is all right to activate the object type indicated in the <paramref name="msg" /> parameter.</summary><returns>A Boolean value indicating whether the requested type can be activated.</returns><param name="msg">An <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />. </param>
        [SecurityCriticalAttribute()]
        bool IsOKToActivate(IConstructionCallMessage msg);
        
        
        /// <summary>Called on each client context property that has this interface, before the construction request leaves the client.</summary><param name="msg">An <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />. </param>
        [SecurityCriticalAttribute()]
        void CollectFromClientContext(IConstructionCallMessage msg);
        
        
        /// <summary>Called on each client context property that has this interface, when the construction request returns to the client from the server.</summary><returns>true if successful; otherwise, false.</returns><param name="msg">An <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />. </param>
        [SecurityCriticalAttribute()]
        bool DeliverClientContextToServerContext(IConstructionCallMessage msg);
        
        
        /// <summary>Called on each server context property that has this interface, before the construction response leaves the server for the client.</summary><param name="msg">An <see cref="T:System.Runtime.Remoting.Activation.IConstructionReturnMessage" />. </param>
        [SecurityCriticalAttribute()]
        void CollectFromServerContext(IConstructionReturnMessage msg);
        
        
        /// <summary>Called on each client context property that has this interface, when the construction request returns to the client from the server.</summary><returns>true if successful; otherwise, false.</returns><param name="msg">An <see cref="T:System.Runtime.Remoting.Activation.IConstructionReturnMessage" />. </param>
        [SecurityCriticalAttribute()]
        bool DeliverServerContextToClientContext(IConstructionReturnMessage msg);
        
        
    }
}
