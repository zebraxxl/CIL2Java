using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
    /// <summary>Allows a permission to expose an unrestricted state.</summary>
    [ComVisibleAttribute(true)]
    public interface IUnrestrictedPermission
    {
        bool IsUnrestricted();
        
        
    }
}
