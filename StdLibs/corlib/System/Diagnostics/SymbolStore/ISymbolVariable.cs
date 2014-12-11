using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore
{
    /// <summary>Represents a variable within a symbol store.</summary>
    [ComVisibleAttribute(true)]
    public interface ISymbolVariable
    {
        /// <summary>Gets the name of the variable.</summary><returns>The name of the variable.</returns>
        string Name
        {
            get;
        }
    
        /// <summary>Gets the attributes of the variable.</summary><returns>The variable attributes.</returns>
        object Attributes
        {
            get;
        }
    
        /// <summary>Gets the <see cref="T:System.Diagnostics.SymbolStore.SymAddressKind" /> value describing the type of the address.</summary><returns>The type of the address. One of the <see cref="T:System.Diagnostics.SymbolStore.SymAddressKind" /> values.</returns>
        SymAddressKind AddressKind
        {
            get;
        }
    
        /// <summary>Gets the first address of a variable.</summary><returns>The first address of the variable.</returns>
        int AddressField1
        {
            get;
        }
    
        /// <summary>Gets the second address of a variable.</summary><returns>The second address of the variable.</returns>
        int AddressField2
        {
            get;
        }
    
        /// <summary>Gets the third address of a variable.</summary><returns>The third address of the variable.</returns>
        int AddressField3
        {
            get;
        }
    
        /// <summary>Gets the start offset of the variable within the scope of the variable.</summary><returns>The start offset of the variable.</returns>
        int StartOffset
        {
            get;
        }
    
        /// <summary>Gets the end offset of a variable within the scope of the variable.</summary><returns>The end offset of the variable.</returns>
        int EndOffset
        {
            get;
        }
    
    
        byte[] GetSignature();
        
        
    }
}
