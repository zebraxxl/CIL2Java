using System.Security;

namespace System.IO.IsolatedStorage
{
    /// <summary>Provides settings for maintaining the quota size for isolated storage. </summary>
    [SecurityCriticalAttribute()]
    public class IsolatedStorageSecurityState : SecurityState
    {
    
        /// <summary>Gets the option for managing isolated storage security. </summary><returns>The option to increase the isolated quota storage size.</returns>
        public IsolatedStorageSecurityOptions Options
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the current usage size in isolated storage.</summary><returns>The current usage size, in bytes.</returns>
        public long UsedSize
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the current size of the quota for isolated storage.</summary><returns>The current quota size, in bytes.</returns>
        public long Quota
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        [SecurityCriticalAttribute()]
        public override void EnsureState()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
