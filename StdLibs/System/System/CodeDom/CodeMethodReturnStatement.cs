using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeMethodReturnStatement : CodeStatement
    {
    
        public CodeExpression Expression
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeMethodReturnStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeMethodReturnStatement(CodeExpression expression)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
