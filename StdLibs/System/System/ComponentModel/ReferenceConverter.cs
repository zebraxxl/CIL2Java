using System;
using System.Globalization;

namespace System.ComponentModel
{
    public class ReferenceConverter : TypeConverter
    {
        internal ReferenceConverter()
        {
            //TODO: REMOVE THIS
        }
    
        public ReferenceConverter(Type type)
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
        
        
        protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
