
namespace System.Security
{
    /// <summary>Provides a base class for requesting the security status of an action from the <see cref="T:System.AppDomainManager" /> object.</summary>
    [SecurityCriticalAttribute()]
    public abstract class SecurityState
    {
        protected SecurityState()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public bool IsStateAvailable()
        {
             throw new NotImplementedException();
        }
        
        
        public abstract void EnsureState();
        
        
    }
}
