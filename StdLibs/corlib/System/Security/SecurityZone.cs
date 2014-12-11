using System.Runtime.InteropServices;
using System;

namespace System.Security
{
    /// <summary>Defines the integer values corresponding to security zones used by security policy.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum SecurityZone : int
    {
        /// <summary>The local computer zone is an implicit zone used for content that exists on the user's computer.</summary>
        MyComputer = 0,
        /// <summary>The local intranet zone is used for content located on a company's intranet. Because the servers and information would be within a company's firewall, a user or company could assign a higher trust level to the content on the intranet.</summary>
        Intranet = 1,
        /// <summary>The trusted sites zone is used for content located on Web sites considered more reputable or trustworthy than other sites on the Internet. Users can use this zone to assign a higher trust level to these sites to minimize the number of authentication requests. The URLs of these trusted Web sites need to be mapped into this zone by the user.</summary>
        Trusted = 2,
        /// <summary>The Internet zone is used for the Web sites on the Internet that do not belong to another zone.</summary>
        Internet = 3,
        /// <summary>The restricted sites zone is used for Web sites with content that could cause, or could have caused, problems when downloaded. The URLs of these untrusted Web sites need to be mapped into this zone by the user.</summary>
        Untrusted = 4,
        /// <summary>No zone is specified.</summary>
        NoZone = -1
    }
}
