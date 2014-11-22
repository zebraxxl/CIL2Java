using System.Runtime.InteropServices;
using System;
using System.Reflection;

namespace System.Diagnostics.SymbolStore
{
    /// <summary>Represents a symbol writer for managed code.</summary>
    [ComVisibleAttribute(true)]
    public interface ISymbolWriter
    {
        /// <summary>Sets the metadata emitter interface to associate with a writer.</summary><param name="emitter">The metadata emitter interface. </param><param name="filename">The file name for which the debugging symbols are written. Some writers require a file name, and others do not. If a file name is specified for a writer that does not use file names, this parameter is ignored. </param><param name="fFullBuild">true indicates that this is a full rebuild; false indicates that this is an incremental compilation. </param>
        void Initialize(IntPtr emitter, string filename, bool fFullBuild);
        
        
        /// <summary>Defines a source document.</summary><returns>The object that represents the document.</returns><param name="url">The URL that identifies the document. </param><param name="language">The document language. This parameter can be <see cref="F:System.Guid.Empty" />. </param><param name="languageVendor">The identity of the vendor for the document language. This parameter can be <see cref="F:System.Guid.Empty" />. </param><param name="documentType">The type of the document. This parameter can be <see cref="F:System.Guid.Empty" />. </param>
        ISymbolDocumentWriter DefineDocument(string url, Guid language, Guid languageVendor, Guid documentType);
        
        
        /// <summary>Identifies the user-defined method as the entry point for the current module.</summary><param name="entryMethod">The metadata token for the method that is the user entry point. </param>
        void SetUserEntryPoint(SymbolToken entryMethod);
        
        
        /// <summary>Opens a method to place symbol information into.</summary><param name="method">The metadata token for the method to be opened. </param>
        void OpenMethod(SymbolToken method);
        
        
        void CloseMethod();
        
        
        /// <summary>Defines a group of sequence points within the current method.</summary><param name="document">The document object for which the sequence points are being defined. </param><param name="offsets">The sequence point offsets measured from the beginning of methods. </param><param name="lines">The document lines for the sequence points. </param><param name="columns">The document positions for the sequence points. </param><param name="endLines">The document end lines for the sequence points. </param><param name="endColumns">The document end positions for the sequence points. </param>
        void DefineSequencePoints(ISymbolDocumentWriter document, int[] offsets, int[] lines, int[] columns, int[] endLines, int[] endColumns);
        
        
        /// <summary>Opens a new lexical scope in the current method.</summary><returns>An opaque scope identifier that can be used with <see cref="M:System.Diagnostics.SymbolStore.ISymbolWriter.SetScopeRange(System.Int32,System.Int32,System.Int32)" /> to define the start and end offsets of a scope at a later time. In this case, the offsets passed to <see cref="M:System.Diagnostics.SymbolStore.ISymbolWriter.OpenScope(System.Int32)" /> and <see cref="M:System.Diagnostics.SymbolStore.ISymbolWriter.CloseScope(System.Int32)" /> are ignored. A scope identifier is valid only in the current method.</returns><param name="startOffset">The offset, in bytes, from the beginning of the method to the first instruction in the lexical scope. </param>
        int OpenScope(int startOffset);
        
        
        /// <summary>Closes the current lexical scope.</summary><param name="endOffset">The points past the last instruction in the scope. </param>
        void CloseScope(int endOffset);
        
        
        /// <summary>Defines the offset range for the specified lexical scope.</summary><param name="scopeID">The identifier of the lexical scope. </param><param name="startOffset">The byte offset of the beginning of the lexical scope. </param><param name="endOffset">The byte offset of the end of the lexical scope. </param>
        void SetScopeRange(int scopeID, int startOffset, int endOffset);
        
        
        /// <summary>Defines a single variable in the current lexical scope.</summary><param name="name">The local variable name. </param><param name="attributes">A bitwise combination of the local variable attributes. </param><param name="signature">The local variable signature. </param><param name="addrKind">The address types for <paramref name="addr1" />, <paramref name="addr2" />, and <paramref name="addr3" />. </param><param name="addr1">The first address for the local variable specification. </param><param name="addr2">The second address for the local variable specification. </param><param name="addr3">The third address for the local variable specification. </param><param name="startOffset">The start offset for the variable. If this parameter is zero, it is ignored and the variable is defined throughout the entire scope. If the parameter is nonzero, the variable falls within the offsets of the current scope. </param><param name="endOffset">The end offset for the variable. If this parameter is zero, it is ignored and the variable is defined throughout the entire scope. If the parameter is nonzero, the variable falls within the offsets of the current scope. </param>
        void DefineLocalVariable(string name, FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3, int startOffset, int endOffset);
        
        
        /// <summary>Defines a single parameter in the current method. The type of each parameter is taken from its position within the signature of the method.</summary><param name="name">The parameter name. </param><param name="attributes">A bitwise combination of the parameter attributes. </param><param name="sequence">The parameter signature. </param><param name="addrKind">The address types for <paramref name="addr1" />, <paramref name="addr2" />, and <paramref name="addr3" />. </param><param name="addr1">The first address for the parameter specification. </param><param name="addr2">The second address for the parameter specification. </param><param name="addr3">The third address for the parameter specification. </param>
        void DefineParameter(string name, ParameterAttributes attributes, int sequence, SymAddressKind addrKind, int addr1, int addr2, int addr3);
        
        
        /// <summary>Defines a field in a type or a global field.</summary><param name="parent">The metadata type or method token. </param><param name="name">The field name. </param><param name="attributes">A bitwise combination of the field attributes. </param><param name="signature">The field signature. </param><param name="addrKind">The address types for <paramref name="addr1" /> and <paramref name="addr2" />. </param><param name="addr1">The first address for the field specification. </param><param name="addr2">The second address for the field specification. </param><param name="addr3">The third address for the field specification. </param>
        void DefineField(SymbolToken parent, string name, FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3);
        
        
        /// <summary>Defines a single global variable.</summary><param name="name">The global variable name. </param><param name="attributes">A bitwise combination of the global variable attributes. </param><param name="signature">The global variable signature. </param><param name="addrKind">The address types for <paramref name="addr1" />, <paramref name="addr2" />, and <paramref name="addr3" />. </param><param name="addr1">The first address for the global variable specification. </param><param name="addr2">The second address for the global variable specification. </param><param name="addr3">The third address for the global variable specification. </param>
        void DefineGlobalVariable(string name, FieldAttributes attributes, byte[] signature, SymAddressKind addrKind, int addr1, int addr2, int addr3);
        
        
        void Close();
        
        
        /// <summary>Defines an attribute when given the attribute name and the attribute value.</summary><param name="parent">The metadata token for which the attribute is being defined. </param><param name="name">The attribute name. </param><param name="data">The attribute value. </param>
        void SetSymAttribute(SymbolToken parent, string name, byte[] data);
        
        
        /// <summary>Opens a new namespace.</summary><param name="name">The name of the new namespace. </param>
        void OpenNamespace(string name);
        
        
        void CloseNamespace();
        
        
        /// <summary>Specifies that the given, fully qualified namespace name is used within the open lexical scope.</summary><param name="fullName">The fully qualified name of the namespace. </param>
        void UsingNamespace(string fullName);
        
        
        /// <summary>Specifies the true start and end of a method within a source file. Use <see cref="M:System.Diagnostics.SymbolStore.ISymbolWriter.SetMethodSourceRange(System.Diagnostics.SymbolStore.ISymbolDocumentWriter,System.Int32,System.Int32,System.Diagnostics.SymbolStore.ISymbolDocumentWriter,System.Int32,System.Int32)" /> to specify the extent of a method, independent of the sequence points that exist within the method.</summary><param name="startDoc">The document that contains the starting position. </param><param name="startLine">The starting line number. </param><param name="startColumn">The starting column. </param><param name="endDoc">The document that contains the ending position. </param><param name="endLine">The ending line number. </param><param name="endColumn">The ending column number. </param>
        void SetMethodSourceRange(ISymbolDocumentWriter startDoc, int startLine, int startColumn, ISymbolDocumentWriter endDoc, int endLine, int endColumn);
        
        
        /// <summary>Sets the underlying ISymUnmanagedWriter (the corresponding unmanaged interface) that a managed <see cref="T:System.Diagnostics.SymbolStore.ISymbolWriter" /> uses to emit symbols.</summary><param name="underlyingWriter">A pointer to code that represents the underlying writer. </param>
        void SetUnderlyingWriter(IntPtr underlyingWriter);
        
        
    }
}
