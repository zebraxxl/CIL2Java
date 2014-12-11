using System.Runtime.InteropServices;
using System.Reflection;
using System;

namespace System.Reflection.Emit
{
    /// <summary>Represents a local variable within a method or constructor.</summary>
    [ComDefaultInterfaceAttribute(typeof(_LocalBuilder))]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    public sealed class LocalBuilder : LocalVariableInfo, _LocalBuilder
    {
    
        /// <summary>Gets a value indicating whether the object referred to by the local variable is pinned in memory.</summary><returns>true if the object referred to by the local variable is pinned in memory; otherwise, false.</returns>
        public override bool IsPinned
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type of the local variable.</summary><returns>The <see cref="T:System.Type" /> of the local variable.</returns>
        public override Type LocalType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the zero-based index of the local variable within the method body.</summary><returns>An integer value that represents the order of declaration of the local variable within the method body.</returns>
        public override int LocalIndex
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Sets the name of this local variable.</summary><param name="name">The name of the local variable. </param><exception cref="T:System.InvalidOperationException">The containing type has been created with <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or- There is no symbolic writer defined for the containing module. </exception><exception cref="T:System.NotSupportedException">This local is defined in a dynamic method, rather than in a method of a dynamic type.</exception>
        public void SetLocalSymInfo(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the name and lexical scope of this local variable.</summary><param name="name">The name of the local variable. </param><param name="startOffset">The beginning offset of the lexical scope of the local variable. </param><param name="endOffset">The ending offset of the lexical scope of the local variable. </param><exception cref="T:System.InvalidOperationException">The containing type has been created with <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" />.-or- There is no symbolic writer defined for the containing module. </exception><exception cref="T:System.NotSupportedException">This local is defined in a dynamic method, rather than in a method of a dynamic type.</exception>
        public void SetLocalSymInfo(string name, int startOffset, int endOffset)
        {
             throw new NotImplementedException();
        }



        void _LocalBuilder.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _LocalBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _LocalBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _LocalBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
