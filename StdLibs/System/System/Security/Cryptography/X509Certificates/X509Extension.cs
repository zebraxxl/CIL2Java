using System.Security.Cryptography;

namespace System.Security.Cryptography.X509Certificates
{
    public class X509Extension : AsnEncodedData
    {
    
        public bool Critical
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        protected X509Extension()
        {
             throw new NotImplementedException();
        }
        
        
        public X509Extension(string oid, byte[] rawData, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Extension(AsnEncodedData encodedExtension, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public X509Extension(Oid oid, byte[] rawData, bool critical)
        {
             throw new NotImplementedException();
        }
        
        
        public override void CopyFrom(AsnEncodedData asnEncodedData)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
