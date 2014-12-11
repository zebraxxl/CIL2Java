using System.Runtime.InteropServices;
using System;
using System.Threading;
using System.Security;
using CIL2Java;
using java.util.concurrent;
using CIL2Java.VES;
using CIL2Java.Attributes;

namespace System.Runtime.Remoting.Messaging
{
    /// <summary>Encapsulates the results of an asynchronous operation on a delegate.</summary>
    [ComVisibleAttribute(true)]
    public class AsyncResult : IAsyncResult, IMessageSink
    {
        private DelegateRunner runner;
        private object asyncDelegate;
        private AsyncCallback callback;
        private object param;
        private Future task;

        [AlwaysCompile]
        public AsyncResult(DelegateRunner runner, object asyncDelegate, AsyncCallback callback, object param)
        {
            this.runner = runner;
            this.asyncDelegate = asyncDelegate;
            this.callback = callback;
            this.param = param;

            runner.AsyncResult = this;
            runner.OnEnd = callback;
            this.task = ThreadPools.AsyncPool.submit(runner);
            this.CompletedSynchronously = this.task.isDone();
        }

        [AlwaysCompile]
        public CIL2Java.DelegateRunner EndInvoke()
        {
            task.get();
            EndInvokeCalled = true;
            return runner;
        }
    
        /// <summary>Gets a value indicating whether the server has completed the call.</summary><returns>true after the server has completed the call; otherwise, false.</returns>
        public virtual bool IsCompleted
        {
            get { return task.isDone(); }
        }
    
        /// <summary>Gets the delegate object on which the asynchronous call was invoked.</summary><returns>The delegate object on which the asynchronous call was invoked.</returns>
        public virtual object AsyncDelegate
        {
            get { return asyncDelegate; }
        }
    
        /// <summary>Gets the object provided as the last parameter of a BeginInvoke method call.</summary><returns>The object provided as the last parameter of a BeginInvoke method call.</returns>
        public virtual object AsyncState
        {
            get { return param; }
        }
    
        /// <summary>Gets a value indicating whether the BeginInvoke call completed synchronously.</summary><returns>true if the BeginInvoke call completed synchronously; otherwise, false.</returns>
        public virtual bool CompletedSynchronously { get; private set; }
    
        /// <summary>Gets or sets a value indicating whether EndInvoke has been called on the current <see cref="T:System.Runtime.Remoting.Messaging.AsyncResult" />.</summary><returns>true if EndInvoke has been called on the current <see cref="T:System.Runtime.Remoting.Messaging.AsyncResult" />; otherwise, false.</returns>
        public bool EndInvokeCalled { get; set; }
    
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
