using System.Runtime.InteropServices;

namespace System.IO.IsolatedStorage
{
    /// <summary>Enables comparisons between an isolated store and an application domain and assembly's evidence.</summary>
    [ComVisibleAttribute(true)]
    public interface INormalizeForIsolatedStorage
    {
        object Normalize();
        
        
    }
}
