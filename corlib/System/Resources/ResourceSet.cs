using System.Runtime.InteropServices;
using System;
using System.Collections;
using System.Security;
using System.IO;

namespace System.Resources
{
    /// <summary>Stores all the resources localized for one particular culture, ignoring all other cultures, including any fallback rules.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public class ResourceSet : IDisposable, IEnumerable
    {
        /// <summary>Indicates the <see cref="T:System.Resources.IResourceReader" /> used to read the resources.</summary>
        protected IResourceReader Reader;
        /// <summary>The <see cref="T:System.Collections.Hashtable" /> in which the resources are stored.</summary>
        protected Hashtable Table;
    
        protected ResourceSet()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the <see cref="T:System.Resources.ResourceSet" /> class using the system default <see cref="T:System.Resources.ResourceReader" /> that opens and reads resources from the given file.</summary><param name="fileName">Resource file to read. </param><exception cref="T:System.ArgumentNullException">The <paramref name="fileName" /> parameter is null. </exception>
        public ResourceSet(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the <see cref="T:System.Resources.ResourceSet" /> class using the system default <see cref="T:System.Resources.ResourceReader" /> that reads resources from the given stream.</summary><param name="stream">The <see cref="T:System.IO.Stream" /> of resources to be read. The stream should refer to an existing resources file. </param><exception cref="T:System.ArgumentException">The <paramref name="stream" /> is not readable. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="stream" /> parameter is null. </exception>
        [SecurityCriticalAttribute()]
        public ResourceSet(Stream stream)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a new instance of the <see cref="T:System.Resources.ResourceSet" /> class using the specified resource reader.</summary><param name="reader">The reader that will be used. </param><exception cref="T:System.ArgumentNullException">The <paramref name="reader" /> parameter is null. </exception>
        public ResourceSet(IResourceReader reader)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual void Close()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Releases resources (other than memory) associated with the current instance, closing internal managed objects if requested.</summary><param name="disposing">Indicates whether the objects contained in the current instance should be explicitly closed. </param>
        protected virtual void Dispose(bool disposing)
        {
             throw new NotImplementedException();
        }
        
        
        public void Dispose()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Type GetDefaultReader()
        {
             throw new NotImplementedException();
        }
        
        
        public virtual Type GetDefaultWriter()
        {
             throw new NotImplementedException();
        }
        
        
        [ComVisibleAttribute(false)]
        public virtual IDictionaryEnumerator GetEnumerator()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for a <see cref="T:System.String" /> resource with the specified name.</summary><returns>The value of a resource, if the value is a <see cref="T:System.String" />.</returns><param name="name">Name of the resource to search for. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.InvalidOperationException">The resource specified by <paramref name="name" /> is not a <see cref="T:System.String" />. </exception><exception cref="T:System.ObjectDisposedException">The object has been closed or disposed.</exception>
        public virtual string GetString(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for a <see cref="T:System.String" /> resource with the specified name in a case-insensitive manner, if requested.</summary><returns>The value of a resource, if the value is a <see cref="T:System.String" />.</returns><param name="name">Name of the resource to search for. </param><param name="ignoreCase">Indicates whether the case of the case of the specified name should be ignored. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.InvalidOperationException">The resource specified by <paramref name="name" /> is not a <see cref="T:System.String" />.</exception><exception cref="T:System.ObjectDisposedException">The object has been closed or disposed.</exception>
        public virtual string GetString(string name, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for a resource object with the specified name.</summary><returns>The requested resource.</returns><param name="name">Case-sensitive name of the resource to search for. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.ObjectDisposedException">The object has been closed or disposed.</exception>
        public virtual object GetObject(string name)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Searches for a resource object with the specified name in a case-insensitive manner, if requested.</summary><returns>The requested resource.</returns><param name="name">Name of the resource to search for. </param><param name="ignoreCase">Indicates whether the case of the specified name should be ignored. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.ObjectDisposedException">The object has been closed or disposed.</exception>
        public virtual object GetObject(string name, bool ignoreCase)
        {
             throw new NotImplementedException();
        }
        
        
        protected virtual void ReadResources()
        {
             throw new NotImplementedException();
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
