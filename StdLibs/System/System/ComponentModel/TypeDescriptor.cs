using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Reflection;

namespace System.ComponentModel
{
    public sealed class TypeDescriptor
    {
    
        public static event RefreshEventHandler Refreshed;
    
    
        [ObsoleteAttribute("This property has been deprecated.  Use a type description provider to supply type information for COM types instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public static IComNativeDescriptorHandler ComNativeDescriptorHandler
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static Type ComObjectType
        {
            get { throw new NotImplementedException(); }
        }
    
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static Type InterfaceType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static TypeDescriptionProvider AddAttributes(Type type, params  Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static TypeDescriptionProvider AddAttributes(object instance, params  Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static void AddEditorTable(Type editorBaseType, Hashtable table)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static void AddProvider(TypeDescriptionProvider provider, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static void AddProvider(TypeDescriptionProvider provider, object instance)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static void AddProviderTransparent(TypeDescriptionProvider provider, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static void AddProviderTransparent(TypeDescriptionProvider provider, object instance)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static void CreateAssociation(object primary, object secondary)
        {
             throw new NotImplementedException();
        }
        
        
        public static IDesigner CreateDesigner(IComponent component, Type designerBaseType)
        {
             throw new NotImplementedException();
        }
        
        
        public static EventDescriptor CreateEvent(Type componentType, string name, Type type, params  Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public static EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, params  Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
        {
             throw new NotImplementedException();
        }
        
        
        public static PropertyDescriptor CreateProperty(Type componentType, string name, Type type, params  Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public static PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, params  Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static object GetAssociation(Type type, object primary)
        {
             throw new NotImplementedException();
        }
        
        
        public static AttributeCollection GetAttributes(Type componentType)
        {
             throw new NotImplementedException();
        }
        
        
        public static AttributeCollection GetAttributes(object component)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc)
        {
             throw new NotImplementedException();
        }
        
        
        public static string GetClassName(object component)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static string GetClassName(object component, bool noCustomTypeDesc)
        {
             throw new NotImplementedException();
        }
        
        
        public static string GetClassName(Type componentType)
        {
             throw new NotImplementedException();
        }
        
        
        public static string GetComponentName(object component)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static string GetComponentName(object component, bool noCustomTypeDesc)
        {
             throw new NotImplementedException();
        }
        
        
        public static TypeConverter GetConverter(object component)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static TypeConverter GetConverter(object component, bool noCustomTypeDesc)
        {
             throw new NotImplementedException();
        }
        
        
        public static TypeConverter GetConverter(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static EventDescriptor GetDefaultEvent(Type componentType)
        {
             throw new NotImplementedException();
        }
        
        
        public static EventDescriptor GetDefaultEvent(object component)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc)
        {
             throw new NotImplementedException();
        }
        
        
        public static PropertyDescriptor GetDefaultProperty(Type componentType)
        {
             throw new NotImplementedException();
        }
        
        
        public static PropertyDescriptor GetDefaultProperty(object component)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc)
        {
             throw new NotImplementedException();
        }
        
        
        public static object GetEditor(object component, Type editorBaseType)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static object GetEditor(object component, Type editorBaseType, bool noCustomTypeDesc)
        {
             throw new NotImplementedException();
        }
        
        
        public static object GetEditor(Type type, Type editorBaseType)
        {
             throw new NotImplementedException();
        }
        
        
        public static EventDescriptorCollection GetEvents(Type componentType)
        {
             throw new NotImplementedException();
        }
        
        
        public static EventDescriptorCollection GetEvents(Type componentType, Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public static EventDescriptorCollection GetEvents(object component)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc)
        {
             throw new NotImplementedException();
        }
        
        
        public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc)
        {
             throw new NotImplementedException();
        }
        
        
        public static string GetFullComponentName(object component)
        {
             throw new NotImplementedException();
        }
        
        
        public static PropertyDescriptorCollection GetProperties(Type componentType)
        {
             throw new NotImplementedException();
        }
        
        
        public static PropertyDescriptorCollection GetProperties(Type componentType, Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public static PropertyDescriptorCollection GetProperties(object component)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc)
        {
             throw new NotImplementedException();
        }
        
        
        public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static TypeDescriptionProvider GetProvider(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static TypeDescriptionProvider GetProvider(object instance)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static Type GetReflectionType(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static Type GetReflectionType(object instance)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Refresh(object component)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Refresh(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Refresh(Module module)
        {
             throw new NotImplementedException();
        }
        
        
        public static void Refresh(Assembly assembly)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static void RemoveAssociation(object primary, object secondary)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static void RemoveAssociations(object primary)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static void RemoveProvider(TypeDescriptionProvider provider, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static void RemoveProvider(TypeDescriptionProvider provider, object instance)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static void RemoveProviderTransparent(TypeDescriptionProvider provider, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        [EditorBrowsableAttribute(EditorBrowsableState.Advanced)]
        public static void RemoveProviderTransparent(TypeDescriptionProvider provider, object instance)
        {
             throw new NotImplementedException();
        }
        
        
        public static void SortDescriptorArray(IList infos)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
