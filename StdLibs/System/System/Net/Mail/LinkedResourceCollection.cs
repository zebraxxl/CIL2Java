using System.Collections.ObjectModel;
using System;

namespace System.Net.Mail
{
    public sealed class LinkedResourceCollection : Collection<LinkedResource>, IDisposable
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
        
        
        protected override void SetItem(int index, LinkedResource item)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void InsertItem(int index, LinkedResource item)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
