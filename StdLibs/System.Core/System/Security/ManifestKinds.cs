using System;

namespace System.Security
{
    [FlagsAttribute()]
    public enum ManifestKinds : int
    {
        None = 0,
        Deployment = 1,
        Application = 2,
        ApplicationAndDeployment = 3
    }
}
