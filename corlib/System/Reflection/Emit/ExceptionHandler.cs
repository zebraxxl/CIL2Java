using System.Runtime.InteropServices;
using System;
using System.Reflection;

namespace System.Reflection.Emit
{
    /// <summary>Represents an exception handler in a byte array of IL to be passed to a method such as <see cref="M:System.Reflection.Emit.MethodBuilder.SetMethodBody(System.Byte[],System.Int32,System.Byte[],System.Collections.Generic.IEnumerable{System.Reflection.Emit.ExceptionHandler},System.Collections.Generic.IEnumerable{System.Int32})" />.</summary>
    [ComVisibleAttribute(false)]
    public struct ExceptionHandler : IEquatable<ExceptionHandler>
    {
    
        /// <summary>Gets the token of the exception type handled by this handler.</summary><returns>The token of the exception type handled by this handler, or 0 if none exists.</returns>
        public int ExceptionTypeToken
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the byte offset at which the code that is protected by this exception handler begins.</summary><returns>The byte offset at which the code that is protected by this exception handler begins.</returns>
        public int TryOffset
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the length, in bytes, of the code protected by this exception handler.</summary><returns>The length, in bytes, of the code protected by this exception handler.</returns>
        public int TryLength
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the byte offset at which the filter code for the exception handler begins.</summary><returns>The byte offset at which the filter code begins, or 0 if no filter  is present.</returns>
        public int FilterOffset
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the byte offset of the first instruction of the exception handler.</summary><returns>The byte offset of the first instruction of the exception handler.</returns>
        public int HandlerOffset
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the length, in bytes, of the exception handler.</summary><returns>The length, in bytes, of the exception handler.</returns>
        public int HandlerLength
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value that represents the kind of exception handler this object represents.</summary><returns>One of the enumeration values that specifies the kind of exception handler.</returns>
        public ExceptionHandlingClauseOptions Kind
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.Emit.ExceptionHandler" /> class with the specified parameters.</summary><param name="tryOffset">The byte offset of the first instruction protected by this exception handler.</param><param name="tryLength">The number of bytes protected by this exception handler.</param><param name="filterOffset">The byte offset of the beginning of the filter code. The filter code ends at the first instruction of the handler block. For non-filter exception handlers, specify 0 (zero) for this parameter.</param><param name="handlerOffset">The byte offset of the first instruction of this exception handler.</param><param name="handlerLength">The number of bytes in this exception handler.</param><param name="kind">One of the enumeration values that specifies the kind of exception handler.</param><param name="exceptionTypeToken">The token of the exception type handled by this exception handler. If not applicable, specify 0 (zero).</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="tryOffset" />, <paramref name="filterOffset" />, <paramref name="handlerOffset" />, <paramref name="tryLength" />, or <paramref name="handlerLength" /> are negative.</exception>
        public ExceptionHandler(int tryOffset, int tryLength, int filterOffset, int handlerOffset, int handlerLength, ExceptionHandlingClauseOptions kind, int exceptionTypeToken)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether this instance of the <see cref="T:System.Reflection.Emit.ExceptionHandler" /> object is equal to a specified object.</summary><returns>true if <paramref name="obj" /> and this instance are equal; otherwise, false.</returns><param name="obj">The object to compare this instance to.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether this instance of the <see cref="T:System.Reflection.Emit.ExceptionHandler" /> object is equal to another <see cref="T:System.Reflection.Emit.ExceptionHandler" /> object.</summary><returns>true if <paramref name="other" /> and this instance are equal; otherwise, false.</returns><param name="other">The exception handler object to compare this instance to.</param>
        public bool Equals(ExceptionHandler other)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified instances of <see cref="T:System.Reflection.Emit.ExceptionHandler" /> are equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Determines whether two specified instances of <see cref="T:System.Reflection.Emit.ExceptionHandler" /> are equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator ==(ExceptionHandler left, ExceptionHandler right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines whether two specified instances of <see cref="T:System.Reflection.Emit.ExceptionHandler" /> are not equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Determines whether two specified instances of <see cref="T:System.Reflection.Emit.ExceptionHandler" /> are not equal.</summary><returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator !=(ExceptionHandler left, ExceptionHandler right)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
