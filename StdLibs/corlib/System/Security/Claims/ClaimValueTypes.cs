using System.Runtime.InteropServices;

namespace System.Security.Claims
{
    /// <summary>Defines claim value types according to the type URIs defined by W3C and OASIS. This class cannot be inherited.</summary>
    [ComVisibleAttribute(false)]
    public static class ClaimValueTypes
    {
        /// <summary>A URI that represents the base64Binary XML data type.</summary>
        public const string Base64Binary = "http://www.w3.org/2001/XMLSchema#base64Binary";
        /// <summary>A URI that that represents the base64Octet XML data type.</summary>
        public const string Base64Octet = "http://www.w3.org/2001/XMLSchema#base64Octet";
        /// <summary>A URI that represents the boolean XML data type.</summary>
        public const string Boolean = "http://www.w3.org/2001/XMLSchema#boolean";
        /// <summary>A URI that represents the date XML data type.</summary>
        public const string Date = "http://www.w3.org/2001/XMLSchema#date";
        /// <summary>A URI that represents the dateTime XML data type.</summary>
        public const string DateTime = "http://www.w3.org/2001/XMLSchema#dateTime";
        /// <summary>A URI that represents the double XML data type.</summary>
        public const string Double = "http://www.w3.org/2001/XMLSchema#double";
        /// <summary>A URI that represents the fqbn XML data type.</summary>
        public const string Fqbn = "http://www.w3.org/2001/XMLSchema#fqbn";
        /// <summary>A URI that represents the hexBinary XML data type.</summary>
        public const string HexBinary = "http://www.w3.org/2001/XMLSchema#hexBinary";
        /// <summary>A URI that represents the integer XML data type.</summary>
        public const string Integer = "http://www.w3.org/2001/XMLSchema#integer";
        /// <summary>A URI that represents the integer32 XML data type.</summary>
        public const string Integer32 = "http://www.w3.org/2001/XMLSchema#integer32";
        /// <summary>A URI that represents the integer64 XML data type.</summary>
        public const string Integer64 = "http://www.w3.org/2001/XMLSchema#integer64";
        /// <summary>A URI that represents the sid XML data type.</summary>
        public const string Sid = "http://www.w3.org/2001/XMLSchema#sid";
        /// <summary>A URI that represents the string XML data type.</summary>
        public const string String = "http://www.w3.org/2001/XMLSchema#string";
        /// <summary>A URI that represents the time XML data type.</summary>
        public const string Time = "http://www.w3.org/2001/XMLSchema#time";
        /// <summary>A URI that represents the uinteger32 XML data type.</summary>
        public const string UInteger32 = "http://www.w3.org/2001/XMLSchema#uinteger32";
        /// <summary>A URI that represents the uinteger64 XML data type.</summary>
        public const string UInteger64 = "http://www.w3.org/2001/XMLSchema#uinteger64";
        /// <summary>A URI that represents the dns SOAP data type.</summary>
        public const string DnsName = "http://schemas.xmlsoap.org/claims/dns";
        /// <summary>A URI that represents the emailaddress SOAP data type.</summary>
        public const string Email = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress";
        /// <summary>A URI that represents the rsa SOAP data type.</summary>
        public const string Rsa = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/rsa";
        /// <summary>A URI that represents the UPN SOAP data type.</summary>
        public const string UpnName = "http://schemas.xmlsoap.org/claims/UPN";
        /// <summary>A URI that represents the DSAKeyValue XML Signature data type.</summary>
        public const string DsaKeyValue = "http://www.w3.org/2000/09/xmldsig#DSAKeyValue";
        /// <summary>A URI that represents the KeyInfo XML Signature data type.</summary>
        public const string KeyInfo = "http://www.w3.org/2000/09/xmldsig#KeyInfo";
        /// <summary>A URI that represents the RSAKeyValue XML Signature data type.</summary>
        public const string RsaKeyValue = "http://www.w3.org/2000/09/xmldsig#RSAKeyValue";
        /// <summary>A URI that represents the daytimeDuration XQuery data type.</summary>
        public const string DaytimeDuration = "http://www.w3.org/TR/2002/WD-xquery-operators-20020816#dayTimeDuration";
        /// <summary>A URI that represents the yearMonthDuration XQuery data type.</summary>
        public const string YearMonthDuration = "http://www.w3.org/TR/2002/WD-xquery-operators-20020816#yearMonthDuration";
        /// <summary>A URI that represents the rfc822Name XACML 1.0 data type.</summary>
        public const string Rfc822Name = "urn:oasis:names:tc:xacml:1.0:data-type:rfc822Name";
        /// <summary>A URI that represents the x500Name XACML 1.0 data type.</summary>
        public const string X500Name = "urn:oasis:names:tc:xacml:1.0:data-type:x500Name";
    
    }
}
