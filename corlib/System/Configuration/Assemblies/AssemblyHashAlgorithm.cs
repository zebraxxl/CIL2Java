using System.Runtime.InteropServices;
using System;

namespace System.Configuration.Assemblies
{
    /// <summary>Specifies all the hash algorithms used for hashing files and for generating the strong name.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum AssemblyHashAlgorithm : int
    {
        /// <summary>A mask indicating that there is no hash algorithm. If you specify None for a multi-module assembly, the common language runtime defaults to the SHA1 algorithm, since multi-module assemblies need to generate a hash.</summary>
        None = 0,
        /// <summary>Retrieves the MD5 message-digest algorithm. MD5 was developed by Rivest in 1991. It is basically MD4 with safety-belts and while it is slightly slower than MD4, it helps provide more security. The algorithm consists of four distinct rounds, which has a slightly different design from that of MD4. Message-digest size, as well as padding requirements, remain the same.</summary>
        MD5 = 32771,
        /// <summary>A mask used to retrieve a revision of the Secure Hash Algorithm that corrects an unpublished flaw in SHA.</summary>
        SHA1 = 32772,
        /// <summary>A mask used to retrieve a version of the Secure Hash Algorithm with a hash size of 256 bits.</summary>
        SHA256 = 32780,
        /// <summary>A mask used to retrieve a version of the Secure Hash Algorithm with a hash size of 384 bits.</summary>
        SHA384 = 32781,
        /// <summary>A mask used to retrieve a version of the Secure Hash Algorithm with a hash size of 512 bits.</summary>
        SHA512 = 32782
    }
}
