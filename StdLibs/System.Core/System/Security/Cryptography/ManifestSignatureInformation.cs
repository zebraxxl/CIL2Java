using System.Security.Cryptography.X509Certificates;
using System.Security;
using System;

namespace System.Security.Cryptography
{
    public sealed class ManifestSignatureInformation
    {
    
        public AuthenticodeSignatureInformation AuthenticodeSignature
        {
            get { throw new NotImplementedException(); }
        }
    
        public ManifestKinds Manifest
        {
            get { throw new NotImplementedException(); }
        }
    
        public StrongNameSignatureInformation StrongNameSignature
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public static ManifestSignatureInformationCollection VerifySignature(ActivationContext application)
        {
             throw new NotImplementedException();
        }
        
        
        public static ManifestSignatureInformationCollection VerifySignature(ActivationContext application, ManifestKinds manifests)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static ManifestSignatureInformationCollection VerifySignature(ActivationContext application, ManifestKinds manifests, X509RevocationFlag revocationFlag, X509RevocationMode revocationMode)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
