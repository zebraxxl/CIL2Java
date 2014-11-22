using System.Runtime.InteropServices;
using System;
using System.Security;

namespace System.Diagnostics
{
    /// <summary>Enables communication with a debugger. This class cannot be inherited.</summary><filterpriority>1</filterpriority>
    [ComVisibleAttribute(true)]
    public sealed class Debugger
    {
        /// <summary>Represents the default category of message with a constant.</summary><filterpriority>1</filterpriority>
        public static readonly string DefaultCategory;
    
        /// <summary>Gets a value that indicates whether a debugger is attached to the process.</summary><returns>true if a debugger is attached; otherwise, false.</returns><filterpriority>1</filterpriority>
        public static bool IsAttached
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [ObsoleteAttribute("Do not create instances of the Debugger class.  Call the static methods directly on this type instead", true)]
        public Debugger()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static void Break()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static bool Launch()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public static void NotifyOfCrossThreadDependency()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Posts a message for the attached debugger.</summary><param name="level">A description of the importance of the message. </param><param name="category">The category of the message. </param><param name="message">The message to show. </param><filterpriority>1</filterpriority>
        [SecuritySafeCriticalAttribute()]
        public static void Log(int level, string category, string message)
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        public static bool IsLogging()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
