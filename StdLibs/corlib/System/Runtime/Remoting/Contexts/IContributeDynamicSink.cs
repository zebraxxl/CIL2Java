using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Contexts
{
    /// <summary>Indicates that the implementing property will be registered at runtime through the <see cref="M:System.Runtime.Remoting.Contexts.Context.RegisterDynamicProperty(System.Runtime.Remoting.Contexts.IDynamicProperty,System.ContextBoundObject,System.Runtime.Remoting.Contexts.Context)" /> method.</summary>
    [ComVisibleAttribute(true)]
    public interface IContributeDynamicSink
    {
        [SecurityCriticalAttribute()]
        IDynamicMessageSink GetDynamicSink();
        
        
    }
}
