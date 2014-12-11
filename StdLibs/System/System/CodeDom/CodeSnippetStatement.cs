using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeSnippetStatement : CodeStatement
    {
    
        public string Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeSnippetStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeSnippetStatement(string value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
