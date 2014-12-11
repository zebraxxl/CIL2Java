using System;
using System.Reflection;
using System.Security;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
    /// <summary>Exposes the public members of the <see cref="T:System.Exception" /> class to unmanaged code.</summary>
    [ComVisibleAttribute(true)]
    [GuidAttribute("b36b5c63-42ef-38bc-a07e-0b34c98f164a")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsDual)]
    public interface _Exception
    {
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Exception.Message" /> property.</summary><returns>The error message that explains the reason for the exception, or an empty string("").</returns>
        string Message
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Exception.StackTrace" /> property.</summary><returns>A string that describes the contents of the call stack, with the most recent method call appearing first.</returns>
        string StackTrace
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Exception.HelpLink" /> property.</summary><returns>The Uniform Resource Name (URN) or Uniform Resource Locator (URL) to a help file.</returns>
        string HelpLink
        {
            get;
            set;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Exception.Source" /> property.</summary><returns>The name of the application or the object that causes the error.</returns>
        string Source
        {
            get;
            set;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Exception.InnerException" /> property.</summary><returns>An instance of <see cref="T:System.Exception" /> that describes the error that caused the current exception. The <see cref="P:System.Exception.InnerException" /> property returns the same value that was passed to the constructor, or a null reference (Nothing in Visual Basic) if the inner exception value was not supplied to the constructor. This property is read-only.</returns>
        Exception InnerException
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Exception.TargetSite" /> property.</summary><returns>The <see cref="T:System.Reflection.MethodBase" /> object that threw the current exception.</returns>
        MethodBase TargetSite
        {
            get;
        }
    
    
        string ToString();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Object.Equals(System.Object)" /> method.</summary><returns>true if the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Object" />; otherwise, false.</returns><param name="obj">The <see cref="T:System.Object" /> to compare with the current <see cref="T:System.Object" />.</param>
        bool Equals(object obj);
        
        
        int GetHashCode();
        
        
        Type GetType();
        
        
        Exception GetBaseException();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Exception.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)" /> method</summary><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data about the exception being thrown. </param><param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure that contains contextual information about the source or destination. </param>
        [SecurityCriticalAttribute()]
        void GetObjectData(SerializationInfo info, StreamingContext context);
        
        
    }
}
