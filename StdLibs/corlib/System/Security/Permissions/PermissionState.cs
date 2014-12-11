using System.Runtime.InteropServices;
using System;

namespace System.Security.Permissions
{
    /// <summary>Specifies whether a permission should have all or no access to resources at creation.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum PermissionState : int
    {
        /// <summary>Full access to the resource protected by the permission.</summary>
        Unrestricted = 1,
        /// <summary>No access to the resource protected by the permission.</summary>
        None = 0
    }
}
