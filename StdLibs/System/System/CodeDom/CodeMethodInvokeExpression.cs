using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeMethodInvokeExpression : CodeExpression
    {
    
        public CodeMethodReferenceExpression Method
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeExpressionCollection Parameters
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeMethodInvokeExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeMethodInvokeExpression(CodeMethodReferenceExpression method, params  CodeExpression[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeMethodInvokeExpression(CodeExpression targetObject, string methodName, params  CodeExpression[] parameters)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
