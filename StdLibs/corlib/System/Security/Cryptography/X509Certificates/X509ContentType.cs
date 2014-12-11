using System.Runtime.InteropServices;
using System;

namespace System.Security.Cryptography.X509Certificates
{
    /// <summary>Specifies the format of an X.509 certificate. </summary>
    [ComVisibleAttribute(true)]
    public enum X509ContentType : int
    {
        /// <summary>An unknown X.509 certificate.  </summary>
        Unknown = 0,
        /// <summary>A single X.509 certificate.</summary>
        Cert = 1,
        /// <summary>A single serialized X.509 certificate. </summary>
        SerializedCert = 2,
        /// <summary>A PFX-formatted certificate. The Pfx value is identical to the Pkcs12 value.</summary>
        Pfx = 3,
        /// <summary>A PKCS #12–formatted certificate. The Pkcs12 value is identical to the Pfx value.</summary>
        Pkcs12 = 3,
        /// <summary>A serialized store.</summary>
        SerializedStore = 4,
        /// <summary>A PKCS #7–formatted certificate.</summary>
        Pkcs7 = 5,
        /// <summary>An Authenticode X.509 certificate. </summary>
        Authenticode = 6
    }
}
