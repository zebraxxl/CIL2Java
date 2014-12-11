using System.Runtime.InteropServices;
using System.Collections;

namespace System.CodeDom
{
    [Serializable]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    public class CodeObject
    {
    
        public IDictionary UserData
        {
            get { throw new NotImplementedException(); }
        }
    
    
        public CodeObject()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
