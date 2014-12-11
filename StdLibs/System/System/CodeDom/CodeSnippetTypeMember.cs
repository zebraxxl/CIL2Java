using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeSnippetTypeMember : CodeTypeMember
    {
    
        public string Text
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeSnippetTypeMember()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeSnippetTypeMember(string text)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
