using System.Runtime.InteropServices;
using System;

namespace System.Diagnostics.SymbolStore
{
    /// <summary>Represents a symbol binder for managed code.</summary>
    [ComVisibleAttribute(true)]
    public interface ISymbolBinder
    {
        /// <summary>Gets the interface of the symbol reader for the current file.</summary><returns>The <see cref="T:System.Diagnostics.SymbolStore.ISymbolReader" /> interface that reads the debugging symbols.</returns><param name="importer">The metadata import interface. </param><param name="filename">The name of the file for which the reader interface is required. </param><param name="searchPath">The search path used to locate the symbol file. </param>
        [ObsoleteAttribute("The recommended alternative is ISymbolBinder1.GetReader. ISymbolBinder1.GetReader takes the importer interface pointer as an IntPtr instead of an Int32, and thus works on both 32-bit and 64-bit architectures. http://go.microsoft.com/fwlink/?linkid=14202=14202")]
        ISymbolReader GetReader(int importer, string filename, string searchPath);
        
        
    }
}
