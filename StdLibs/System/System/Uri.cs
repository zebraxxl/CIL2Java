using System.ComponentModel;
using System.Runtime.Serialization;

namespace System
{
    [Serializable]
    [TypeConverterAttribute(typeof(UriTypeConverter))]
    public class Uri : ISerializable
    {
        public static readonly string UriSchemeFile;
        public static readonly string UriSchemeFtp;
        public static readonly string UriSchemeGopher;
        public static readonly string UriSchemeHttp;
        public static readonly string UriSchemeHttps;
        public static readonly string UriSchemeMailto;
        public static readonly string UriSchemeNews;
        public static readonly string UriSchemeNntp;
        public static readonly string UriSchemeNetTcp;
        public static readonly string UriSchemeNetPipe;
        public static readonly string SchemeDelimiter;
    
        public string AbsolutePath
        {
            get { throw new NotImplementedException(); }
        }
    
        public string AbsoluteUri
        {
            get { throw new NotImplementedException(); }
        }
    
        public string LocalPath
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Authority
        {
            get { throw new NotImplementedException(); }
        }
    
        public UriHostNameType HostNameType
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsDefaultPort
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsFile
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsLoopback
        {
            get { throw new NotImplementedException(); }
        }
    
        public string PathAndQuery
        {
            get { throw new NotImplementedException(); }
        }
    
        public string[] Segments
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsUnc
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Host
        {
            get { throw new NotImplementedException(); }
        }
    
        public int Port
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Query
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Fragment
        {
            get { throw new NotImplementedException(); }
        }
    
        public string Scheme
        {
            get { throw new NotImplementedException(); }
        }
    
        public string OriginalString
        {
            get { throw new NotImplementedException(); }
        }
    
        public string DnsSafeHost
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsAbsoluteUri
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool UserEscaped
        {
            get { throw new NotImplementedException(); }
        }
    
        public string UserInfo
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public Uri(string uriString)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The constructor has been deprecated. Please use new Uri(string). The dontEscape parameter is deprecated and is always false. http://go.microsoft.com/fwlink/?linkid=14202")]
        public Uri(string uriString, bool dontEscape)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The constructor has been deprecated. Please new Uri(Uri, string). The dontEscape parameter is deprecated and is always false. http://go.microsoft.com/fwlink/?linkid=14202")]
        public Uri(Uri baseUri, string relativeUri, bool dontEscape)
        {
             throw new NotImplementedException();
        }
        
        
        public Uri(string uriString, UriKind uriKind)
        {
             throw new NotImplementedException();
        }
        
        
        public Uri(Uri baseUri, string relativeUri)
        {
             throw new NotImplementedException();
        }
        
        
        public Uri(Uri baseUri, Uri relativeUri)
        {
             throw new NotImplementedException();
        }
        
        
        protected Uri(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
             throw new NotImplementedException();
        }
        
        
        public static UriHostNameType CheckHostName(string name)
        {
             throw new NotImplementedException();
        }
        
        
        public string GetLeftPart(UriPartial part)
        {
             throw new NotImplementedException();
        }
        
        
        public static string HexEscape(char character)
        {
             throw new NotImplementedException();
        }
        
        
        public static char HexUnescape(string pattern, ref int index)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsHexEncoding(string pattern, int index)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool CheckSchemeName(string schemeName)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsHexDigit(char character)
        {
             throw new NotImplementedException();
        }
        
        
        public static int FromHex(char digit)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator ==(Uri uri1, Uri uri2)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool operator !=(Uri uri1, Uri uri2)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object comparand)
        {
             throw new NotImplementedException();
        }
        
        
        public Uri MakeRelativeUri(Uri uri)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The method has been deprecated. Please use MakeRelativeUri(Uri uri). http://go.microsoft.com/fwlink/?linkid=14202")]
        public string MakeRelative(Uri toUri)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void Parse()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void Canonicalize()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void Escape()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The method has been deprecated. Please use GetComponents() or static UnescapeDataString() to unescape a Uri component or a string. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual string Unescape(string path)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The method has been deprecated. Please use GetComponents() or static EscapeUriString() to escape a Uri component or a string. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected static string EscapeString(string str)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void CheckSecurity()
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual bool IsReservedCharacter(char character)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected static bool IsExcludedCharacter(char character)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("The method has been deprecated. It is not used by the system. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual bool IsBadFileSystemCharacter(char character)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryCreate(string uriString, UriKind uriKind, ref Uri result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryCreate(Uri baseUri, string relativeUri, ref Uri result)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool TryCreate(Uri baseUri, Uri relativeUri, ref Uri result)
        {
             throw new NotImplementedException();
        }
        
        
        public string GetComponents(UriComponents components, UriFormat format)
        {
             throw new NotImplementedException();
        }
        
        
        public static int Compare(Uri uri1, Uri uri2, UriComponents partsToCompare, UriFormat compareFormat, StringComparison comparisonType)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsWellFormedOriginalString()
        {
             throw new NotImplementedException();
        }
        
        
        public static bool IsWellFormedUriString(string uriString, UriKind uriKind)
        {
             throw new NotImplementedException();
        }
        
        
        public static string UnescapeDataString(string stringToUnescape)
        {
             throw new NotImplementedException();
        }
        
        
        public static string EscapeUriString(string stringToEscape)
        {
             throw new NotImplementedException();
        }
        
        
        public static string EscapeDataString(string stringToEscape)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsBaseOf(Uri uri)
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
