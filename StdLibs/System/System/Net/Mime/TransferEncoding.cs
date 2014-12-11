using System;

namespace System.Net.Mime
{
    public enum TransferEncoding : int
    {
        QuotedPrintable = 0,
        Base64 = 1,
        SevenBit = 2,
        EightBit = 3,
        Unknown = -1
    }
}
