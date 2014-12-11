using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Threading
{
    /// <summary>The exception that is thrown when a call is made to the <see cref="M:System.Threading.Thread.Abort(System.Object)" /> method. This class cannot be inherited.</summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class ThreadAbortException : SystemException
    {
        /// <summary>Gets an object that contains application-specific information related to the thread abort.</summary><returns>An object containing application-specific information.</returns><filterpriority>2</filterpriority>
        public object ExceptionState
        {
            get { throw new NotImplementedException(); }
        }
    
    
    }
}
