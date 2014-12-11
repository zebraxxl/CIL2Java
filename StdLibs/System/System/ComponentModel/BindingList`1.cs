using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace System.ComponentModel
{
    [Serializable]
    public class BindingList<T> : Collection<T>, IBindingList, ICancelAddNew, IRaiseItemChangedEvents
    {
    
        public event AddingNewEventHandler AddingNew;
    
        public event ListChangedEventHandler ListChanged;
    
    
        public bool RaiseListChangedEvents
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool AllowNew
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool AllowEdit
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool AllowRemove
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected virtual bool SupportsChangeNotificationCore
        {
            get { throw new NotImplementedException(); }
        }
    
        protected virtual bool SupportsSearchingCore
        {
            get { throw new NotImplementedException(); }
        }
    
        protected virtual bool SupportsSortingCore
        {
            get { throw new NotImplementedException(); }
        }
    
        protected virtual bool IsSortedCore
        {
            get { throw new NotImplementedException(); }
        }
    
        protected virtual PropertyDescriptor SortPropertyCore
        {
            get { throw new NotImplementedException(); }
        }
    
        protected virtual ListSortDirection SortDirectionCore
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public BindingList()
        {
             throw new NotImplementedException();
        }
        
        
        public BindingList(IList<T> list)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnAddingNew(AddingNewEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void OnListChanged(ListChangedEventArgs e)
        {
             throw new NotImplementedException();
        }
        
        
        public void ResetBindings()
        {
             throw new NotImplementedException();
        }
        
        
        public void ResetItem(int position)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void ClearItems()
        {
             throw new NotImplementedException();
        }
        
        
        protected override void InsertItem(int index, T item)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void RemoveItem(int index)
        {
             throw new NotImplementedException();
        }
        
        
        protected override void SetItem(int index, T item)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void CancelNew(int itemIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void EndNew(int itemIndex)
        {
             throw new NotImplementedException();
        }
        
        
        public T AddNew()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual object AddNewCore()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void RemoveSortCore()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual int FindCore(PropertyDescriptor prop, object key)
        {
             throw new NotImplementedException();
        }



        event ListChangedEventHandler IBindingList.ListChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        bool IBindingList.AllowNew
        {
            get { throw new NotImplementedException(); }
        }

        bool IBindingList.AllowEdit
        {
            get { throw new NotImplementedException(); }
        }

        bool IBindingList.AllowRemove
        {
            get { throw new NotImplementedException(); }
        }

        bool IBindingList.SupportsChangeNotification
        {
            get { throw new NotImplementedException(); }
        }

        bool IBindingList.SupportsSearching
        {
            get { throw new NotImplementedException(); }
        }

        bool IBindingList.SupportsSorting
        {
            get { throw new NotImplementedException(); }
        }

        bool IBindingList.IsSorted
        {
            get { throw new NotImplementedException(); }
        }

        PropertyDescriptor IBindingList.SortProperty
        {
            get { throw new NotImplementedException(); }
        }

        ListSortDirection IBindingList.SortDirection
        {
            get { throw new NotImplementedException(); }
        }

        object IBindingList.AddNew()
        {
            throw new NotImplementedException();
        }

        void IBindingList.AddIndex(PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }

        void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
        {
            throw new NotImplementedException();
        }

        int IBindingList.Find(PropertyDescriptor property, object key)
        {
            throw new NotImplementedException();
        }

        void IBindingList.RemoveIndex(PropertyDescriptor property)
        {
            throw new NotImplementedException();
        }

        void IBindingList.RemoveSort()
        {
            throw new NotImplementedException();
        }

        int Collections.IList.Add(object value)
        {
            throw new NotImplementedException();
        }

        void Collections.IList.Clear()
        {
            throw new NotImplementedException();
        }

        bool Collections.IList.Contains(object value)
        {
            throw new NotImplementedException();
        }

        int Collections.IList.IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        void Collections.IList.Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        bool Collections.IList.IsFixedSize
        {
            get { throw new NotImplementedException(); }
        }

        bool Collections.IList.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        void Collections.IList.Remove(object value)
        {
            throw new NotImplementedException();
        }

        void Collections.IList.RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        object Collections.IList.this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        void Collections.ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        int Collections.ICollection.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool Collections.ICollection.IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        object Collections.ICollection.SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        Collections.IEnumerator Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        bool IRaiseItemChangedEvents.RaisesItemChangedEvents
        {
            get { throw new NotImplementedException(); }
        }
    }
}
