using System.Collections;
using System.Reflection;

namespace System.ComponentModel.Design.Serialization
{
    public sealed class InstanceDescriptor
    {
    
        public ICollection Arguments
        {
            get { throw new NotImplementedException(); }
        }
    
        public bool IsComplete
        {
            get { throw new NotImplementedException(); }
        }
    
        public MemberInfo MemberInfo
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public InstanceDescriptor(MemberInfo member, ICollection arguments)
        {
             throw new NotImplementedException();
        }
        
        
        public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete)
        {
             throw new NotImplementedException();
        }
        
        
        public object Invoke()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
