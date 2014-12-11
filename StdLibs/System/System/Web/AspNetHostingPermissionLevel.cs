using System;

namespace System.Web
{
    [Serializable]
    public enum AspNetHostingPermissionLevel : int
    {
        None = 100,
        Minimal = 200,
        Low = 300,
        Medium = 400,
        High = 500,
        Unrestricted = 600
    }
}
