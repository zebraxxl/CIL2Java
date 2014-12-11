using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeAttachEventStatement : CodeStatement
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
    
    
        public CodeAttachEventStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeAttachEventStatement(CodeEventReferenceExpression eventRef, CodeExpression listener)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeAttachEventStatement(CodeExpression targetObject, string eventName, CodeExpression listener)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
