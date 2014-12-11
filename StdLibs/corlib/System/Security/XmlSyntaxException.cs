using System.Runtime.InteropServices;
using System;

namespace System.Security
{
    /// <summary>The exception that is thrown when there is a syntax error in XML parsing. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class XmlSyntaxException : SystemException
    {
        public XmlSyntaxException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.XmlSyntaxException" /> class with a specified error message.</summary><param name="message">The error message that explains the reason for the exception. </param>
        public XmlSyntaxException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.XmlSyntaxException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary><param name="message">The error message that explains the reason for the exception. </param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
        public XmlSyntaxException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.XmlSyntaxException" /> class with the line number where the exception was detected.</summary><param name="lineNumber">The line number of the XML stream where the XML syntax error was detected. </param>
        public XmlSyntaxException(int lineNumber)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Security.XmlSyntaxException" /> class with a specified error message and the line number where the exception was detected.</summary><param name="lineNumber">The line number of the XML stream where the XML syntax error was detected. </param><param name="message">The error message that explains the reason for the exception. </param>
        public XmlSyntaxException(int lineNumber, string message)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
