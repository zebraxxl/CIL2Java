using System.Runtime.InteropServices;
using System;
using System.Collections;
using System.Globalization;

namespace System.ComponentModel
{
    [ComVisibleAttribute(true)]
    public class TypeConverter
    {
        protected abstract class SimplePropertyDescriptor : PropertyDescriptor
        {
        
            public override Type ComponentType
            {
                get { throw new NotImplementedException(); }
            }
        
            public override bool IsReadOnly
            {
                get { throw new NotImplementedException(); }
            }
        
            public override Type PropertyType
            {
                get { throw new NotImplementedException(); }
            }
        
        
            protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType)
            {
                 throw new NotImplementedException();
            }
            
            
            protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType, Attribute[] attributes)
            {
                 throw new NotImplementedException();
            }
            
            
            public override bool CanResetValue(object component)
            {
                 throw new NotImplementedException();
            }
            
            
            public override void ResetValue(object component)
            {
                 throw new NotImplementedException();
            }
            
            
            public override bool ShouldSerializeValue(object component)
            {
                 throw new NotImplementedException();
            }
            
            
        }
    
        public class StandardValuesCollection : ICollection
        {
        
            public int Count
            {
                get { throw new NotImplementedException(); }
            }
        
            public object this[int index]
            {
                get { throw new NotImplementedException(); }
            }
        
        
            public StandardValuesCollection(ICollection values)
            {
                 throw new NotImplementedException();
            }
            
            
            public void CopyTo(Array array, int index)
            {
                 throw new NotImplementedException();
            }
            
            
            public IEnumerator GetEnumerator()
            {
                 throw new NotImplementedException();
            }



            void ICollection.CopyTo(Array array, int index)
            {
                throw new NotImplementedException();
            }

            int ICollection.Count
            {
                get { throw new NotImplementedException(); }
            }

            bool ICollection.IsSynchronized
            {
                get { throw new NotImplementedException(); }
            }

            object ICollection.SyncRoot
            {
                get { throw new NotImplementedException(); }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    
    
    
        public bool CanConvertFrom(Type sourceType)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
             throw new NotImplementedException();
        }
        
        
        public bool CanConvertTo(Type destinationType)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
             throw new NotImplementedException();
        }
        
        
        public object ConvertFrom(object value)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
             throw new NotImplementedException();
        }
        
        
        public object ConvertFromInvariantString(string text)
        {
             throw new NotImplementedException();
        }
        
        
        public object ConvertFromInvariantString(ITypeDescriptorContext context, string text)
        {
             throw new NotImplementedException();
        }
        
        
        public object ConvertFromString(string text)
        {
             throw new NotImplementedException();
        }
        
        
        public object ConvertFromString(ITypeDescriptorContext context, string text)
        {
             throw new NotImplementedException();
        }
        
        
        public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text)
        {
             throw new NotImplementedException();
        }
        
        
        public object ConvertTo(object value, Type destinationType)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
             throw new NotImplementedException();
        }
        
        
        public string ConvertToInvariantString(object value)
        {
             throw new NotImplementedException();
        }
        
        
        public string ConvertToInvariantString(ITypeDescriptorContext context, object value)
        {
             throw new NotImplementedException();
        }
        
        
        public string ConvertToString(object value)
        {
             throw new NotImplementedException();
        }
        
        
        public string ConvertToString(ITypeDescriptorContext context, object value)
        {
             throw new NotImplementedException();
        }
        
        
        public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
             throw new NotImplementedException();
        }
        
        
        public object CreateInstance(IDictionary propertyValues)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
             throw new NotImplementedException();
        }
        
        
        protected Exception GetConvertFromException(object value)
        {
             throw new NotImplementedException();
        }
        
        
        protected Exception GetConvertToException(object value, Type destinationType)
        {
             throw new NotImplementedException();
        }
        
        
        public bool GetCreateInstanceSupported()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public PropertyDescriptorCollection GetProperties(object value)
        {
             throw new NotImplementedException();
        }
        
        
        public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public bool GetPropertiesSupported()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public ICollection GetStandardValues()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public bool GetStandardValuesExclusive()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public bool GetStandardValuesSupported()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public bool IsValid(object value)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual bool IsValid(ITypeDescriptorContext context, object value)
        {
             throw new NotImplementedException();
        }
        
        
        protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names)
        {
             throw new NotImplementedException();
        }
        
        
        public TypeConverter()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
