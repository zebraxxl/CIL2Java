using System.Security.AccessControl;
using System;
using System.Security.Principal;
using System.Security;
using System.Runtime.InteropServices;

namespace System.IO.Pipes
{
    public class PipeSecurity : NativeObjectSecurity
    {
        public override Type AccessRightType
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Type AccessRuleType
        {
            get { throw new NotImplementedException(); }
        }
    
        public override Type AuditRuleType
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public PipeSecurity()
            : base(false, ResourceType.Unknown)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddAccessRule(PipeAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetAccessRule(PipeAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        public void ResetAccessRule(PipeAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        public bool RemoveAccessRule(PipeAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveAccessRuleSpecific(PipeAccessRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        public void AddAuditRule(PipeAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        public void SetAuditRule(PipeAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        public bool RemoveAuditRule(PipeAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveAuditRuleAll(PipeAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        public void RemoveAuditRuleSpecific(PipeAuditRule rule)
        {
             throw new NotImplementedException();
        }
        
        
        public override AccessRule AccessRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AccessControlType type)
        {
             throw new NotImplementedException();
        }


        public override AuditRule AuditRuleFactory(IdentityReference identityReference, int accessMask, bool isInherited, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags flags)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected void Persist(SafeHandle handle)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        protected void Persist(string name)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
