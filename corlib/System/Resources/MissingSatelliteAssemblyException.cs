using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;

namespace System.Resources
{
    /// <summary>The exception that is thrown when the satellite assembly for the resources of the default culture is missing.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class MissingSatelliteAssemblyException : SystemException
    {
    
        /// <summary>Gets the name of the default culture. </summary><returns>The name of the default culture.</returns>
        public string CultureName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public MissingSatelliteAssemblyException()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.MissingSatelliteAssemblyException" /> class with the specified error message. </summary><param name="message">The error message that explains the reason for the exception.</param>
        public MissingSatelliteAssemblyException(string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.MissingSatelliteAssemblyException" /> class with a specified error message and the name of a neutral culture. </summary><param name="message">The error message that explains the reason for the exception.</param><param name="cultureName">The name of the neutral culture.</param>
        public MissingSatelliteAssemblyException(string message, string cultureName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.MissingSatelliteAssemblyException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception. </summary><param name="message">The error message that explains the reason for the exception.</param><param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception.</param>
        public MissingSatelliteAssemblyException(string message, Exception inner)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.MissingSatelliteAssemblyException" /> class from serialized data. </summary><param name="info">The object that holds the serialized object data.</param><param name="context">The contextual information about the source or destination of the exception.</param>
        protected MissingSatelliteAssemblyException(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
