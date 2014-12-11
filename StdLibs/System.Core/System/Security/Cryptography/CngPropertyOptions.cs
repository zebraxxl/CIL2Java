using System;

namespace System.Security.Cryptography
{
    [FlagsAttribute()]
    public enum CngPropertyOptions : int
    {
        None = 0,
        CustomProperty = 1073741824,
        Persist = -2147483648
    }
}
