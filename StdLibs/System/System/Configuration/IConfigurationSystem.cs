using System.Runtime.InteropServices;

namespace System.Configuration
{
    [ComVisibleAttribute(false)]
    public interface IConfigurationSystem
    {
        object GetConfig(string configKey);
        
        
        void Init();
        
        
    }
}
