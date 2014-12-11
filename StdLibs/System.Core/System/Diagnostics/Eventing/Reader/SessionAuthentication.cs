using System;

namespace System.Diagnostics.Eventing.Reader
{
    public enum SessionAuthentication : int
    {
        Default = 0,
        Negotiate = 1,
        Kerberos = 2,
        Ntlm = 3
    }
}
