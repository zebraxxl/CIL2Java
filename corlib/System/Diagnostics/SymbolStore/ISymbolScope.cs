using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
    /// <summary>Represents a lexical scope within <see cref="T:System.Diagnostics.SymbolStore.ISymbolMethod" />, providing access to the start and end offsets of the scope, as well as its child and parent scopes.</summary>
    [ComVisibleAttribute(true)]
    public interface ISymbolScope
    {
        /// <summary>Gets the method that contains the current lexical scope.</summary><returns>The method that contains the current lexical scope.</returns>
        ISymbolMethod Method
        {
            get;
        }
    
        /// <summary>Gets the parent lexical scope of the current scope.</summary><returns>The parent lexical scope of the current scope.</returns>
        ISymbolScope Parent
        {
            get;
        }
    
        /// <summary>Gets the start offset of the current lexical scope.</summary><returns>The start offset of the current lexical scope.</returns>
        int StartOffset
        {
            get;
        }
    
        /// <summary>Gets the end offset of the current lexical scope.</summary><returns>The end offset of the current lexical scope.</returns>
        int EndOffset
        {
            get;
        }
    
    
        ISymbolScope[] GetChildren();
        
        
        ISymbolVariable[] GetLocals();
        
        
        ISymbolNamespace[] GetNamespaces();
        
        
    }
}
