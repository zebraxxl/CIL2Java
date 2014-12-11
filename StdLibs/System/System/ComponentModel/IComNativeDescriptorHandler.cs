using System;

namespace System.ComponentModel
{
    [ObsoleteAttribute("This interface has been deprecated. Add a TypeDescriptionProvider to handle type TypeDescriptor.ComObjectType instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    public interface IComNativeDescriptorHandler
    {
        AttributeCollection GetAttributes(object component);
        
        
        string GetClassName(object component);
        
        
        TypeConverter GetConverter(object component);
        
        
        EventDescriptor GetDefaultEvent(object component);
        
        
        PropertyDescriptor GetDefaultProperty(object component);
        
        
        object GetEditor(object component, Type baseEditorType);
        
        
        string GetName(object component);
        
        
        EventDescriptorCollection GetEvents(object component);
        
        
        EventDescriptorCollection GetEvents(object component, Attribute[] attributes);
        
        
        PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes);
        
        
        object GetPropertyValue(object component, string propertyName, ref bool success);
        
        
        object GetPropertyValue(object component, int dispid, ref bool success);
        
        
    }
}
