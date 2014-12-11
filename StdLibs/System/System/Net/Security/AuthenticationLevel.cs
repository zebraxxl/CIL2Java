using System;

namespace System.Net.Security
{
    public enum AuthenticationLevel : int
    {
        None = 0,
        MutualAuthRequested = 1,
        MutualAuthRequired = 2
    }
}
