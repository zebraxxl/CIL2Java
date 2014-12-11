using System.Globalization;
using System;

namespace System.ComponentModel
{
    public class CultureInfoConverter : TypeConverter
    {
    
    
        protected virtual string GetCultureName(CultureInfo culture)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
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
        
        
        public CultureInfoConverter()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
