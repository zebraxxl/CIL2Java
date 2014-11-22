using System.Runtime.InteropServices;
using System;

namespace System.Reflection.Emit
{
    /// <summary>Describes a Microsoft intermediate language (MSIL) instruction.</summary>
    [ComVisibleAttribute(true)]
    public struct OpCode
    {
    
        /// <summary>The operand type of an Microsoft intermediate language (MSIL) instruction.</summary><returns>Read-only. The operand type of an MSIL instruction.</returns>
        public OperandType OperandType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>The flow control characteristics of the Microsoft intermediate language (MSIL) instruction.</summary><returns>Read-only. The type of flow control.</returns>
        public FlowControl FlowControl
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>The type of Microsoft intermediate language (MSIL) instruction.</summary><returns>Read-only. The type of Microsoft intermediate language (MSIL) instruction.</returns>
        public OpCodeType OpCodeType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>How the Microsoft intermediate language (MSIL) instruction pops the stack.</summary><returns>Read-only. The way the MSIL instruction pops the stack.</returns>
        public StackBehaviour StackBehaviourPop
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>How the Microsoft intermediate language (MSIL) instruction pushes operand onto the stack.</summary><returns>Read-only. The way the MSIL instruction pushes operand onto the stack.</returns>
        public StackBehaviour StackBehaviourPush
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>The size of the Microsoft intermediate language (MSIL) instruction.</summary><returns>Read-only. The size of the MSIL instruction.</returns>
        public int Size
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>The value of the immediate operand of the Microsoft intermediate language (MSIL) instruction.</summary><returns>Read-only. The value of the immediate operand of the MSIL instruction.</returns>
        public short Value
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>The name of the Microsoft intermediate language (MSIL) instruction.</summary><returns>Read-only. The name of the MSIL instruction.</returns>
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Tests whether the given object is equal to this Opcode.</summary><returns>true if <paramref name="obj" /> is an instance of Opcode and is equal to this object; otherwise, false.</returns><param name="obj">The object to compare to this object. </param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether the current instance is equal to the specified <see cref="T:System.Reflection.Emit.OpCode" />.</summary><returns>true if the value of <paramref name="obj" /> is equal to the value of the current instance; otherwise, false.</returns><param name="obj">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to the current instance.</param>
        public bool Equals(OpCode obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.OpCode" /> structures are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to <paramref name="a" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.OpCode" /> structures are equal.</summary><returns>true if <paramref name="a" /> is equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to <paramref name="a" />.</param>
        public static bool operator ==(OpCode a, OpCode b)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.OpCode" /> structures are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to <paramref name="a" />.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.Emit.OpCode" /> structures are not equal.</summary><returns>true if <paramref name="a" /> is not equal to <paramref name="b" />; otherwise, false.</returns><param name="a">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to <paramref name="b" />.</param><param name="b">The <see cref="T:System.Reflection.Emit.OpCode" /> to compare to <paramref name="a" />.</param>
        public static bool operator !=(OpCode a, OpCode b)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
