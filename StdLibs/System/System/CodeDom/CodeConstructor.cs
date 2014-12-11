using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeConstructor : CodeMemberMethod
    {
    
        public CodeExpressionCollection BaseConstructorArgs
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeExpressionCollection ChainedConstructorArgs
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeConstructor()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
