using System.Runtime.InteropServices;
using System;

namespace System.Diagnostics
{
    [ComVisibleAttribute(true)]
    [GuidAttribute("82840BE1-D273-11D2-B94A-00600893B17A")]
    [ObsoleteAttribute("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    public sealed class PerformanceCounterManager : ICollectData
    {
        [ObsoleteAttribute("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public PerformanceCounterManager()
        {
             throw new NotImplementedException();
        }



        void ICollectData.CollectData(int id, IntPtr valueName, IntPtr data, int totalBytes, ref IntPtr res)
        {
            throw new NotImplementedException();
        }

        void ICollectData.CloseData()
        {
            throw new NotImplementedException();
        }
    }
}
