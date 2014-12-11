using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections;

namespace System.Security.Authentication.ExtendedProtection
{
    [Serializable]
    [TypeConverterAttribute(typeof(ExtendedProtectionPolicyTypeConverter))]
    public class ExtendedProtectionPolicy : ISerializable
    {
    
        public ServiceNameCollection CustomServiceNames
        {
            get { throw new NotImplementedException(); }
        }
    
        public PolicyEnforcement PolicyEnforcement
        {
            get { throw new NotImplementedException(); }
        }
    
        public ProtectionScenario ProtectionScenario
        {
            get { throw new NotImplementedException(); }
        }
    
        public ChannelBinding CustomChannelBinding
        {
            get { throw new NotImplementedException(); }
        }
    
        public static bool OSSupportsExtendedProtection
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement, ProtectionScenario protectionScenario, ServiceNameCollection customServiceNames)
        {
             throw new NotImplementedException();
        }
        
        
        public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement, ProtectionScenario protectionScenario, ICollection customServiceNames)
        {
             throw new NotImplementedException();
        }
        
        
        public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement, ChannelBinding customChannelBinding)
        {
             throw new NotImplementedException();
        }
        
        
        public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement)
        {
             throw new NotImplementedException();
        }
        
        
        protected ExtendedProtectionPolicy(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        public override string ToString()
        {
             throw new NotImplementedException();
        }



        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
