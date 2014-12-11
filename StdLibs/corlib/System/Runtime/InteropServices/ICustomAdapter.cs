
namespace System.Runtime.InteropServices
{
    /// <summary>Provides a way for clients to access the actual object, rather than the adapter object handed out by a custom marshaler.</summary>
    [ComVisibleAttribute(true)]
    public interface ICustomAdapter
    {
        object GetUnderlyingObject();
        
        
    }
}
