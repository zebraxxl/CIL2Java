using System;

namespace System.Security.Authentication
{
    public enum ExchangeAlgorithmType : int
    {
        None = 0,
        RsaSign = 9216,
        RsaKeyX = 41984,
        DiffieHellman = 43522
    }
}
