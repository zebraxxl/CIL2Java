using System.Runtime.InteropServices;
using System.Security;
using System.Reflection;
using System;
using System.Diagnostics.SymbolStore;

namespace System.Reflection.Emit
{
    /// <summary>Generates Microsoft intermediate language (MSIL) instructions.</summary>
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_ILGenerator))]
    public class ILGenerator : _ILGenerator
    {
    
        /// <summary>Gets the current offset, in bytes, in the Microsoft intermediate language (MSIL) stream that is being emitted by the <see cref="T:System.Reflection.Emit.ILGenerator" />.</summary><returns>The offset in the MSIL stream at which the next instruction will be emitted. </returns>
        public virtual int ILOffset
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Puts the specified instruction onto the stream of instructions.</summary><param name="opcode">The Microsoft Intermediate Language (MSIL) instruction to be put onto the stream. </param>
        public virtual void Emit(OpCode opcode)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction and character argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary><param name="opcode">The MSIL instruction to be put onto the stream. </param><param name="arg">The character argument pushed onto the stream immediately after the instruction. </param>
        public virtual void Emit(OpCode opcode, byte arg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction and character argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary><param name="opcode">The MSIL instruction to be put onto the stream. </param><param name="arg">The character argument pushed onto the stream immediately after the instruction. </param>
        public void Emit(OpCode opcode, sbyte arg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary><param name="opcode">The MSIL instruction to be emitted onto the stream. </param><param name="arg">The Int argument pushed onto the stream immediately after the instruction. </param>
        public virtual void Emit(OpCode opcode, short arg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary><param name="opcode">The MSIL instruction to be put onto the stream. </param><param name="arg">The numerical argument pushed onto the stream immediately after the instruction. </param>
        public virtual void Emit(OpCode opcode, int arg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream followed by the metadata token for the given method.</summary><param name="opcode">The MSIL instruction to be emitted onto the stream. </param><param name="meth">A MethodInfo representing a method. </param><exception cref="T:System.ArgumentNullException"><paramref name="meth" /> is null. </exception><exception cref="T:System.NotSupportedException"><paramref name="meth" /> is a generic method for which the <see cref="P:System.Reflection.MethodInfo.IsGenericMethodDefinition" /> property is false.</exception>
        [SecuritySafeCriticalAttribute()]
        public virtual void Emit(OpCode opcode, MethodInfo meth)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts a <see cref="F:System.Reflection.Emit.OpCodes.Calli" /> instruction onto the Microsoft intermediate language (MSIL) stream, specifying a managed calling convention for the indirect call.</summary><param name="opcode">The MSIL instruction to be emitted onto the stream. Must be <see cref="F:System.Reflection.Emit.OpCodes.Calli" />. </param><param name="callingConvention">The managed calling convention to be used. </param><param name="returnType">The <see cref="T:System.Type" /> of the result. </param><param name="parameterTypes">The types of the required arguments to the instruction. </param><param name="optionalParameterTypes">The types of the optional arguments for varargs calls. </param><exception cref="T:System.InvalidOperationException"><paramref name="optionalParameterTypes" /> is not null, but <paramref name="callingConvention" /> does not include the <see cref="F:System.Reflection.CallingConventions.VarArgs" /> flag.</exception>
        [SecuritySafeCriticalAttribute()]
        public virtual void EmitCalli(OpCode opcode, CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type[] optionalParameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts a <see cref="F:System.Reflection.Emit.OpCodes.Calli" /> instruction onto the Microsoft intermediate language (MSIL) stream, specifying an unmanaged calling convention for the indirect call.</summary><param name="opcode">The MSIL instruction to be emitted onto the stream. Must be <see cref="F:System.Reflection.Emit.OpCodes.Calli" />.</param><param name="unmanagedCallConv">The unmanaged calling convention to be used. </param><param name="returnType">The <see cref="T:System.Type" /> of the result. </param><param name="parameterTypes">The types of the required arguments to the instruction. </param>
        public virtual void EmitCalli(OpCode opcode, CallingConvention unmanagedCallConv, Type returnType, Type[] parameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts a call or callvirt instruction onto the Microsoft intermediate language (MSIL) stream to call a varargs method.</summary><param name="opcode">The MSIL instruction to be emitted onto the stream. Must be <see cref="F:System.Reflection.Emit.OpCodes.Call" />, <see cref="F:System.Reflection.Emit.OpCodes.Callvirt" />, or <see cref="F:System.Reflection.Emit.OpCodes.Newobj" />.</param><param name="methodInfo">The varargs method to be called. </param><param name="optionalParameterTypes">The types of the optional arguments if the method is a varargs method; otherwise, null. </param><exception cref="T:System.ArgumentException"><paramref name="opcode" /> does not specify a method call.</exception><exception cref="T:System.ArgumentNullException"><paramref name="methodInfo" /> is null. </exception><exception cref="T:System.InvalidOperationException">The calling convention for the method is not varargs, but optional parameter types are supplied. This exception is thrown in the .NET Framework versions 1.0 and 1.1, In subsequent versions, no exception is thrown.</exception>
        [SecuritySafeCriticalAttribute()]
        public virtual void EmitCall(OpCode opcode, MethodInfo methodInfo, Type[] optionalParameterTypes)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction and a signature token onto the Microsoft intermediate language (MSIL) stream of instructions.</summary><param name="opcode">The MSIL instruction to be emitted onto the stream. </param><param name="signature">A helper for constructing a signature token. </param><exception cref="T:System.ArgumentNullException"><paramref name="signature" /> is null. </exception>
        public virtual void Emit(OpCode opcode, SignatureHelper signature)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction and metadata token for the specified constructor onto the Microsoft intermediate language (MSIL) stream of instructions.</summary><param name="opcode">The MSIL instruction to be emitted onto the stream. </param><param name="con">A ConstructorInfo representing a constructor. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> is null. This exception is new in the .NET Framework 4.</exception>
        [ComVisibleAttribute(true)]
        [SecuritySafeCriticalAttribute()]
        public virtual void Emit(OpCode opcode, ConstructorInfo con)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream followed by the metadata token for the given type.</summary><param name="opcode">The MSIL instruction to be put onto the stream. </param><param name="cls">A Type. </param><exception cref="T:System.ArgumentNullException"><paramref name="cls" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual void Emit(OpCode opcode, Type cls)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary><param name="opcode">The MSIL instruction to be put onto the stream. </param><param name="arg">The numerical argument pushed onto the stream immediately after the instruction. </param>
        public virtual void Emit(OpCode opcode, long arg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary><param name="opcode">The MSIL instruction to be put onto the stream. </param><param name="arg">The Single argument pushed onto the stream immediately after the instruction. </param>
        [SecuritySafeCriticalAttribute()]
        public virtual void Emit(OpCode opcode, float arg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction and numerical argument onto the Microsoft intermediate language (MSIL) stream of instructions.</summary><param name="opcode">The MSIL instruction to be put onto the stream. Defined in the OpCodes enumeration. </param><param name="arg">The numerical argument pushed onto the stream immediately after the instruction. </param>
        [SecuritySafeCriticalAttribute()]
        public virtual void Emit(OpCode opcode, double arg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream and leaves space to include a label when fixes are done.</summary><param name="opcode">The MSIL instruction to be emitted onto the stream. </param><param name="label">The label to which to branch from this location. </param>
        public virtual void Emit(OpCode opcode, Label label)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream and leaves space to include a label when fixes are done.</summary><param name="opcode">The MSIL instruction to be emitted onto the stream. </param><param name="labels">The array of label objects to which to branch from this location. All of the labels will be used. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> is null. This exception is new in the .NET Framework 4.</exception>
        public virtual void Emit(OpCode opcode, Label[] labels)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction and metadata token for the specified field onto the Microsoft intermediate language (MSIL) stream of instructions.</summary><param name="opcode">The MSIL instruction to be emitted onto the stream. </param><param name="field">A FieldInfo representing a field. </param>
        public virtual void Emit(OpCode opcode, FieldInfo field)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream followed by the metadata token for the given string.</summary><param name="opcode">The MSIL instruction to be emitted onto the stream. </param><param name="str">The String to be emitted. </param>
        public virtual void Emit(OpCode opcode, string str)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Puts the specified instruction onto the Microsoft intermediate language (MSIL) stream followed by the index of the given local variable.</summary><param name="opcode">The MSIL instruction to be emitted onto the stream. </param><param name="local">A local variable. </param><exception cref="T:System.ArgumentException">The parent method of the <paramref name="local" /> parameter does not match the method associated with this <see cref="T:System.Reflection.Emit.ILGenerator" />. </exception><exception cref="T:System.ArgumentNullException"><paramref name="local" /> is null. </exception><exception cref="T:System.InvalidOperationException"><paramref name="opcode" /> is a single-byte instruction, and <paramref name="local" /> represents a local variable with an index greater than Byte.MaxValue. </exception>
        public virtual void Emit(OpCode opcode, LocalBuilder local)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Label BeginExceptionBlock()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void EndExceptionBlock()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void BeginExceptFilterBlock()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Begins a catch block.</summary><param name="exceptionType">The <see cref="T:System.Type" /> object that represents the exception. </param><exception cref="T:System.ArgumentException">The catch block is within a filtered exception. </exception><exception cref="T:System.ArgumentNullException"><paramref name="exceptionType" /> is null, and the exception filter block has not returned a value that indicates that finally blocks should be run until this catch block is located. </exception><exception cref="T:System.NotSupportedException">The Microsoft intermediate language (MSIL) being generated is not currently in an exception block. </exception>
        public virtual void BeginCatchBlock(Type exceptionType)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void BeginFaultBlock()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void BeginFinallyBlock()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Label DefineLabel()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Marks the Microsoft intermediate language (MSIL) stream's current position with the given label.</summary><param name="loc">The label for which to set an index. </param><exception cref="T:System.ArgumentException"><paramref name="loc" /> represents an invalid index into the label array.-or- An index for <paramref name="loc" /> has already been defined. </exception>
        public virtual void MarkLabel(Label loc)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Emits an instruction to throw an exception.</summary><param name="excType">The class of the type of exception to throw. </param><exception cref="T:System.ArgumentException"><paramref name="excType" /> is not the <see cref="T:System.Exception" /> class or a derived class of <see cref="T:System.Exception" />.-or- The type does not have a default constructor. </exception><exception cref="T:System.ArgumentNullException"><paramref name="excType" /> is null. </exception>
        public virtual void ThrowException(Type excType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Emits the Microsoft intermediate language (MSIL) to call <see cref="Overload:System.Console.WriteLine" /> with a string.</summary><param name="value">The string to be printed. </param>
        public virtual void EmitWriteLine(string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Emits the Microsoft intermediate language (MSIL) necessary to call <see cref="Overload:System.Console.WriteLine" /> with the given local variable.</summary><param name="localBuilder">The local variable whose value is to be written to the console. </param><exception cref="T:System.ArgumentException">The type of <paramref name="localBuilder" /> is <see cref="T:System.Reflection.Emit.TypeBuilder" /> or <see cref="T:System.Reflection.Emit.EnumBuilder" />, which are not supported. -or-There is no overload of <see cref="Overload:System.Console.WriteLine" /> that accepts the type of <paramref name="localBuilder" />. </exception><exception cref="T:System.ArgumentNullException"><paramref name="localBuilder" /> is null. </exception>
        public virtual void EmitWriteLine(LocalBuilder localBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Emits the Microsoft intermediate language (MSIL) necessary to call <see cref="Overload:System.Console.WriteLine" /> with the given field.</summary><param name="fld">The field whose value is to be written to the console. </param><exception cref="T:System.ArgumentException">There is no overload of the <see cref="Overload:System.Console.WriteLine" /> method that accepts the type of the specified field. </exception><exception cref="T:System.ArgumentNullException"><paramref name="fld" /> is null. </exception><exception cref="T:System.NotSupportedException">The type of the field is <see cref="T:System.Reflection.Emit.TypeBuilder" /> or <see cref="T:System.Reflection.Emit.EnumBuilder" />, which are not supported. </exception>
        public virtual void EmitWriteLine(FieldInfo fld)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Declares a local variable of the specified type.</summary><returns>The declared local variable.</returns><param name="localType">A <see cref="T:System.Type" /> object that represents the type of the local variable. </param><exception cref="T:System.ArgumentNullException"><paramref name="localType" /> is null. </exception><exception cref="T:System.InvalidOperationException">The containing type has been created by the <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> method. </exception>
        public virtual LocalBuilder DeclareLocal(Type localType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Declares a local variable of the specified type, optionally pinning the object referred to by the variable.</summary><returns>A <see cref="T:System.Reflection.Emit.LocalBuilder" /> object that represents the local variable.</returns><param name="localType">A <see cref="T:System.Type" /> object that represents the type of the local variable.</param><param name="pinned">true to pin the object in memory; otherwise, false.</param><exception cref="T:System.ArgumentNullException"><paramref name="localType" /> is null. </exception><exception cref="T:System.InvalidOperationException">The containing type has been created by the <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> method.-or-The method body of the enclosing method has been created by the <see cref="M:System.Reflection.Emit.MethodBuilder.CreateMethodBody(System.Byte[],System.Int32)" /> method. </exception><exception cref="T:System.NotSupportedException">The method with which this <see cref="T:System.Reflection.Emit.ILGenerator" /> is associated is not represented by a <see cref="T:System.Reflection.Emit.MethodBuilder" />.</exception>
        public virtual LocalBuilder DeclareLocal(Type localType, bool pinned)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Specifies the namespace to be used in evaluating locals and watches for the current active lexical scope.</summary><param name="usingNamespace">The namespace to be used in evaluating locals and watches for the current active lexical scope </param><exception cref="T:System.ArgumentException">Length of <paramref name="usingNamespace" /> is zero. </exception><exception cref="T:System.ArgumentNullException"><paramref name="usingNamespace" /> is null. </exception><exception cref="T:System.NotSupportedException">This <see cref="T:System.Reflection.Emit.ILGenerator" /> belongs to a <see cref="T:System.Reflection.Emit.DynamicMethod" />.</exception>
        public virtual void UsingNamespace(string usingNamespace)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Marks a sequence point in the Microsoft intermediate language (MSIL) stream.</summary><param name="document">The document for which the sequence point is being defined. </param><param name="startLine">The line where the sequence point begins. </param><param name="startColumn">The column in the line where the sequence point begins. </param><param name="endLine">The line where the sequence point ends. </param><param name="endColumn">The column in the line where the sequence point ends. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="startLine" /> or <paramref name="endLine" /> is &lt;= 0. </exception><exception cref="T:System.NotSupportedException">This <see cref="T:System.Reflection.Emit.ILGenerator" /> belongs to a <see cref="T:System.Reflection.Emit.DynamicMethod" />.</exception>
        public virtual void MarkSequencePoint(ISymbolDocumentWriter document, int startLine, int startColumn, int endLine, int endColumn)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void BeginScope()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void EndScope()
        {
             throw new NotImplementedException();
        }



        void _ILGenerator.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _ILGenerator.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _ILGenerator.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _ILGenerator.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
