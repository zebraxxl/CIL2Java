using System.Runtime.InteropServices;
using System;
using System.IO;
using System.Security;

namespace System.Resources
{
    /// <summary>Writes resources in the system-default format to an output file or an output stream. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    public sealed class ResourceWriter : IResourceWriter
    {
    
        /// <summary>Gets or sets a delegate that enables resource assemblies to be written that target versions of the .NET Framework prior to the .NET Framework 4 by using qualified assembly names.</summary><returns>The type that is encapsulated by the delegate.</returns>
        public Func<Type, string> TypeNameConverter
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.ResourceWriter" /> class that writes the resources to the specified file.</summary><param name="fileName">The output file name. </param><exception cref="T:System.ArgumentNullException">The <paramref name="fileName" /> parameter is null. </exception>
        public ResourceWriter(string fileName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Resources.ResourceWriter" /> class that writes the resources to the provided stream.</summary><param name="stream">The output stream. </param><exception cref="T:System.ArgumentException">The <paramref name="stream" /> parameter is not writable. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="stream" /> parameter is null. </exception>
        public ResourceWriter(Stream stream)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a string resource to the list of resources to be written.</summary><param name="name">The name of the resource. </param><param name="value">The value of the resource. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> (or a name that varies only by capitalization) has already been added to this ResourceWriter. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.InvalidOperationException">This <see cref="T:System.Resources.ResourceWriter" /> has been closed and its hash table is unavailable. </exception>
        public void AddResource(string name, string value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a named resource specified as an object to the list of resources to be written.</summary><param name="name">The name of the resource. </param><param name="value">The value of the resource. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> (or a name that varies only by capitalization) has already been added to this <see cref="T:System.Resources.ResourceWriter" />. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.InvalidOperationException">This <see cref="T:System.Resources.ResourceWriter" /> has been closed and its hash table is unavailable. </exception>
        public void AddResource(string name, object value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a named resource specified as a stream to the list of resources to be written.</summary><param name="name">The name of the resource to add. </param><param name="value">The value of the resource to add. The resource must support the <see cref="P:System.IO.Stream.Length" /> property. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> (or a name that varies only by capitalization) has already been added to this <see cref="T:System.Resources.ResourceWriter" />.-or-The stream does not support the <see cref="P:System.IO.Stream.Length" /> property.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="value" /> is null.</exception><exception cref="T:System.InvalidOperationException">This <see cref="T:System.Resources.ResourceWriter" /> has been closed.</exception>
        public void AddResource(string name, Stream value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a named resource specified as a stream to the list of resources to be written, and specifies whether the stream should be closed after the <see cref="M:System.Resources.ResourceWriter.Generate" /> method is called. </summary><param name="name">The name of the resource to add. </param><param name="value">The value of the resource to add. The resource must support the <see cref="P:System.IO.Stream.Length" /> property. </param><param name="closeAfterWrite">true to close the stream after the <see cref="M:System.Resources.ResourceWriter.Generate" /> method is called; otherwise, false. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> (or a name that varies only by capitalization) has already been added to this <see cref="T:System.Resources.ResourceWriter" />.-or-The stream does not support the <see cref="P:System.IO.Stream.Length" /> property.</exception><exception cref="T:System.ArgumentNullException"><paramref name="name" /> or <paramref name="value" /> is null.</exception><exception cref="T:System.InvalidOperationException">This <see cref="T:System.Resources.ResourceWriter" /> has been closed.</exception>
        public void AddResource(string name, Stream value, bool closeAfterWrite)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a named resource specified as a byte array to the list of resources to be written.</summary><param name="name">The name of the resource. </param><param name="value">Value of the resource as an 8-bit unsigned integer array. </param><exception cref="T:System.ArgumentException"><paramref name="name" /> (or a name that varies only by capitalization) has already been added to this <see cref="T:System.Resources.ResourceWriter" />. </exception><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception><exception cref="T:System.InvalidOperationException">This <see cref="T:System.Resources.ResourceWriter" /> has been closed and its hash table is unavailable. </exception>
        public void AddResource(string name, byte[] value)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds a unit of data as a resource to the list of resources to be written. </summary><param name="name">A name that identifies the resource that contains the added data.</param><param name="typeName">The type name of the added data. For more information, see the Remarks section.</param><param name="serializedData">A byte array that contains the binary representation of the added data.</param><exception cref="T:System.ArgumentNullException"><paramref name="name" />, <paramref name="typeName" />, or <paramref name="serializedData" /> is null.</exception><exception cref="T:System.ArgumentException"><paramref name="name" /> (or a name that varies only by capitalization) has already been added to this <see cref="T:System.Resources.ResourceWriter" /> object. </exception><exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Resources.ResourceWriter" /> object is not initialized. The probable cause is that the <see cref="T:System.Resources.ResourceWriter" /> object is closed.</exception>
        public void AddResourceData(string name, string typeName, byte[] serializedData)
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
        
        
        [SecuritySafeCriticalAttribute()]
        public void Generate()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
