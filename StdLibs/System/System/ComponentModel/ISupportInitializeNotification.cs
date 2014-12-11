using System;

namespace System.ComponentModel
{
    public interface ISupportInitializeNotification : ISupportInitialize
    {
        event EventHandler Initialized;
    
    
        bool IsInitialized
        {
            get;
        }
    
    
    }
}
