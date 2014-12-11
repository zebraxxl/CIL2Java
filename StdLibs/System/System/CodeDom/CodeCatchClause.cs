using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeCatchClause
    {
    
        public string LocalName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeTypeReference CatchExceptionType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeStatementCollection Statements
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeCatchClause()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeCatchClause(string localName)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeCatchClause(string localName, CodeTypeReference catchExceptionType)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeCatchClause(string localName, CodeTypeReference catchExceptionType, params  CodeStatement[] statements)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
