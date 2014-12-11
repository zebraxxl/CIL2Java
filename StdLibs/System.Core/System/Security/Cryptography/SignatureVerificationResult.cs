using System;

namespace System.Security.Cryptography
{
    public enum SignatureVerificationResult : int
    {
        Valid = 0,
        AssemblyIdentityMismatch = 1,
        ContainingSignatureInvalid = 2,
        PublicKeyTokenMismatch = 3,
        PublisherMismatch = 4,
        SystemError = -2146869247,
        InvalidSignerCertificate = -2146869246,
        InvalidCountersignature = -2146869245,
        InvalidCertificateSignature = -2146869244,
        InvalidTimestamp = -2146869243,
        BadDigest = -2146869232,
        BasicConstraintsNotObserved = -2146869223,
        UnknownTrustProvider = -2146762751,
        UnknownVerificationAction = -2146762750,
        BadSignatureFormat = -2146762749,
        CertificateNotExplicitlyTrusted = -2146762748,
        MissingSignature = -2146762496,
        CertificateExpired = -2146762495,
        InvalidTimePeriodNesting = -2146762494,
        InvalidCertificateRole = -2146762493,
        PathLengthConstraintViolated = -2146762492,
        UnknownCriticalExtension = -2146762491,
        CertificateUsageNotAllowed = -2146762490,
        IssuerChainingError = -2146762489,
        CertificateMalformed = -2146762488,
        UntrustedRootCertificate = -2146762487,
        CouldNotBuildChain = -2146762486,
        GenericTrustFailure = -2146762485,
        CertificateRevoked = -2146762484,
        UntrustedTestRootCertificate = -2146762483,
        RevocationCheckFailure = -2146762482,
        InvalidCertificateUsage = -2146762480,
        CertificateExplicitlyDistrusted = -2146762479,
        UntrustedCertificationAuthority = -2146762478,
        InvalidCertificatePolicy = -2146762477,
        InvalidCertificateName = -2146762476
    }
}
