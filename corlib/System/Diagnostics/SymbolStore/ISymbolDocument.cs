using System.Runtime.InteropServices;
using System;

namespace System.Diagnostics.SymbolStore
{
    /// <summary>Represents a document referenced by a symbol store.</summary>
    [ComVisibleAttribute(true)]
    public interface ISymbolDocument
    {
        /// <summary>Gets the URL of the current document.</summary><returns>The URL of the current document.</returns>
        string URL
        {
            get;
        }
    
        /// <summary>Gets the type of the current document.</summary><returns>The type of the current document.</returns>
        Guid DocumentType
        {
            get;
        }
    
        /// <summary>Gets the language of the current document.</summary><returns>The language of the current document.</returns>
        Guid Language
        {
            get;
        }
    
        /// <summary>Gets the language vendor of the current document.</summary><returns>The language vendor of the current document.</returns>
        Guid LanguageVendor
        {
            get;
        }
    
        /// <summary>Gets the checksum algorithm identifier.</summary><returns>A GUID identifying the checksum algorithm. The value is all zeros, if there is no checksum.</returns>
        Guid CheckSumAlgorithmId
        {
            get;
        }
    
        /// <summary>Checks whether the current document is stored in the symbol store.</summary><returns>true if the current document is stored in the symbol store; otherwise, false.</returns>
        bool HasEmbeddedSource
        {
            get;
        }
    
        /// <summary>Gets the length, in bytes, of the embedded source.</summary><returns>The source length of the current document.</returns>
        int SourceLength
        {
            get;
        }
    
    
        byte[] GetCheckSum();
        
        
        /// <summary>Returns the closest line that is a sequence point, given a line in the current document that might or might not be a sequence point.</summary><returns>The closest line that is a sequence point.</returns><param name="line">The specified line in the document. </param>
        int FindClosestLine(int line);
        
        
        /// <summary>Gets the embedded document source for the specified range.</summary><returns>The document source for the specified range.</returns><param name="startLine">The starting line in the current document. </param><param name="startColumn">The starting column in the current document. </param><param name="endLine">The ending line in the current document. </param><param name="endColumn">The ending column in the current document. </param>
        byte[] GetSourceRange(int startLine, int startColumn, int endLine, int endColumn);
        
        
    }
}
