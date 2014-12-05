using System.Runtime.InteropServices;
using System;
using System.Threading;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Encapsulates the results of an asynchronous operation on a delegate.</summary>
    [ComVisibleAttribute(true)]
    public class AsyncResult : IAsyncResult, IMessageSink
    {
        private class DummyDelegateRunner : CIL2Java.DelegateRunner
        {
            public override void run()
            {
            }
        }
        // Method to mark all needed parts to compile.
        // Must be never invoked from CIL
        private void DummyLinkMethod()
        {
            new DummyDelegateRunner();
            ((CIL2Java.DelegateRunner)null).OnEnd(null);
            ((CIL2Java.DelegateRunner)null).AsyncResult = null;
            AsyncResult a = new AsyncResult(null, null, null, null);
            a.EndInvoke();
        }

        public AsyncResult(CIL2Java.DelegateRunner runner, object asyncDelegate, AsyncCallback callback, object param)
        {

        }

        public CIL2Java.DelegateRunner EndInvoke()
        {
            return null;
        }
    
        /// <summary>Gets a value indicating whether the server has completed the call.</summary><returns>true after the server has completed the call; otherwise, false.</returns>
        public virtual bool IsCompleted
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the delegate object on which the asynchronous call was invoked.</summary><returns>The delegate object on which the asynchronous call was invoked.</returns>
        public virtual object AsyncDelegate
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the object provided as the last parameter of a BeginInvoke method call.</summary><returns>The object provided as the last parameter of a BeginInvoke method call.</returns>
        public virtual object AsyncState
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the BeginInvoke call completed synchronously.</summary><returns>true if the BeginInvoke call completed synchronously; otherwise, false.</returns>
        public virtual bool CompletedSynchronously
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets or sets a value indicating whether EndInvoke has been called on the current <see cref="T:System.Runtime.Remoting.Messaging.AsyncResult" />.</summary><returns>true if EndInvoke has been called on the current <see cref="T:System.Runtime.Remoting.Messaging.AsyncResult" />; otherwise, false.</returns>
        public bool EndInvokeCalled
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a <see cref="T:System.Threading.WaitHandle" /> that encapsulates Win32 synchronization handles, and allows the implementation of various synchronization schemes.</summary><returns>A <see cref="T:System.Threading.WaitHandle" /> that encapsulates Win32 synchronization handles, and allows the implementation of various synchronization schemes.</returns>
        public virtual WaitHandle AsyncWaitHandle
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the next message sink in the sink chain.</summary><returns>An <see cref="T:System.Runtime.Remoting.Messaging.IMessageSink" /> interface that represents the next message sink in the sink chain.</returns>
        public IMessageSink NextSink
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Sets an <see cref="T:System.Runtime.Remoting.Messaging.IMessageCtrl" /> for the current remote method call, which provides a way to control asynchronous messages after they have been dispatched.</summary><param name="mc">The <see cref="T:System.Runtime.Remoting.Messaging.IMessageCtrl" /> for the current remote method call. </param>
        public virtual void SetMessageCtrl(IMessageCtrl mc)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Synchronously processes a response message returned by a method call on a remote object.</summary><returns>Returns null.</returns><param name="msg">A response message to a method call on a remote object.</param>
        [SecurityCriticalAttribute()]
        public virtual IMessage SyncProcessMessage(IMessage msg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Implements the <see cref="T:System.Runtime.Remoting.Messaging.IMessageSink" /> interface.</summary><returns>No value is returned.</returns><param name="msg">The request <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> interface. </param><param name="replySink">The response <see cref="T:System.Runtime.Remoting.Messaging.IMessageSink" /> interface. </param>
        [SecurityCriticalAttribute()]
        public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual IMessage GetReplyMessage()
        {
             throw new NotImplementedException();
        }
    }
}
