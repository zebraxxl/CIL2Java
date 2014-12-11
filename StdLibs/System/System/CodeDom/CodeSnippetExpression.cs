using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeSnippetExpression : CodeExpression
    {
    
        public string Value
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeSnippetExpression()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeSnippetExpression(string value)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
