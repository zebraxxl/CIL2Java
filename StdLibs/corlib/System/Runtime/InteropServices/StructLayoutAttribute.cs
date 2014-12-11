using System;

namespace System.Runtime.InteropServices
{
    /// <summary>Lets you control the physical layout of the data fields of a class or structure.</summary>
    [ComVisibleAttribute(true)]
    [AttributeUsageAttribute(AttributeTargets.Class|AttributeTargets.Struct, Inherited = false)]
    public sealed class StructLayoutAttribute : Attribute
    {
        /// <summary>Controls the alignment of data fields of a class or structure in memory.</summary>
        public int Pack;
        /// <summary>Indicates the absolute size of the class or structure.</summary>
        public int Size;
        /// <summary>Indicates whether string data fields within the class should be marshaled as LPWSTR or LPSTR by default.</summary>
        public CharSet CharSet;
    
        /// <summary>Gets the <see cref="T:System.Runtime.InteropServices.LayoutKind" /> value that specifies how the class or structure is arranged.</summary><returns>One of the enumeration values that specifies how the class or structure is arranged.</returns>
        public LayoutKind Value
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initalizes a new instance of the <see cref="T:System.Runtime.InteropServices.StructLayoutAttribute" /> class with the specified <see cref="T:System.Runtime.InteropServices.LayoutKind" /> enumeration member.</summary><param name="layoutKind">One of the enumeration values that specifes how the class or structure should be arranged. </param>
        public StructLayoutAttribute(LayoutKind layoutKind)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initalizes a new instance of the <see cref="T:System.Runtime.InteropServices.StructLayoutAttribute" /> class with the specified <see cref="T:System.Runtime.InteropServices.LayoutKind" /> enumeration member.</summary><param name="layoutKind">A 16-bit integer that represents one of the <see cref="T:System.Runtime.InteropServices.LayoutKind" /> values that specifes how the class or structure should be arranged. </param>
        public StructLayoutAttribute(short layoutKind)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
