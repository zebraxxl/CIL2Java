using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeMemberEvent : CodeTypeMember
    {
    
        public CodeTypeReference Type
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeTypeReference PrivateImplementationType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeTypeReferenceCollection ImplementationTypes
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeMemberEvent()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
