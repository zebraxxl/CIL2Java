using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeExpressionStatement : CodeStatement
    {
    
        public CodeExpression Expression
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeExpressionStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeExpressionStatement(CodeExpression expression)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
