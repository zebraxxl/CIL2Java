using System;
using System.Globalization;
using System.Collections;

namespace System.ComponentModel
{
    public class NullableConverter : TypeConverter
    {
    
        public Type NullableType
        {
            get { throw new NotImplementedException(); }
        }
    
        public Type UnderlyingType
        {
            get { throw new NotImplementedException(); }
        }
    
        public TypeConverter UnderlyingTypeConverter
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public NullableConverter(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
             throw new NotImplementedException();
        }
        
        
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
             throw new NotImplementedException();
        }
        
        
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
             throw new NotImplementedException();
        }
        
        
        public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool IsValid(ITypeDescriptorContext context, object value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
