using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Dynamic
{
    public sealed class ExpandoObject : IDynamicMetaObjectProvider, IDictionary<String, Object>, ICollection<KeyValuePair<String, Object>>, IEnumerable<KeyValuePair<String, Object>>, INotifyPropertyChanged
    {
    
    
    
        public ExpandoObject()
        {
             throw new NotImplementedException();
        }



        DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Linq.Expressions.Expression parameter)
        {
            throw new NotImplementedException();
        }

        void IDictionary<string, object>.Add(string key, object value)
        {
            throw new NotImplementedException();
        }

        bool IDictionary<string, object>.ContainsKey(string key)
        {
            throw new NotImplementedException();
        }

        ICollection<string> IDictionary<string, object>.Keys
        {
            get { throw new NotImplementedException(); }
        }

        bool IDictionary<string, object>.Remove(string key)
        {
            throw new NotImplementedException();
        }

        bool IDictionary<string, object>.TryGetValue(string key, out object value)
        {
            throw new NotImplementedException();
        }

        ICollection<object> IDictionary<string, object>.Values
        {
            get { throw new NotImplementedException(); }
        }

        object IDictionary<string, object>.this[string key]
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

        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> item)
        {
            throw new NotImplementedException();
        }

        void ICollection<KeyValuePair<string, object>>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> item)
        {
            throw new NotImplementedException();
        }

        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        int ICollection<KeyValuePair<string, object>>.Count
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<KeyValuePair<string, object>>.IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> item)
        {
            throw new NotImplementedException();
        }

        IEnumerator<KeyValuePair<string, object>> IEnumerable<KeyValuePair<string, object>>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        Collections.IEnumerator Collections.IEnumerable.GetEnumerator()
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
