using System;

namespace System.Security.Cryptography
{
    public enum ECDiffieHellmanKeyDerivationFunction : int
    {
        Hash = 0,
        Hmac = 1,
        Tls = 2
    }
}
