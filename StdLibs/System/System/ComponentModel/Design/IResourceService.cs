using System.Resources;
using System.Globalization;

namespace System.ComponentModel.Design
{
    public interface IResourceService
    {
        IResourceReader GetResourceReader(CultureInfo info);
        
        
        IResourceWriter GetResourceWriter(CultureInfo info);
        
        
    }
}
