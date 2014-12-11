using CIL2Java;
using System.Runtime.InteropServices;

namespace System
{
    /// <summary>The exception that is thrown when there is an attempt to combine two delegates based on the <see cref="T:System.Delegate" /> type instead of the <see cref="T:System.MulticastDelegate" /> type. This class cannot be inherited. </summary><filterpriority>2</filterpriority>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class MulticastNotSupportedException : SystemException
    {
        public MulticastNotSupportedException()
            : base(Local.GetText("This operation cannot be performed with the specified delagates."))
        {
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.MulticastNotSupportedException" /> class with a specified error message.</summary><param name="message">The message that describes the error. </param>
        public MulticastNotSupportedException(string message)
            : base(message)
        {
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.MulticastNotSupportedException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception. </param>
        public MulticastNotSupportedException(string message, Exception inner)
            : base(message, inner)
        {
        }        
    }
}
