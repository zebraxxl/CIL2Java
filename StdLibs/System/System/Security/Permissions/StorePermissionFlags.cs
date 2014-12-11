using System;

namespace System.Security.Permissions
{
    [Serializable]
    [FlagsAttribute()]
    public enum StorePermissionFlags : int
    {
        NoFlags = 0,
        CreateStore = 1,
        DeleteStore = 2,
        EnumerateStores = 4,
        OpenStore = 16,
        AddToStore = 32,
        RemoveFromStore = 64,
        EnumerateCertificates = 128,
        AllFlags = 247
    }
}
