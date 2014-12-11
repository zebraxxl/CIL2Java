using System;

namespace System.Net
{
    [FlagsAttribute()]
    public enum AuthenticationSchemes : int
    {
        None = 0,
        Digest = 1,
        Negotiate = 2,
        Ntlm = 4,
        Basic = 8,
        Anonymous = 32768,
        IntegratedWindowsAuthentication = 6
    }
}
