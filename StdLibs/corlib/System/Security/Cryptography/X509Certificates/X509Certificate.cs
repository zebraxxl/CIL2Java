using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System;

namespace System.Security.Cryptography.X509Certificates
{
    /// <summary>Provides methods that help you use X.509 v.3 certificates.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class X509Certificate : IDeserializationCallback, ISerializable
    {
    
        /// <summary>Gets a handle to a Microsoft Cryptographic API certificate context described by an unmanaged PCCERT_CONTEXT structure. </summary><returns>An <see cref="T:System.IntPtr" /> structure that represents an unmanaged PCCERT_CONTEXT structure.</returns><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" /></PermissionSet>
        [ComVisibleAttribute(false)]
        public IntPtr Handle
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the name of the certificate authority that issued the X.509v3 certificate.</summary><returns>The name of the certificate authority that issued the X.509v3 certificate.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The certificate handle is invalid.</exception>
        public string Issuer
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the subject distinguished name from the certificate.</summary><returns>The subject distinguished name from the certificate.</returns><exception cref="T:System.Security.Cryptography.CryptographicException">The certificate handle is invalid.</exception>
        public string Subject
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public X509Certificate()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class defined from a sequence of bytes representing an X.509v3 certificate.</summary><param name="data">A byte array containing data from an X.509 certificate.</param><exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception><exception cref="T:System.ArgumentException">The <paramref name="rawData" /> parameter is null.-or-The length of the <paramref name="rawData" /> parameter is 0.</exception>
        public X509Certificate(byte[] data)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using a byte array and a password.</summary><param name="rawData">A byte array containing data from an X.509 certificate.</param><param name="password">The password required to access the X.509 certificate data.</param><exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception><exception cref="T:System.ArgumentException">The <paramref name="rawData" /> parameter is null.-or-The length of the <paramref name="rawData" /> parameter is 0.</exception>
        public X509Certificate(byte[] rawData, string password)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using a byte array and a password.</summary><param name="rawData">A byte array that contains data from an X.509 certificate.</param><param name="password">The password required to access the X.509 certificate data.</param><exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception><exception cref="T:System.ArgumentException">The <paramref name="rawData" /> parameter is null.-or-The length of the <paramref name="rawData" /> parameter is 0.</exception>
        public X509Certificate(byte[] rawData, SecureString password)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using a byte array, a password, and a key storage flag.</summary><param name="rawData">A byte array containing data from an X.509 certificate. </param><param name="password">The password required to access the X.509 certificate data. </param><param name="keyStorageFlags">A bitwise combination of the enumeration values that control where and how to import the certificate. </param><exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception><exception cref="T:System.ArgumentException">The <paramref name="rawData" /> parameter is null.-or-The length of the <paramref name="rawData" /> parameter is 0.</exception>
        public X509Certificate(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using a byte array, a password, and a key storage flag.</summary><param name="rawData">A byte array that contains data from an X.509 certificate. </param><param name="password">The password required to access the X.509 certificate data. </param><param name="keyStorageFlags">A bitwise combination of the enumeration values that control where and how to import the certificate. </param><exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception><exception cref="T:System.ArgumentException">The <paramref name="rawData" /> parameter is null.-or-The length of the <paramref name="rawData" /> parameter is 0.</exception>
        public X509Certificate(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using the name of a PKCS7 signed file. </summary><param name="fileName">The name of a PKCS7 signed file.</param><exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception><exception cref="T:System.ArgumentException">The <paramref name="fileName" /> parameter is null.</exception>
        [SecuritySafeCriticalAttribute()]
        public X509Certificate(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using the name of a PKCS7 signed file and a password to access the certificate.</summary><param name="fileName">The name of a PKCS7 signed file. </param><param name="password">The password required to access the X.509 certificate data. </param><exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception><exception cref="T:System.ArgumentException">The <paramref name="fileName" /> parameter is null.</exception>
        [SecuritySafeCriticalAttribute()]
        public X509Certificate(string fileName, string password)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using a certificate file name and a password.</summary><param name="fileName">The name of a certificate file. </param><param name="password">The password required to access the X.509 certificate data. </param><exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception><exception cref="T:System.ArgumentException">The <paramref name="fileName" /> parameter is null.</exception>
        [SecuritySafeCriticalAttribute()]
        public X509Certificate(string fileName, SecureString password)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using the name of a PKCS7 signed file, a password to access the certificate, and a key storage flag. </summary><param name="fileName">The name of a PKCS7 signed file. </param><param name="password">The password required to access the X.509 certificate data. </param><param name="keyStorageFlags">A bitwise combination of the enumeration values that control where and how to import the certificate. </param><exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception><exception cref="T:System.ArgumentException">The <paramref name="fileName" /> parameter is null.</exception>
        [SecuritySafeCriticalAttribute()]
        public X509Certificate(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using a certificate file name, a password, and a key storage flag. </summary><param name="fileName">The name of a certificate file. </param><param name="password">The password required to access the X.509 certificate data. </param><param name="keyStorageFlags">A bitwise combination of the enumeration values that control where and how to import the certificate. </param><exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception><exception cref="T:System.ArgumentException">The <paramref name="fileName" /> parameter is null.</exception>
        [SecuritySafeCriticalAttribute()]
        public X509Certificate(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using a handle to an unmanaged PCCERT_CONTEXT structure.</summary><param name="handle">A handle to an unmanaged PCCERT_CONTEXT structure.</param><exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception><exception cref="T:System.ArgumentException">The handle parameter does not represent a valid PCCERT_CONTEXT structure.</exception>
        [SecurityCriticalAttribute()]
        public X509Certificate(IntPtr handle)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using another <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class.</summary><param name="cert">A <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class from which to initialize this class. </param><exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception><exception cref="T:System.ArgumentNullException">The value of the <paramref name="cert" /> parameter is null.</exception>
        [SecuritySafeCriticalAttribute()]
        public X509Certificate(X509Certificate cert)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> class using a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object and a <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure.</summary><param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that describes serialization information.</param><param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure that describes how serialization should be performed.</param><exception cref="T:System.Security.Cryptography.CryptographicException">An error with the certificate occurs. For example:The certificate file does not exist.The certificate is invalid.The certificate's password is incorrect.</exception>
        public X509Certificate(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an X.509v3 certificate from the specified PKCS7 signed file.</summary><returns>The newly created X.509 certificate.</returns><param name="filename">The path of the PKCS7 signed file from which to create the X.509 certificate. </param><exception cref="T:System.ArgumentException">The <paramref name="filename" /> parameter is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Create" /></PermissionSet>
        public static X509Certificate CreateFromCertFile(string filename)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an X.509v3 certificate from the specified signed file.</summary><returns>The newly created X.509 certificate.</returns><param name="filename">The path of the signed file from which to create the X.509 certificate. </param><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Create" /></PermissionSet>
        public static X509Certificate CreateFromSignedFile(string filename)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This method has been deprecated.  Please use the Subject property instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        [SecuritySafeCriticalAttribute()]
        public virtual string GetName()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("This method has been deprecated.  Please use the Issuer property instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual string GetIssuerName()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual byte[] GetSerialNumber()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string GetSerialNumberString()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual byte[] GetKeyAlgorithmParameters()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual string GetKeyAlgorithmParametersString()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual string GetKeyAlgorithm()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual byte[] GetPublicKey()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string GetPublicKeyString()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public virtual byte[] GetRawCertData()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string GetRawCertDataString()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual byte[] GetCertHash()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string GetCertHashString()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string GetEffectiveDateString()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string GetExpirationDateString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> objects for equality.</summary><returns>true if the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object is equal to the object specified by the <paramref name="other" /> parameter; otherwise, false.</returns><param name="obj">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object to compare to the current object. </param>
        [ComVisibleAttribute(false)]
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Compares two <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> objects for equality.</summary><returns>true if the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object is equal to the object specified by the <paramref name="other" /> parameter; otherwise, false.</returns><param name="other">An <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object to compare to the current object.</param>
        [SecuritySafeCriticalAttribute()]
        public virtual bool Equals(X509Certificate other)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a string representation of the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object, with extra information, if specified.</summary><returns>A string representation of the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</returns><param name="fVerbose">true to produce the verbose form of the string representation; otherwise, false. </param>
        [SecuritySafeCriticalAttribute()]
        public virtual string ToString(bool fVerbose)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the specified date and time to a string.</summary><returns>A string representation of the value of the <see cref="T:System.DateTime" /> object.</returns><param name="date">The date and time to convert.</param>
        protected static string FormatDate(DateTime date)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual string GetFormat()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Populates the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object with data from a byte array.</summary><param name="rawData">A byte array containing data from an X.509 certificate. </param><exception cref="T:System.ArgumentException">The <paramref name="rawData" /> parameter is null.-or-The length of the <paramref name="rawData" /> parameter is 0.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Create" /></PermissionSet>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public virtual void Import(byte[] rawData)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Populates the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object using data from a byte array, a password, and flags for determining how the private key is imported.</summary><param name="rawData">A byte array containing data from an X.509 certificate. </param><param name="password">The password required to access the X.509 certificate data. </param><param name="keyStorageFlags">A bitwise combination of the enumeration values that control where and how to import the certificate. </param><exception cref="T:System.ArgumentException">The <paramref name="rawData" /> parameter is null.-or-The length of the <paramref name="rawData" /> parameter is 0.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Create" /></PermissionSet>
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public virtual void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Populates an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object using data from a byte array, a password, and a key storage flag.</summary><param name="rawData">A byte array that contains data from an X.509 certificate. </param><param name="password">The password required to access the X.509 certificate data. </param><param name="keyStorageFlags">A bitwise combination of the enumeration values that control where and how to import the certificate. </param><exception cref="T:System.ArgumentException">The <paramref name="rawData" /> parameter is null.-or-The length of the <paramref name="rawData" /> parameter is 0.</exception>
        [SecurityCriticalAttribute()]
        public virtual void Import(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Populates the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object with information from a certificate file.</summary><param name="fileName">The name of a certificate file represented as a string. </param><exception cref="T:System.ArgumentException">The <paramref name="fileName" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Create" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public virtual void Import(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Populates the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object with information from a certificate file, a password, and a <see cref="T:System.Security.Cryptography.X509Certificates.X509KeyStorageFlags" /> value.</summary><param name="fileName">The name of a certificate file represented as a string. </param><param name="password">The password required to access the X.509 certificate data. </param><param name="keyStorageFlags">A bitwise combination of the enumeration values that control where and how to import the certificate. </param><exception cref="T:System.ArgumentException">The <paramref name="fileName" /> parameter is null.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" /><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Create" /></PermissionSet>
        [SecurityCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public virtual void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Populates an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object with information from a certificate file, a password, and a key storage flag.</summary><param name="fileName">The name of a certificate file. </param><param name="password">The password required to access the X.509 certificate data. </param><param name="keyStorageFlags">A bitwise combination of the enumeration values that control where and how to import the certificate. </param><exception cref="T:System.ArgumentException">The <paramref name="fileName" /> parameter is null.</exception>
        [SecurityCriticalAttribute()]
        public virtual void Import(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Exports the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object to a byte array in a format described by one of the <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" /> values. </summary><returns>An array of bytes that represents the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</returns><param name="contentType">One of the <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" /> values that describes how to format the output data. </param><exception cref="T:System.Security.Cryptography.CryptographicException">A value other than <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Cert" />, <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.SerializedCert" />, or <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Pkcs12" /> was passed to the <paramref name="contentType" /> parameter.-or-The certificate could not be exported.</exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Open, Export" /></PermissionSet>
        [ComVisibleAttribute(false)]
        [SecuritySafeCriticalAttribute()]
        public virtual byte[] Export(X509ContentType contentType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Exports the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object to a byte array in a format described by one of the <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" /> values, and using the specified password.</summary><returns>An array of bytes that represents the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</returns><param name="contentType">One of the <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" /> values that describes how to format the output data.</param><param name="password">The password required to access the X.509 certificate data.</param><exception cref="T:System.Security.Cryptography.CryptographicException">A value other than <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Cert" />, <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.SerializedCert" />, or <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Pkcs12" /> was passed to the <paramref name="contentType" /> parameter.-or-The certificate could not be exported.</exception><PermissionSet><IPermission class="System.Security.Permissions.KeyContainerPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Open, Export" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(false)]
        public virtual byte[] Export(X509ContentType contentType, string password)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Exports the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object to a byte array using the specified format and a password.</summary><returns>A byte array that represents the current <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate" /> object.</returns><param name="contentType">One of the <see cref="T:System.Security.Cryptography.X509Certificates.X509ContentType" /> values that describes how to format the output data.</param><param name="password">The password required to access the X.509 certificate data.</param><exception cref="T:System.Security.Cryptography.CryptographicException">A value other than <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Cert" />, <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.SerializedCert" />, or <see cref="F:System.Security.Cryptography.X509Certificates.X509ContentType.Pkcs12" /> was passed to the <paramref name="contentType" /> parameter.-or-The certificate could not be exported.</exception>
        [SecuritySafeCriticalAttribute()]
        public virtual byte[] Export(X509ContentType contentType, SecureString password)
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        [SecurityCriticalAttribute()]
        public virtual void Reset()
        {
             throw new NotImplementedException();
        }



        void IDeserializationCallback.OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
