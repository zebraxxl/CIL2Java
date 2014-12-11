using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeStatement : CodeObject
    {
    
        public CodeLinePragma LinePragma
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeDirectiveCollection StartDirectives
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeDirectiveCollection EndDirectives
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeStatement()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
