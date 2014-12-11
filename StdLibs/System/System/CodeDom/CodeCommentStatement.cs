using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeCommentStatement : CodeStatement
    {
    
        public CodeComment Comment
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeCommentStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeCommentStatement(CodeComment comment)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeCommentStatement(string text)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeCommentStatement(string text, bool docComment)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
