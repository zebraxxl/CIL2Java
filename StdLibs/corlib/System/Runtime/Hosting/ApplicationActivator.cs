using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System;
using System.Security;

namespace System.Runtime.Hosting
{
    /// <summary>Provides the base class for the activation of manifest-based assemblies. </summary>
    [ComVisibleAttribute(true)]
    public class ApplicationActivator
    {
        public ApplicationActivator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an instance of the application to be activated, using the specified activation context. </summary><returns>An <see cref="T:System.Runtime.Remoting.ObjectHandle" /> that is a wrapper for the return value of the application execution. The return value must be unwrapped to access the real object.  </returns><param name="activationContext">An <see cref="T:System.ActivationContext" /> that identifies the application to activate.</param><exception cref="T:System.ArgumentNullException"><paramref name="activationContext" /> is null. </exception>
        public virtual ObjectHandle CreateInstance(ActivationContext activationContext)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an instance of the application to be activated, using the specified activation context  and custom activation data.  </summary><returns>An <see cref="T:System.Runtime.Remoting.ObjectHandle" /> that is a wrapper for the return value of the application execution. The return value must be unwrapped to access the real object.</returns><param name="activationContext">An <see cref="T:System.ActivationContext" /> that identifies the application to activate.</param><param name="activationCustomData">Custom activation data.</param><exception cref="T:System.ArgumentNullException"><paramref name="activationContext" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual ObjectHandle CreateInstance(ActivationContext activationContext, string[] activationCustomData)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates an instance of an application using the specified <see cref="T:System.AppDomainSetup" />  object.</summary><returns>An <see cref="T:System.Runtime.Remoting.ObjectHandle" /> that is a wrapper for the return value of the application execution. The return value must be unwrapped to access the real object. </returns><param name="adSetup">An <see cref="T:System.AppDomainSetup" /> object whose <see cref="P:System.AppDomainSetup.ActivationArguments" /> property identifies the application to activate.</param><exception cref="T:System.ArgumentException">The <see cref="P:System.AppDomainSetup.ActivationArguments" /> property of <paramref name="adSetup " />is null. </exception><exception cref="T:System.Security.Policy.PolicyException">The application instance failed to execute because the policy settings on the current application domain do not provide permission for this application to run.</exception>
        [SecuritySafeCriticalAttribute()]
        protected static ObjectHandle CreateInstanceHelper(AppDomainSetup adSetup)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
