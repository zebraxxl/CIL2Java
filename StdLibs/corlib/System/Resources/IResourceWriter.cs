using System.Runtime.InteropServices;
using System;

namespace System.Resources
{
    /// <summary>Provides the base functionality for writing resources to an output file or stream.</summary>
    [ComVisibleAttribute(true)]
    public interface IResourceWriter : IDisposable
    {
        /// <summary>Adds a named resource of type <see cref="T:System.String" /> to the list of resources to be written.</summary><param name="name">The name of the resource. </param><param name="value">The value of the resource. </param><exception cref="T:System.ArgumentException">The <paramref name="name" /> parameter is null. </exception>
        void AddResource(string name, string value);
        
        
        /// <summary>Adds a named resource of type <see cref="T:System.Object" /> to the list of resources to be written.</summary><param name="name">The name of the resource. </param><param name="value">The value of the resource. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
        void AddResource(string name, object value);
        
        
        /// <summary>Adds an 8-bit unsigned integer array as a named resource to the list of resources to be written.</summary><param name="name">Name of a resource. </param><param name="value">Value of a resource as an 8-bit unsigned integer array. </param><exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is null. </exception>
        void AddResource(string name, byte[] value);
        
        
        void Close();
        
        
        void Generate();
        
        
    }
}
