using System;
using System.Security;

namespace System.Security.Permissions
{
    [Serializable]
    [AttributeUsageAttribute(AttributeTargets.Assembly|AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Constructor|AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class StorePermissionAttribute : CodeAccessSecurityAttribute
    {
    
        public StorePermissionFlags Flags
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool CreateStore
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool DeleteStore
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool EnumerateStores
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool OpenStore
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool AddToStore
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool RemoveFromStore
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public bool EnumerateCertificates
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public StorePermissionAttribute(SecurityAction action)
            : base(action)
        {
             throw new NotImplementedException();
        }
        
        
        public override IPermission CreatePermission()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
