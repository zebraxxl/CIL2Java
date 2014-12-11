using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security;

namespace System.Diagnostics.Eventing.Reader
{
    public class ProviderMetadata : IDisposable
    {
    
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        public Guid Id
        {
            get { throw new NotImplementedException(); }
        }
    
        public string MessageFilePath
        {
            get { throw new NotImplementedException(); }
        }
    
        public string ResourceFilePath
        {
            get { throw new NotImplementedException(); }
        }
    
        public string ParameterFilePath
        {
            get { throw new NotImplementedException(); }
        }
    
        public Uri HelpLink
        {
            get { throw new NotImplementedException(); }
        }
    
        public string DisplayName
        {
            get { throw new NotImplementedException(); }
        }
    
        public IList<EventLogLink> LogLinks
        {
            get { throw new NotImplementedException(); }
        }
    
        public IList<EventLevel> Levels
        {
            get { throw new NotImplementedException(); }
        }
    
        public IList<EventOpcode> Opcodes
        {
            get { throw new NotImplementedException(); }
        }
    
        public IList<EventKeyword> Keywords
        {
            get { throw new NotImplementedException(); }
        }
    
        public IList<EventTask> Tasks
        {
            get { throw new NotImplementedException(); }
        }
    
        public IEnumerable<EventMetadata> Events
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ProviderMetadata(string providerName)
        {
             throw new NotImplementedException();
        }
        
        
        public ProviderMetadata(string providerName, EventLogSession session, CultureInfo targetCultureInfo)
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
        
        
    }
}
