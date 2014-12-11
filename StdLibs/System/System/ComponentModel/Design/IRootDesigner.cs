using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
    [ComVisibleAttribute(true)]
    public interface IRootDesigner : IDesigner
    {
        ViewTechnology[] SupportedTechnologies
        {
            get;
        }
    
    
        object GetView(ViewTechnology technology);
        
        
    }
}
