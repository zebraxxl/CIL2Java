using System.Runtime.InteropServices;
using System;
using System.Collections;
using System.Reflection;

namespace System.ComponentModel
{
    [ComVisibleAttribute(true)]
    public abstract class MemberDescriptor
    {
        internal MemberDescriptor()
        {
            //TODO: REmove This
        }
    
        protected virtual Attribute[] AttributeArray
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public virtual AttributeCollection Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string Category
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string Description
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool IsBrowsable
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        protected virtual int NameHashCode
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual bool DesignTimeOnly
        {
            get { throw new NotImplementedException(); }
        }
    
        public virtual string DisplayName
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected MemberDescriptor(string name)
        {
             throw new NotImplementedException();
        }
        
        
        protected MemberDescriptor(string name, Attribute[] attributes)
        {
             throw new NotImplementedException();
        }
        
        
        protected MemberDescriptor(MemberDescriptor descr)
        {
             throw new NotImplementedException();
        }
        
        
        protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual AttributeCollection CreateAttributeCollection()
        {
             throw new NotImplementedException();
        }
        
        
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void FillAttributes(IList attributeList)
        {
             throw new NotImplementedException();
        }
        
        
        protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType)
        {
             throw new NotImplementedException();
        }
        
        
        protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual object GetInvocationTarget(Type type, object instance)
        {
             throw new NotImplementedException();
        }
        
        
        protected static ISite GetSite(object component)
        {
             throw new NotImplementedException();
        }
        
        
        [ObsoleteAttribute("This method has been deprecated. Use GetInvocationTarget instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        protected static object GetInvokee(Type componentClass, object component)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
