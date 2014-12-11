using System;

namespace System.Management.Instrumentation
{
    public enum ManagementHostingModel : int
    {
        Decoupled = 0,
        NetworkService = 1,
        LocalService = 2,
        LocalSystem = 3
    }
}
