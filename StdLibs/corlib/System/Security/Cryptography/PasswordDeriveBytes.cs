using System.Runtime.InteropServices;
using System.Security;
using System;

namespace System.Security.Cryptography
{
    /// <summary>Derives a key from a password using an extension of the PBKDF1 algorithm.</summary>
    [ComVisibleAttribute(true)]
    public class PasswordDeriveBytes : DeriveBytes
    {
    
        /// <summary>Gets or sets the name of the hash algorithm for the operation.</summary><returns>The name of the hash algorithm for the operation.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The name of the hash value is fixed and an attempt is made to change this value. </exception>
        public string HashName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the number of iterations for the operation.</summary><returns>The number of iterations for the operation.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The number of iterations is fixed and an attempt is made to change this value. </exception><exception cref="T:System.ArgumentOutOfRangeException">The property cannot be set because its value is out of range. This property requires a non-negative number.</exception>
        public int IterationCount
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the key salt value for the operation.</summary><returns>The key salt value for the operation.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The key salt value is fixed and an attempt is made to change this value. </exception>
        public byte[] Salt
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class with the password and key salt to use to derive the key.</summary><param name="strPassword">The password for which to derive the key. </param><param name="rgbSalt">The key salt to use to derive the key. </param>
        public PasswordDeriveBytes(string strPassword, byte[] rgbSalt)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class specifying the password and key salt to use to derive the key.</summary><param name="password">The password to derive the key for.</param><param name="salt">The key salt to use to derive the key.</param>
        public PasswordDeriveBytes(byte[] password, byte[] salt)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class with the password, key salt, hash name, and number of iterations to use to derive the key.</summary><param name="strPassword">The password for which to derive the key. </param><param name="rgbSalt">The key salt to use to derive the key. </param><param name="strHashName">The name of the hash algorithm for the operation. </param><param name="iterations">The number of iterations for the operation. </param>
        public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class specifying the password, key salt, hash name, and iterations to use to derive the key.</summary><param name="password">The password to derive the key for.</param><param name="salt">The key salt to use to derive the key.</param><param name="hashName">The hash algorithm to use to derive the key.</param><param name="iterations">The iteration count to use to derive the key.</param>
        public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class with the password, key salt, and cryptographic service provider (CSP) parameters to use to derive the key.</summary><param name="strPassword">The password for which to derive the key. </param><param name="rgbSalt">The key salt to use to derive the key. </param><param name="cspParams">The CSP parameters for the operation. </param>
        public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, CspParameters cspParams)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class specifying the password, key salt, and cryptographic service provider (CSP) to use to derive the key.</summary><param name="password">The password to derive the key for.</param><param name="salt">The key salt to use to derive the key.</param><param name="cspParams">The cryptographic service provider (CSP) parameters for the operation.</param>
        public PasswordDeriveBytes(byte[] password, byte[] salt, CspParameters cspParams)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class with the password, key salt, hash name, number of iterations, and cryptographic service provider (CSP) parameters to use to derive the key.</summary><param name="strPassword">The password for which to derive the key. </param><param name="rgbSalt">The key salt to use to derive the key. </param><param name="strHashName">The name of the hash algorithm for the operation. </param><param name="iterations">The number of iterations for the operation. </param><param name="cspParams">The CSP parameters for the operation. </param>
        public PasswordDeriveBytes(string strPassword, byte[] rgbSalt, string strHashName, int iterations, CspParameters cspParams)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class specifying the password, key salt, hash name, iterations, and cryptographic service provider (CSP) to use to derive the key.</summary><param name="password">The password to derive the key for.</param><param name="salt">The key salt to use to derive the key.</param><param name="hashName">The hash algorithm to use to derive the key.</param><param name="iterations">The iteration count to use to derive the key.</param><param name="cspParams">The cryptographic service provider (CSP) parameters for the operation.</param>
        [SecuritySafeCriticalAttribute()]
        public PasswordDeriveBytes(byte[] password, byte[] salt, string hashName, int iterations, CspParameters cspParams)
        {
             throw new NotImplementedException();
        }


#pragma warning disable 809
        /// <summary>Returns pseudo-random key bytes.</summary><returns>A byte array filled with pseudo-random key bytes.</returns><param name="cb">The number of pseudo-random key bytes to generate. </param>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("Rfc2898DeriveBytes replaces PasswordDeriveBytes for deriving key material from a password and is preferred in new applications.")]
        public override byte[] GetBytes(int cb)
        {
             throw new NotImplementedException();
        }
#pragma warning restore 809

        public override void Reset()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> class and optionally releases the managed resources.</summary><param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
        protected override void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Derives a cryptographic key from the <see cref="T:System.Security.Cryptography.PasswordDeriveBytes" /> object.</summary><returns>The derived key.</returns><param name="algname">The algorithm name for which to derive the key. </param><param name="alghashname">The hash algorithm name to use to derive the key. </param><param name="keySize">The size of the key, in bits, to derive. </param><param name="rgbIV">The initialization vector (IV) to use to derive the key. </param><exception cref="T:System.Security.Cryptography.CryptographicException">The <paramref name="keySize" /> parameter is incorrect.-or- The cryptographic service provider (CSP) cannot be acquired.-or- The <paramref name="algname" /> parameter is not a valid algorithm name.-or- The <paramref name="alghashname" /> parameter is not a valid hash algorithm name. </exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
