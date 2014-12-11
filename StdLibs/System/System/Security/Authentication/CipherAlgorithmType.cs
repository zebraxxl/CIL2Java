using System;

namespace System.Security.Authentication
{
    public enum CipherAlgorithmType : int
    {
        None = 0,
        Rc2 = 26114,
        Rc4 = 26625,
        Des = 26113,
        TripleDes = 26115,
        Aes = 26129,
        Aes128 = 26126,
        Aes192 = 26127,
        Aes256 = 26128,
        Null = 24576
    }
}
