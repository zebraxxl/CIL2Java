using System.Runtime.InteropServices;
using System.Security;
using System.IO;
using System.Collections;

namespace System.Resources
{
    /// <summary>Enumerates the resources in a binary resources (.resources) file by reading sequential resource name/value pairs.</summary>
    [ComVisibleAttribute(true)]
    public sealed class ResourceReader : IResourceReader
    {
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.ResourceReader" /> class for the specified named resource file.</summary><param name="fileName">The path and name of the resource file to read. <paramref name="filename" /> is not case-sensitive.</param><exception cref="T:System.ArgumentNullException">The <paramref name="fileName" /> parameter is null. </exception><exception cref="T:System.IO.FileNotFoundException">The file cannot be found. </exception><exception cref="T:System.IO.IOException">An I/O error has occurred. </exception><exception cref="T:System.BadImageFormatException">The resource file has an invalid format. For example, the length of the file may be zero.</exception>
        [SecuritySafeCriticalAttribute()]
        public ResourceReader(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.ResourceReader" /> class for the specified stream.</summary><param name="stream">The input stream for reading resources. </param><exception cref="T:System.ArgumentException">The <paramref name="stream" /> parameter is not readable. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="stream" /> parameter is null. </exception><exception cref="T:System.IO.IOException">An I/O error has occurred while accessing <paramref name="stream" />. </exception>
        [SecurityCriticalAttribute()]
        public ResourceReader(Stream stream)
        {
             throw new NotImplementedException();
        }
        
        
        public void Close()
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        public IDictionaryEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        public void GetResourceData(string resourceName, ref string resourceType, ref byte resourceData)
        {
             throw new NotImplementedException();
        }



        void IResourceReader.Close()
        {
            throw new NotImplementedException();
        }

        IDictionaryEnumerator IResourceReader.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
