using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeLabeledStatement : CodeStatement
    {
    
        public string Label
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeStatement Statement
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeLabeledStatement()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeLabeledStatement(string label)
        {
             throw new NotImplementedException();
        }
        
        
        public CodeLabeledStatement(string label, CodeStatement statement)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
