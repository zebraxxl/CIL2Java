using System;
using System.Runtime.ExceptionServices;

namespace System.Security
{
    /// <summary>Represents text that should be kept confidential. The text is encrypted for privacy when being used, and deleted from computer memory when no longer needed. This class cannot be inherited.</summary>
    public sealed class SecureString : IDisposable
    {
    
        /// <summary>Gets the number of characters in the current secure string.</summary><returns>The number of <see cref="T:System.Char" /> objects in this secure string.</returns><exception cref="T:System.ObjectDisposedException">This secure string has already been disposed.</exception>
        public int Length
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [SecuritySafeCriticalAttribute()]
        public SecureString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.SecureString" /> class from a subarray of <see cref="T:System.Char" /> objects.</summary><param name="value">A pointer to an array of <see cref="T:System.Char" /> objects.</param><param name="length">The number of elements of <paramref name="value" /> to include in the new instance.</param><exception cref="T:System.ArgumentNullException"><paramref name="value" /> is null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="length" /> is less than zero or greater than 65536.</exception><exception cref="T:System.Security.Cryptography.CryptographicException">An error occurred while encrypting or decrypting the value of this secure string.</exception><exception cref="T:System.NotSupportedException">This operation is not supported on this platform.</exception>
        [SecurityCriticalAttribute()]
        public unsafe SecureString(char* value, int length)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Appends a character to the end of the current secure string.</summary><param name="c">A character to append to this secure string.</param><exception cref="T:System.ObjectDisposedException">This secure string has already been disposed.</exception><exception cref="T:System.InvalidOperationException">This secure string is read-only.</exception><exception cref="T:System.ArgumentOutOfRangeException">Performing this operation would make the length of this secure string greater than 65536 characters.</exception><exception cref="T:System.Security.Cryptography.CryptographicException">An error occurred while encrypting or decrypting the value of this secure string.</exception>
        [HandleProcessCorruptedStateExceptionsAttribute()]
        [SecuritySafeCriticalAttribute()]
        public void AppendChar(char c)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Clear()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public SecureString Copy()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Inserts a character in this secure string at the specified index position.</summary><param name="index">The index position where parameter <paramref name="c" /> is inserted.</param><param name="c">The character to insert.</param><exception cref="T:System.ObjectDisposedException">This secure string has already been disposed.</exception><exception cref="T:System.InvalidOperationException">This secure string is read-only.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero, or greater than the length of this secure string.-or-Performing this operation would make the length of this secure string greater than 65536 characters.</exception><exception cref="T:System.Security.Cryptography.CryptographicException">An error occurred while encrypting or decrypting the value of this secure string.</exception>
        [HandleProcessCorruptedStateExceptionsAttribute()]
        [SecuritySafeCriticalAttribute()]
        public void InsertAt(int index, char c)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public bool IsReadOnly()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public void MakeReadOnly()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes the character at the specified index position from this secure string.</summary><param name="index">The index position of a character in this secure string.</param><exception cref="T:System.ObjectDisposedException">This secure string has already been disposed.</exception><exception cref="T:System.InvalidOperationException">This secure string is read-only.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero, or greater than or equal to the length of this secure string.</exception><exception cref="T:System.Security.Cryptography.CryptographicException">An error occurred while encrypting or decrypting the value of this secure string.</exception>
        [HandleProcessCorruptedStateExceptionsAttribute()]
        [SecuritySafeCriticalAttribute()]
        public void RemoveAt(int index)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Replaces the existing character at the specified index position with another character.</summary><param name="index">The index position of an existing character in this secure string</param><param name="c">A character that replaces the existing character.</param><exception cref="T:System.ObjectDisposedException">This secure string has already been disposed.</exception><exception cref="T:System.InvalidOperationException">This secure string is read-only.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index" /> is less than zero, or greater than or equal to the length of this secure string.</exception><exception cref="T:System.Security.Cryptography.CryptographicException">An error occurred while encrypting or decrypting the value of this secure string.</exception>
        [HandleProcessCorruptedStateExceptionsAttribute()]
        [SecuritySafeCriticalAttribute()]
        public void SetAt(int index, char c)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
