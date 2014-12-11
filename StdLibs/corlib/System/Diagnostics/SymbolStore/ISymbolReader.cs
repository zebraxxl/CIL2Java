using System.Runtime.InteropServices;
using System;

namespace System.Diagnostics.SymbolStore
{
    /// <summary>Represents a symbol reader for managed code.</summary>
    [ComVisibleAttribute(true)]
    public interface ISymbolReader
    {
        /// <summary>Gets the metadata token for the method that was specified as the user entry point for the module, if any.</summary><returns>The metadata token for the method that is the user entry point for the module.</returns>
        SymbolToken UserEntryPoint
        {
            get;
        }
    
    
        /// <summary>Gets a document specified by the language, vendor, and type.</summary><returns>The specified document.</returns><param name="url">The URL that identifies the document. </param><param name="language">The document language. You can specify this parameter as <see cref="F:System.Guid.Empty" />. </param><param name="languageVendor">The identity of the vendor for the document language. You can specify this parameter as <see cref="F:System.Guid.Empty" />.</param><param name="documentType">The type of the document. You can specify this parameter as <see cref="F:System.Guid.Empty" />.</param>
        ISymbolDocument GetDocument(string url, Guid language, Guid languageVendor, Guid documentType);
        
        
        ISymbolDocument[] GetDocuments();
        
        
        /// <summary>Gets a symbol reader method object when given the identifier of a method.</summary><returns>The symbol reader method object for the specified method identifier.</returns><param name="method">The metadata token of the method. </param>
        ISymbolMethod GetMethod(SymbolToken method);
        
        
        /// <summary>Gets a symbol reader method object when given the identifier of a method and its edit and continue version.</summary><returns>The symbol reader method object for the specified method identifier.</returns><param name="method">The metadata token of the method. </param><param name="version">The edit and continue version of the method. </param>
        ISymbolMethod GetMethod(SymbolToken method, int version);
        
        
        /// <summary>Gets the variables that are not local when given the parent.</summary><returns>An array of variables for the parent.</returns><param name="parent">The metadata token for the type for which the variables are requested. </param>
        ISymbolVariable[] GetVariables(SymbolToken parent);
        
        
        ISymbolVariable[] GetGlobalVariables();
        
        
        /// <summary>Gets a symbol reader method object that contains a specified position in a document.</summary><returns>The reader method object for the specified position in the document.</returns><param name="document">The document in which the method is located. </param><param name="line">The position of the line within the document. The lines are numbered, beginning with 1. </param><param name="column">The position of column within the document. The columns are numbered, beginning with 1. </param>
        ISymbolMethod GetMethodFromDocumentPosition(ISymbolDocument document, int line, int column);
        
        
        /// <summary>Gets an attribute value when given the attribute name.</summary><returns>The value of the attribute.</returns><param name="parent">The metadata token for the object for which the attribute is requested. </param><param name="name">The attribute name. </param>
        byte[] GetSymAttribute(SymbolToken parent, string name);
        
        
        ISymbolNamespace[] GetNamespaces();
        
        
    }
}
