using System.Security;

namespace System.Runtime.InteropServices
{
    /// <summary>Enables customization of managed objects that extend from unmanaged objects during creation.</summary>
    [ComVisibleAttribute(true)]
    public sealed class ExtensibleClassFactory
    {
        /// <summary>Registers a delegate that is called when an instance of a managed type, that extends from an unmanaged type, needs to allocate the aggregated unmanaged object.</summary><param name="callback">A delegate that is called in place of CoCreateInstance. </param>
        [SecuritySafeCriticalAttribute()]
        public static void RegisterObjectCreationCallback(ObjectCreationDelegate callback)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
