using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeBinaryOperatorExpression : CodeExpression
    {
    
        public CodeExpression Right
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeExpression Left
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeBinaryOperatorType Operator
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeBinaryOperatorExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeBinaryOperatorExpression(CodeExpression left, CodeBinaryOperatorType op, CodeExpression right)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
