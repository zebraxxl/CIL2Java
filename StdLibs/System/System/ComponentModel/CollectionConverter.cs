using System.Globalization;
using System;

namespace System.ComponentModel
{
    public class CollectionConverter : TypeConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
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
        
        
        public CollectionConverter()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
