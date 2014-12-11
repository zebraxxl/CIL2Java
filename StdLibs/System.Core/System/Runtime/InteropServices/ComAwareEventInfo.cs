using System.Security;
using System.Reflection;
using System;

namespace System.Runtime.InteropServices
{
    [SecuritySafeCriticalAttribute()]
    public class ComAwareEventInfo : EventInfo
    {
    
        public override EventAttributes Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Type DeclaringType
        {
            get { throw new NotImplementedException(); }
        }
    
        public override string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Type ReflectedType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ComAwareEventInfo(Type type, string eventName)
        {
             throw new NotImplementedException();
        }
        
        
        public override void AddEventHandler(object target, Delegate handler)
        {
             throw new NotImplementedException();
        }
        
        
        public override void RemoveEventHandler(object target, Delegate handler)
        {
             throw new NotImplementedException();
        }
        
        
        public override MethodInfo GetAddMethod(bool nonPublic)
        {
             throw new NotImplementedException();
        }
        
        
        public override MethodInfo GetRaiseMethod(bool nonPublic)
        {
             throw new NotImplementedException();
        }
        
        
        public override MethodInfo GetRemoveMethod(bool nonPublic)
        {
             throw new NotImplementedException();
        }
        
        
        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        public override object[] GetCustomAttributes(bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
        public override bool IsDefined(Type attributeType, bool inherit)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
