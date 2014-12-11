using System;

namespace System.Security.Permissions
{
    [Serializable]
    [FlagsAttribute()]
    public enum TypeDescriptorPermissionFlags : int
    {
        NoFlags = 0,
        RestrictedRegistrationAccess = 1
    }
}
