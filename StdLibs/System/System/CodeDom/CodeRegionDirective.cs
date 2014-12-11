using System.Runtime.InteropServices;

namespace System.CodeDom
{
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
    [ComVisibleAttribute(true)]
    public class CodeRegionDirective : CodeDirective
    {
    
        public string RegionText
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
        public CodeRegionMode RegionMode
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        public CodeRegionDirective()
        {
             throw new NotImplementedException();
        }
        
        
        public CodeRegionDirective(CodeRegionMode regionMode, string regionText)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
