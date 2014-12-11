using System.Runtime.InteropServices;
using System.Security;
using System;
using System.Reflection;

namespace System.Runtime.Remoting
{
    /// <summary>Provides several methods for using and publishing remoted objects in SOAP format.</summary>
    [ComVisibleAttribute(true)]
    [SecurityCriticalAttribute()]
    public class SoapServices
    {
    
        /// <summary>Gets the XML namespace prefix for common language runtime types.</summary><returns>The XML namespace prefix for common language runtime types.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public static string XmlNsForClrType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the default XML namespace prefix that should be used for XML encoding of a common language runtime class that has an assembly, but no native namespace.</summary><returns>The default XML namespace prefix that should be used for XML encoding of a common language runtime class that has an assembly, but no native namespace.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public static string XmlNsForClrTypeWithAssembly
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the XML namespace prefix that should be used for XML encoding of a common language runtime class that is part of the mscorlib.dll file.</summary><returns>The XML namespace prefix that should be used for XML encoding of a common language runtime class that is part of the mscorlib.dll file.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public static string XmlNsForClrTypeWithNs
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the default XML namespace prefix that should be used for XML encoding of a common language runtime class that has both a common language runtime namespace and an assembly.</summary><returns>The default XML namespace prefix that should be used for XML encoding of a common language runtime class that has both a common language runtime namespace and an assembly.</returns><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public static string XmlNsForClrTypeWithNsAndAssembly
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Associates the given XML element name and namespace with a run-time type that should be used for deserialization.</summary><param name="xmlElement">The XML element name to use in deserialization. </param><param name="xmlNamespace">The XML namespace to use in deserialization. </param><param name="type">The run-time <see cref="T:System.Type" /> to use in deserialization. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Associates the given XML type name and namespace with the run-time type that should be used for deserialization.</summary><param name="xmlType">The XML type to use in deserialization. </param><param name="xmlTypeNamespace">The XML namespace to use in deserialization. </param><param name="type">The run-time <see cref="T:System.Type" /> to use in deserialization. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Preloads the given <see cref="T:System.Type" /> based on values set in a <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" /> on the type.</summary><param name="type">The <see cref="T:System.Type" /> to preload. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void PreLoad(Type type)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Preloads every <see cref="T:System.Type" /> found in the specified <see cref="T:System.Reflection.Assembly" /> from the information found in the <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" /> associated with each type.</summary><param name="assembly">The <see cref="T:System.Reflection.Assembly" /> for each type of which to call <see cref="M:System.Runtime.Remoting.SoapServices.PreLoad(System.Type)" />. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void PreLoad(Assembly assembly)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the <see cref="T:System.Type" /> that should be used during deserialization of an unrecognized object type with the given XML element name and namespace.</summary><returns>The <see cref="T:System.Type" /> of object associated with the specified XML element name and namespace.</returns><param name="xmlElement">The XML element name of the unknown object type. </param><param name="xmlNamespace">The XML namespace of the unknown object type. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static Type GetInteropTypeFromXmlElement(string xmlElement, string xmlNamespace)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the object <see cref="T:System.Type" /> that should be used during deserialization of an unrecognized object type with the given XML type name and namespace.</summary><returns>The <see cref="T:System.Type" /> of object associated with the specified XML type name and namespace.</returns><param name="xmlType">The XML type of the unknown object type. </param><param name="xmlTypeNamespace">The XML type namespace of the unknown object type. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static Type GetInteropTypeFromXmlType(string xmlType, string xmlTypeNamespace)
        {
             throw new NotImplementedException();
        }
        
        
        public static void GetInteropFieldTypeAndNameFromXmlElement(Type containingType, string xmlElement, string xmlNamespace, ref Type type, ref string name)
        {
             throw new NotImplementedException();
        }
        
        
        public static void GetInteropFieldTypeAndNameFromXmlAttribute(Type containingType, string xmlAttribute, string xmlNamespace, ref Type type, ref string name)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static bool GetXmlElementForInteropType(Type type, ref string xmlElement, ref string xmlNamespace)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static bool GetXmlTypeForInteropType(Type type, ref string xmlType, ref string xmlTypeNamespace)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the XML namespace used during remote calls of the method specified in the given <see cref="T:System.Reflection.MethodBase" />.</summary><returns>The XML namespace used during remote calls of the specified method.</returns><param name="mb">The <see cref="T:System.Reflection.MethodBase" /> of the method for which the XML namespace was requested. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string GetXmlNamespaceForMethodCall(MethodBase mb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the XML namespace used during the generation of responses to the remote call to the method specified in the given <see cref="T:System.Reflection.MethodBase" />.</summary><returns>The XML namespace used during the generation of responses to a remote method call.</returns><param name="mb">The <see cref="T:System.Reflection.MethodBase" /> of the method for which the XML namespace was requested. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string GetXmlNamespaceForMethodResponse(MethodBase mb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Associates the specified <see cref="T:System.Reflection.MethodBase" /> with the SOAPAction cached with it.</summary><param name="mb">The <see cref="T:System.Reflection.MethodBase" /> of the method to associate with the SOAPAction cached with it. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void RegisterSoapActionForMethodBase(MethodBase mb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Associates the provided SOAPAction value with the given <see cref="T:System.Reflection.MethodBase" /> for use in channel sinks.</summary><param name="mb">The <see cref="T:System.Reflection.MethodBase" /> to associate with the provided SOAPAction. </param><param name="soapAction">The SOAPAction value to associate with the given <see cref="T:System.Reflection.MethodBase" />. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public static void RegisterSoapActionForMethodBase(MethodBase mb, string soapAction)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the SOAPAction value associated with the method specified in the given <see cref="T:System.Reflection.MethodBase" />.</summary><returns>The SOAPAction value associated with the method specified in the given <see cref="T:System.Reflection.MethodBase" />.</returns><param name="mb">The <see cref="T:System.Reflection.MethodBase" /> that contains the method for which a SOAPAction is requested. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string GetSoapActionFromMethodBase(MethodBase mb)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Determines if the specified SOAPAction is acceptable for a given <see cref="T:System.Reflection.MethodBase" />.</summary><returns>true if the specified SOAPAction is acceptable for a given <see cref="T:System.Reflection.MethodBase" />; otherwise, false.</returns><param name="soapAction">The SOAPAction to check against the given <see cref="T:System.Reflection.MethodBase" />. </param><param name="mb">The <see cref="T:System.Reflection.MethodBase" /> the specified SOAPAction is checked against. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static bool IsSoapActionValidForMethodBase(string soapAction, MethodBase mb)
        {
             throw new NotImplementedException();
        }
        
        
        public static bool GetTypeAndMethodNameFromSoapAction(string soapAction, ref string typeName, ref string methodName)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a Boolean value that indicates whether the specified namespace is native to the common language runtime.</summary><returns>true if the given namespace is native to the common language runtime; otherwise, false.</returns><param name="namespaceString">The namespace to check in the common language runtime. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        public static bool IsClrTypeNamespace(string namespaceString)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the common language runtime type namespace name from the provided namespace and assembly names.</summary><returns>The common language runtime type namespace name from the provided namespace and assembly names.</returns><param name="typeNamespace">The namespace that is to be coded. </param><param name="assemblyName">The name of the assembly that is to be coded. </param><exception cref="T:System.ArgumentNullException">The <paramref name="assemblyName" /> and <paramref name="typeNamespace" /> parameters are both either null or empty. </exception><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName)
        {
             throw new NotImplementedException();
        }
        
        
        [SecurityCriticalAttribute()]
        public static bool DecodeXmlNamespaceForClrTypeNamespace(string inNamespace, ref string typeNamespace, ref string assemblyName)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
