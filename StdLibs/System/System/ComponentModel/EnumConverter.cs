using System;
using System.Collections;
using System.Globalization;

namespace System.ComponentModel
{
    public class EnumConverter : TypeConverter
    {
    
        protected Type EnumType
        {
            get { throw new NotImplementedException(); }
        }
    
        protected StandardValuesCollection Values
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        protected virtual IComparer Comparer
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public EnumConverter(Type type)
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
        
        
        public override bool IsValid(ITypeDescriptorContext context, object value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
