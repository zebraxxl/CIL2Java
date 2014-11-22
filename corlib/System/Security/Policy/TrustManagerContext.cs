using System.Runtime.InteropServices;
using System;

namespace System.Security.Policy
{
    /// <summary>Represents the context for the trust manager to consider when making the decision to run an application, and when setting up the security on a new <see cref="T:System.AppDomain" /> in which to run an application.</summary>
    [ComVisibleAttribute(true)]
    public class TrustManagerContext
    {
    
        /// <summary>Gets or sets the type of user interface the trust manager should display.</summary><returns>One of the <see cref="T:System.Security.Policy.TrustManagerUIContext" /> values. The default is <see cref="F:System.Security.Policy.TrustManagerUIContext.Run" />. </returns>
        public virtual TrustManagerUIContext UIContext
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the trust manager should prompt the user for trust decisions.</summary><returns>true to not prompt the user; false to prompt the user. The default is false.</returns>
        public virtual bool NoPrompt
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the application security manager should ignore any persisted decisions and call the trust manager.</summary><returns>true to call the trust manager; otherwise, false. </returns>
        public virtual bool IgnorePersistedDecision
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the trust manager should cache state for this application, to facilitate future requests to determine application trust.</summary><returns>true to cache state data; otherwise, false. The default is false.</returns>
        public virtual bool KeepAlive
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether the user's response to the consent dialog should be persisted. </summary><returns>true to cache state data; otherwise, false. The default is true.</returns>
        public virtual bool Persist
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets the identity of the previous application identity.</summary><returns>An <see cref="T:System.ApplicationIdentity" /> object representing the previous <see cref="T:System.ApplicationIdentity" />.</returns>
        public virtual ApplicationIdentity PreviousApplicationIdentity
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public TrustManagerContext()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.Policy.TrustManagerContext" /> class using the specified <see cref="T:System.Security.Policy.TrustManagerUIContext" /> object. </summary><param name="uiContext">One of the <see cref="T:System.Security.Policy.TrustManagerUIContext" /> values that specifies the type of trust manager user interface to use. </param>
        public TrustManagerContext(TrustManagerUIContext uiContext)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
