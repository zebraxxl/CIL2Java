using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
    /// <summary>Implements password-based key derivation functionality, PBKDF2, by using a pseudo-random number generator based on <see cref="T:System.Security.Cryptography.HMACSHA1" />.</summary>
    [ComVisibleAttribute(true)]
    public class Rfc2898DeriveBytes : DeriveBytes
    {
    
        /// <summary>Gets or sets the number of iterations for the operation.</summary><returns>The number of iterations for the operation.</returns><exception cref="T:System.ArgumentOutOfRangeException">The number of iterations is less than 1. </exception>
        public int IterationCount
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the key salt value for the operation.</summary><returns>The key salt value for the operation.</returns><exception cref="T:System.ArgumentException">The specified salt size is smaller than 8 bytes. </exception><exception cref="T:System.ArgumentNullException">The salt is null. </exception>
        public byte[] Salt
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> class using the password and salt size to derive the key.</summary><param name="password">The password used to derive the key. </param><param name="saltSize">The size of the random salt that you want the class to generate. </param><exception cref="T:System.ArgumentException">The specified salt size is smaller than 8 bytes. </exception><exception cref="T:System.ArgumentNullException">The password or salt is null. </exception>
        public Rfc2898DeriveBytes(string password, int saltSize)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> class using a password, a salt size, and number of iterations to derive the key.</summary><param name="password">The password used to derive the key. </param><param name="saltSize">The size of the random salt that you want the class to generate. </param><param name="iterations">The number of iterations for the operation. </param><exception cref="T:System.ArgumentException">The specified salt size is smaller than 8 bytes or the iteration count is less than 1. </exception><exception cref="T:System.ArgumentNullException">The password or salt is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="iterations " />is out of range. This parameter requires a non-negative number.</exception>
        public Rfc2898DeriveBytes(string password, int saltSize, int iterations)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> class using a password and salt to derive the key.</summary><param name="password">The password used to derive the key. </param><param name="salt">The key salt used to derive the key. </param><exception cref="T:System.ArgumentException">The specified salt size is smaller than 8 bytes or the iteration count is less than 1. </exception><exception cref="T:System.ArgumentNullException">The password or salt is null. </exception>
        public Rfc2898DeriveBytes(string password, byte[] salt)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> class using a password, a salt, and number of iterations to derive the key.</summary><param name="password">The password used to derive the key. </param><param name="salt">The key salt used to derive the key. </param><param name="iterations">The number of iterations for the operation. </param><exception cref="T:System.ArgumentException">The specified salt size is smaller than 8 bytes or the iteration count is less than 1. </exception><exception cref="T:System.ArgumentNullException">The password or salt is null. </exception>
        public Rfc2898DeriveBytes(string password, byte[] salt, int iterations)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> class using a password, a salt, and number of iterations to derive the key.</summary><param name="password">The password used to derive the key. </param><param name="salt">The key salt used to derive the key.</param><param name="iterations">The number of iterations for the operation. </param><exception cref="T:System.ArgumentException">The specified salt size is smaller than 8 bytes or the iteration count is less than 1. </exception><exception cref="T:System.ArgumentNullException">The password or salt is null. </exception>
        public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the pseudo-random key for this object.</summary><returns>A byte array filled with pseudo-random key bytes.</returns><param name="cb">The number of pseudo-random key bytes to generate. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="cb " />is out of range. This parameter requires a non-negative number.</exception>
        public override byte[] GetBytes(int cb)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Reset()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" /> class and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
