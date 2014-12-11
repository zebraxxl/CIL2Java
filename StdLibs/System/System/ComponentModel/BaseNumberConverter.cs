using System;
using System.Globalization;

namespace System.ComponentModel
{
    public abstract class BaseNumberConverter : TypeConverter
    {
    
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
             throw new NotImplementedException();
        }
        
        
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
             throw new NotImplementedException();
        }
        
        
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool CanConvertTo(ITypeDescriptorContext context, Type t)
        {
             throw new NotImplementedException();
        }
        
        
        protected BaseNumberConverter()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
