using System;
using System.Security;
using System.Collections.Generic;
using System.Globalization;

namespace System.Diagnostics.Eventing.Reader
{
    public class EventLogSession : IDisposable
    {
    
        public static EventLogSession GlobalSession
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [SecurityCriticalAttribute()]
        public EventLogSession()
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogSession(string server)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public EventLogSession(string server, string domain, string user, SecureString password, SessionAuthentication logOnType)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        [SecuritySafeCriticalAttribute()]
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void CancelCurrentOperations()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public IEnumerable<string> GetProviderNames()
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public IEnumerable<string> GetLogNames()
        {
             throw new NotImplementedException();
        }
        
        
        public EventLogInformation GetLogInformation(string logName, PathType pathType)
        {
             throw new NotImplementedException();
        }
        
        
        public void ExportLog(string path, PathType pathType, string query, string targetFilePath)
        {
             throw new NotImplementedException();
        }
        
        
        public void ExportLog(string path, PathType pathType, string query, string targetFilePath, bool tolerateQueryErrors)
        {
             throw new NotImplementedException();
        }
        
        
        public void ExportLogAndMessages(string path, PathType pathType, string query, string targetFilePath)
        {
             throw new NotImplementedException();
        }
        
        
        public void ExportLogAndMessages(string path, PathType pathType, string query, string targetFilePath, bool tolerateQueryErrors, CultureInfo targetCultureInfo)
        {
             throw new NotImplementedException();
        }
        
        
        public void ClearLog(string logName)
        {
             throw new NotImplementedException();
        }
        
        
        public void ClearLog(string logName, string backupPath)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
