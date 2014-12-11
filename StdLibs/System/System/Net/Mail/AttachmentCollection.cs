using System.Collections.ObjectModel;
using System;

namespace System.Net.Mail
{
    public sealed class AttachmentCollection : Collection<Attachment>, IDisposable
    {
    
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void RemoveItem(int index)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void ClearItems()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void SetItem(int index, Attachment item)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void InsertItem(int index, Attachment item)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
