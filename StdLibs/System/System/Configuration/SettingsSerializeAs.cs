using System;

namespace System.Configuration
{
    public enum SettingsSerializeAs : int
    {
        String = 0,
        Xml = 1,
        Binary = 2,
        ProviderSpecific = 3
    }
}
