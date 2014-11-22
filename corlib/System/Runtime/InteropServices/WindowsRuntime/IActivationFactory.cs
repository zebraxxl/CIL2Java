using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.WindowsRuntime
{
    /// <summary>Enables classes to be activated by the Windows Runtime. </summary>
    [GuidAttribute("00000035-0000-0000-C000-000000000046")]
    public interface IActivationFactory
    {
        object ActivateInstance();
        
        
    }
}
