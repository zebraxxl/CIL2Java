using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
    /// <summary>Represents a method within a symbol store.</summary>
    [ComVisibleAttribute(true)]
    public interface ISymbolMethod
    {
        /// <summary>Gets the <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> containing the metadata for the current method.</summary><returns>The metadata token for the current method.</returns>
        SymbolToken Token
        {
            get;
        }
    
        /// <summary>Gets a count of the sequence points in the method.</summary><returns>The count of the sequence points in the method.</returns>
        int SequencePointCount
        {
            get;
        }
    
        /// <summary>Gets the root lexical scope for the current method. This scope encloses the entire method.</summary><returns>The root lexical scope that encloses the entire method.</returns>
        ISymbolScope RootScope
        {
            get;
        }
    
    
        /// <summary>Gets the sequence points for the current method.</summary><param name="offsets">The array of byte offsets from the beginning of the method for the sequence points. </param><param name="documents">The array of documents in which the sequence points are located. </param><param name="lines">The array of lines in the documents at which the sequence points are located. </param><param name="columns">The array of columns in the documents at which the sequence points are located. </param><param name="endLines">The array of lines in the documents at which the sequence points end. </param><param name="endColumns">The array of columns in the documents at which the sequence points end. </param>
        void GetSequencePoints(int[] offsets, ISymbolDocument[] documents, int[] lines, int[] columns, int[] endLines, int[] endColumns);
        
        
        /// <summary>Returns the most enclosing lexical scope when given an offset within a method.</summary><returns>The most enclosing lexical scope for the given byte offset within the method.</returns><param name="offset">The byte offset within the method of the lexical scope. </param>
        ISymbolScope GetScope(int offset);
        
        
        /// <summary>Gets the Microsoft intermediate language (MSIL) offset within the method that corresponds to the specified position.</summary><returns>The offset within the specified document.</returns><param name="document">The document for which the offset is requested. </param><param name="line">The document line corresponding to the offset. </param><param name="column">The document column corresponding to the offset. </param>
        int GetOffset(ISymbolDocument document, int line, int column);
        
        
        /// <summary>Gets an array of start and end offset pairs that correspond to the ranges of Microsoft intermediate language (MSIL) that a given position covers within this method.</summary><returns>An array of start and end offset pairs.</returns><param name="document">The document for which the offset is requested. </param><param name="line">The document line corresponding to the ranges. </param><param name="column">The document column corresponding to the ranges. </param>
        int[] GetRanges(ISymbolDocument document, int line, int column);
        
        
        ISymbolVariable[] GetParameters();
        
        
        ISymbolNamespace GetNamespace();
        
        
        /// <summary>Gets the start and end positions for the source of the current method.</summary><returns>true if the positions were defined; otherwise, false.</returns><param name="docs">The starting and ending source documents. </param><param name="lines">The starting and ending lines in the corresponding source documents. </param><param name="columns">The starting and ending columns in the corresponding source documents. </param>
        bool GetSourceStartEnd(ISymbolDocument[] docs, int[] lines, int[] columns);
        
        
    }
}
