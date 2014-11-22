using System.Runtime.InteropServices;
using System;

namespace System.Reflection
{
    /// <summary>Represents a clause in a structured exception-handling block.</summary>
    [ComVisibleAttribute(true)]
    public class ExceptionHandlingClause
    {
    
        /// <summary>Gets a value indicating whether this exception-handling clause is a finally clause, a type-filtered clause, or a user-filtered clause.</summary><returns>An <see cref="T:System.Reflection.ExceptionHandlingClauseOptions" /> value that indicates what kind of action this clause performs.</returns>
        public virtual ExceptionHandlingClauseOptions Flags
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>The offset within the method, in bytes, of the try block that includes this exception-handling clause.</summary><returns>An integer that represents the offset within the method, in bytes, of the try block that includes this exception-handling clause.</returns>
        public virtual int TryOffset
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>The total length, in bytes, of the try block that includes this exception-handling clause.</summary><returns>The total length, in bytes, of the try block that includes this exception-handling clause.</returns>
        public virtual int TryLength
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the offset within the method body, in bytes, of this exception-handling clause.</summary><returns>An integer that represents the offset within the method body, in bytes, of this exception-handling clause.</returns>
        public virtual int HandlerOffset
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the length, in bytes, of the body of this exception-handling clause.</summary><returns>An integer that represents the length, in bytes, of the MSIL that forms the body of this exception-handling clause.</returns>
        public virtual int HandlerLength
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the offset within the method body, in bytes, of the user-supplied filter code.</summary><returns>The offset within the method body, in bytes, of the user-supplied filter code. The value of this property has no meaning if the <see cref="P:System.Reflection.ExceptionHandlingClause.Flags" /> property has any value other than <see cref="F:System.Reflection.ExceptionHandlingClauseOptions.Filter" />.</returns><exception cref="T:System.InvalidOperationException">Cannot get the offset because the exception handling clause is not a filter.</exception>
        public virtual int FilterOffset
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the type of exception handled by this clause.</summary><returns>A <see cref="T:System.Type" /> object that represents that type of exception handled by this clause, or null if the <see cref="P:System.Reflection.ExceptionHandlingClause.Flags" /> property is <see cref="F:System.Reflection.ExceptionHandlingClauseOptions.Filter" /> or <see cref="F:System.Reflection.ExceptionHandlingClauseOptions.Finally" />.</returns><exception cref="T:System.InvalidOperationException">Invalid use of property for the object's current state.</exception>
        public virtual Type CatchType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected ExceptionHandlingClause()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
