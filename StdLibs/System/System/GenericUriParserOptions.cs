
namespace System
{
    [FlagsAttribute()]
    public enum GenericUriParserOptions : int
    {
        Default = 0,
        GenericAuthority = 1,
        AllowEmptyAuthority = 2,
        NoUserInfo = 4,
        NoPort = 8,
        NoQuery = 16,
        NoFragment = 32,
        DontConvertPathBackslashes = 64,
        DontCompressPath = 128,
        DontUnescapePathDotsAndSlashes = 256,
        Idn = 512,
        IriParsing = 1024
    }
}
