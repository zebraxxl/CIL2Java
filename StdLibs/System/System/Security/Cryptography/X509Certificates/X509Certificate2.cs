using System;
using System.Security.Cryptography;
using System.Security;
using System.Runtime.Serialization;

namespace System.Security.Cryptography.X509Certificates
{
    [Serializable]
    public class X509Certificate2 : X509Certificate
    {
    
        public bool Archived
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public X509ExtensionCollection Extensions
        {
            get { throw new NotImplementedException(); }
        }
    
        public string FriendlyName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public X500DistinguishedName IssuerName
        {
            get { throw new NotImplementedException(); }
        }
    
        public DateTime NotAfter
        {
            get { throw new NotImplementedException(); }
        }
    
        public DateTime NotBefore
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool HasPrivateKey
        {
            get { throw new NotImplementedException(); }
        }
    
        public AsymmetricAlgorithm PrivateKey
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public PublicKey PublicKey
        {
            get { throw new NotImplementedException(); }
        }
    
        public byte[] RawData
        {
            get { throw new NotImplementedException(); }
        }
    
        public string SerialNumber
        {
            get { throw new NotImplementedException(); }
        }
    
        public X500DistinguishedName SubjectName
        {
            get { throw new NotImplementedException(); }
        }
    
        public Oid SignatureAlgorithm
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Thumbprint
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Version
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public X509Certificate2()
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2(byte[] rawData)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2(byte[] rawData, string password)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2(byte[] rawData, SecureString password)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2(string fileName, string password)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2(string fileName, SecureString password)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2(IntPtr handle)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Certificate2(X509Certificate certificate)
        {
             throw new NotImplementedException();
        }
        
        
        protected X509Certificate2(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString(bool verbose)
        {
             throw new NotImplementedException();
        }
        
        
        public string GetNameInfo(X509NameType nameType, bool forIssuer)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Import(byte[] rawData)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Import(byte[] rawData, SecureString password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Import(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Import(string fileName, SecureString password, X509KeyStorageFlags keyStorageFlags)
        {
             throw new NotImplementedException();
        }
        
        
        public override void Reset()
        {
             throw new NotImplementedException();
        }
        
        
        public bool Verify()
        {
             throw new NotImplementedException();
        }
        
        
        public static X509ContentType GetCertContentType(byte[] rawData)
        {
             throw new NotImplementedException();
        }
        
        
        public static X509ContentType GetCertContentType(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
