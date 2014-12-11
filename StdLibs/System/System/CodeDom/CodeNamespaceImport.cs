using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeNamespaceImport : CodeObject
    {
    
        public CodeLinePragma LinePragma
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public string Namespace
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeNamespaceImport()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeNamespaceImport(string nameSpace)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
