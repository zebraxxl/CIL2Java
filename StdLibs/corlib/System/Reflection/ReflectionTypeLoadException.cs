using System.Runtime.InteropServices;
using System;
using System.Runtime.Serialization;
using System.Security;

namespace System.Reflection
{
    /// <summary>The exception that is thrown by the <see cref="M:System.Reflection.Module.GetTypes" /> method if any of the classes in a module cannot be loaded. This class cannot be inherited.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public sealed class ReflectionTypeLoadException : SystemException, ISerializable
    {
    
        /// <summary>Gets the array of classes that were defined in the module and loaded.</summary><returns>An array of type Type containing the classes that were defined in the module and loaded. This array can contain some null values.</returns>
        public Type[] Types
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the array of exceptions thrown by the class loader.</summary><returns>An array of type Exception containing the exceptions thrown by the class loader. The null values in the <paramref name="classes" /> array of this instance line up with the exceptions in this array.</returns>
        public Exception[] LoaderExceptions
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.ReflectionTypeLoadException" /> class with the given classes and their associated exceptions.</summary><param name="classes">An array of type Type containing the classes that were defined in the module and loaded. This array can contain null reference (Nothing in Visual Basic) values. </param><param name="exceptions">An array of type Exception containing the exceptions that were thrown by the class loader. The null reference (Nothing in Visual Basic) values in the <paramref name="classes" /> array line up with the exceptions in this <paramref name="exceptions" /> array. </param>
        public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Initializes a new instance of the <see cref="T:System.Reflection.ReflectionTypeLoadException" /> class with the given classes, their associated exceptions, and exception descriptions.</summary><param name="classes">An array of type Type containing the classes that were defined in the module and loaded. This array can contain null reference (Nothing in Visual Basic) values. </param><param name="exceptions">An array of type Exception containing the exceptions that were thrown by the class loader. The null reference (Nothing in Visual Basic) values in the <paramref name="classes" /> array line up with the exceptions in this <paramref name="exceptions" /> array. </param><param name="message">A String describing the reason the exception was thrown. </param>
        public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions, string message)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Provides an <see cref="T:System.Runtime.Serialization.ISerializable" /> implementation for serialized objects.</summary><param name="info">The information and data needed to serialize or deserialize an object. </param><param name="context">The context for the serialization. </param><exception cref="T:System.ArgumentNullException">info is null. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
