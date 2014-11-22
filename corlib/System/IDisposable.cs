using System.Runtime.InteropServices;

namespace System
{
    /// <summary>Defines a method to release allocated resources.</summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public interface IDisposable
    {
        void Dispose();
        
        
    }
}
