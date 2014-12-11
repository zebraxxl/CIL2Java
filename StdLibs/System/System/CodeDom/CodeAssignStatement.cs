using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeAssignStatement : CodeStatement
    {
    
        public CodeExpression Left
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeExpression Right
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeAssignStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeAssignStatement(CodeExpression left, CodeExpression right)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
