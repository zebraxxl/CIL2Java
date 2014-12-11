using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeComment : CodeObject
    {
    
        public bool DocComment
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Text
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeComment()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeComment(string text)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeComment(string text, bool docComment)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
