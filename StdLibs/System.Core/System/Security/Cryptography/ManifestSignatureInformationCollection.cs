using System.Collections.ObjectModel;

namespace System.Security.Cryptography
{
    public sealed class ManifestSignatureInformationCollection : ReadOnlyCollection<ManifestSignatureInformation>
    {
        internal ManifestSignatureInformationCollection()
            : base(null)
        {

        }
    }
}
