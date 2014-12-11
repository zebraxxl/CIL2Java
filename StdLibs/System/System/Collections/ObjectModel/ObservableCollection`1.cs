using System.Collections.Specialized;
using System.ComponentModel;
using System.Collections.Generic;
using System;

namespace System.Collections.ObjectModel
{
    [Serializable]
    public class ObservableCollection<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {
    
        public virtual event NotifyCollectionChangedEventHandler CollectionChanged;
    
        protected virtual event PropertyChangedEventHandler PropertyChanged;
    
    
        public ObservableCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public ObservableCollection(List<T> list)
        {
             throw new NotImplementedException();
        }
        
        
        public ObservableCollection(IEnumerable<T> collection)
        {
             throw new NotImplementedException();
        }
        
        
        public void Move(int oldIndex, int newIndex)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void ClearItems()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void RemoveItem(int index)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void InsertItem(int index, T item)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void SetItem(int index, T item)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void MoveItem(int oldIndex, int newIndex)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected IDisposable BlockReentrancy()
        {
             throw new NotImplementedException();
        }
        
        
        protected void CheckReentrancy()
        {
             throw new NotImplementedException();
        }



        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }
    }
}
