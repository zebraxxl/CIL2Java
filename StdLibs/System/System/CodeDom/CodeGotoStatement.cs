using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeGotoStatement : CodeStatement
    {
    
        public string Label
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeGotoStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeGotoStatement(string label)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
