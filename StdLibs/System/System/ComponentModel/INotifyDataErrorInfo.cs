using System;
using System.Collections;

namespace System.ComponentModel
{
    public interface INotifyDataErrorInfo
    {
        event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
    
    
        bool HasErrors
        {
            get;
        }
    
    
        IEnumerable GetErrors(string propertyName);
        
        
    }
}
