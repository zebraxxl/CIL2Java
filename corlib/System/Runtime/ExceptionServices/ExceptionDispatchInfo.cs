using System;

namespace System.Runtime.ExceptionServices
{
    /// <summary>Represents an exception whose state is captured at a certain point in code. </summary>
    public sealed class ExceptionDispatchInfo
    {
    
        /// <summary>Gets the exception that is represented by the current instance. </summary><returns>The exception that is represented by the current instance. </returns>
        public Exception SourceException
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Creates an <see cref="T:System.Runtime.ExceptionServices.ExceptionDispatchInfo" /> object that represents the specified exception at the current point in code. </summary><returns>An object that represents the specified exception at the current point in code. </returns><param name="source">The exception whose state is captured, and which is represented by the returned object. </param><exception cref="T:System.ArgumentException"><paramref name="source" /> is null. </exception>
        public static ExceptionDispatchInfo Capture(Exception source)
        {
             throw new NotImplementedException();
        }
        
        
        public void Throw()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
