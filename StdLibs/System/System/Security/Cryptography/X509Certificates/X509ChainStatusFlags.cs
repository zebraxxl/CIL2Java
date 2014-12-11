using System;

namespace System.Security.Cryptography.X509Certificates
{
    [FlagsAttribute()]
    public enum X509ChainStatusFlags : int
    {
        NoError = 0,
        NotTimeValid = 1,
        NotTimeNested = 2,
        Revoked = 4,
        NotSignatureValid = 8,
        NotValidForUsage = 16,
        UntrustedRoot = 32,
        RevocationStatusUnknown = 64,
        Cyclic = 128,
        InvalidExtension = 256,
        InvalidPolicyConstraints = 512,
        InvalidBasicConstraints = 1024,
        InvalidNameConstraints = 2048,
        HasNotSupportedNameConstraint = 4096,
        HasNotDefinedNameConstraint = 8192,
        HasNotPermittedNameConstraint = 16384,
        HasExcludedNameConstraint = 32768,
        PartialChain = 65536,
        CtlNotTimeValid = 131072,
        CtlNotSignatureValid = 262144,
        CtlNotValidForUsage = 524288,
        OfflineRevocation = 16777216,
        NoIssuanceChainPolicy = 33554432
    }
}
