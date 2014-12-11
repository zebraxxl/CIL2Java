using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Collections.Specialized;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeCompileUnit : CodeObject
    {
    
        public CodeNamespaceCollection Namespaces
        {
            get { throw new NotImplementedException(); }
        }
    
        public StringCollection ReferencedAssemblies
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeAttributeDeclarationCollection AssemblyCustomAttributes
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeDirectiveCollection StartDirectives
        {
            get { throw new NotImplementedException(); }
        }
    
        public CodeDirectiveCollection EndDirectives
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeCompileUnit()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
