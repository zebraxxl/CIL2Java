using System.Runtime.InteropServices;

namespace System.Security
{
    /// <summary>Manages the stack walk that determines whether all callers in the call stack have the required permissions to access a protected resource.</summary>
    [ComVisibleAttribute(true)]
    public interface IStackWalk
    {
        void Assert();
        
        
        void Demand();
        
        
        void Deny();
        
        
        void PermitOnly();
        
        
    }
}
