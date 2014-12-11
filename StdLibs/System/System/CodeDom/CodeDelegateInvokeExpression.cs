using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeDelegateInvokeExpression : CodeExpression
    {
    
        public CodeExpression TargetObject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeExpressionCollection Parameters
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeDelegateInvokeExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeDelegateInvokeExpression(CodeExpression targetObject)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeDelegateInvokeExpression(CodeExpression targetObject, params  CodeExpression[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
