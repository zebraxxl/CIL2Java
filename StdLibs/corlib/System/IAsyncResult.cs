using System.Runtime.InteropServices;
using System.Threading;

namespace System
{
    /// <summary>Represents the status of an asynchronous operation. </summary><filterpriority>2</filterpriority>
    [ComVisibleAttribute(true)]
    public interface IAsyncResult
    {
        /// <summary>Gets a value that indicates whether the asynchronous operation has completed.</summary><returns>true if the operation is complete; otherwise, false.</returns><filterpriority>2</filterpriority>
        bool IsCompleted
        {
            get;
        }
    
        /// <summary>Gets a <see cref="T:System.Threading.WaitHandle" /> that is used to wait for an asynchronous operation to complete.</summary><returns>A <see cref="T:System.Threading.WaitHandle" /> that is used to wait for an asynchronous operation to complete.</returns><filterpriority>2</filterpriority>
        WaitHandle AsyncWaitHandle
        {
            get;
        }
    
        /// <summary>Gets a user-defined object that qualifies or contains information about an asynchronous operation.</summary><returns>A user-defined object that qualifies or contains information about an asynchronous operation.</returns><filterpriority>2</filterpriority>
        object AsyncState
        {
            get;
        }
    
        /// <summary>Gets a value that indicates whether the asynchronous operation completed synchronously.</summary><returns>true if the asynchronous operation completed synchronously; otherwise, false.</returns><filterpriority>2</filterpriority>
        bool CompletedSynchronously
        {
            get;
        }
    
    
    }
}
