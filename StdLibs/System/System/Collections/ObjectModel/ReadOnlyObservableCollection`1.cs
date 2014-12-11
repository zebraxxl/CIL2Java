using System.Collections.Specialized;
using System.ComponentModel;

namespace System.Collections.ObjectModel
{
    [Serializable]
    public class ReadOnlyObservableCollection<T> : ReadOnlyCollection<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {
    
        protected virtual event NotifyCollectionChangedEventHandler CollectionChanged;
    
        protected virtual event PropertyChangedEventHandler PropertyChanged;
    
    
        public ReadOnlyObservableCollection(ObservableCollection<T> list)
            : base(list)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
             throw new NotImplementedException();
        }



        event NotifyCollectionChangedEventHandler INotifyCollectionChanged.CollectionChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }
    }
}
