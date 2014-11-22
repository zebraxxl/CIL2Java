using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
    /// <summary>Indicates that the implementing message sink will be provided by dynamically registered properties.</summary>
    [ComVisibleAttribute(true)]
    public interface IDynamicMessageSink
    {
        /// <summary>Indicates that a call is starting.</summary><param name="reqMsg">A request message. </param><param name="bCliSide">A value of true if the method is invoked on the client side and false if the method is on the server side. </param><param name="bAsync">A value of true if this is an asynchronic call and false if it is a synchronic call. </param>
        [SecurityCriticalAttribute()]
        void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync);
        
        
        /// <summary>Indicates that a call is returning.</summary><param name="replyMsg">A reply message. </param><param name="bCliSide">A value of true if the method is invoked on the client side and false if it is invoked on the server side. </param><param name="bAsync">A value of true if this is an asynchronic call and false if it is a synchronic call. </param>
        [SecurityCriticalAttribute()]
        void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync);
        
        
    }
}
