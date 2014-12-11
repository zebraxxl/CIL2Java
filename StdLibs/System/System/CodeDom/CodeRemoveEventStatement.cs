using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeRemoveEventStatement : CodeStatement
    {
    
        public CodeEventReferenceExpression Event
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeExpression Listener
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeRemoveEventStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeRemoveEventStatement(CodeEventReferenceExpression eventRef, CodeExpression listener)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeRemoveEventStatement(CodeExpression targetObject, string eventName, CodeExpression listener)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
