using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
    /// <summary>Represents a namespace within a symbol store.</summary>
    [ComVisibleAttribute(true)]
    public interface ISymbolNamespace
    {
        /// <summary>Gets the current namespace.</summary><returns>The current namespace.</returns>
        string Name
        {
            get;
        }
    
    
        ISymbolNamespace[] GetNamespaces();
        
        
        ISymbolVariable[] GetVariables();
        
        
    }
}
