using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeThrowExceptionStatement : CodeStatement
    {
    
        public CodeExpression ToThrow
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeThrowExceptionStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeThrowExceptionStatement(CodeExpression toThrow)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
