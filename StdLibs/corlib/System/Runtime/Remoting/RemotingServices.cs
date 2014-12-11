using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Messaging;
using System;
using System.Runtime.Serialization;
using System.Reflection;
using System.Diagnostics;

namespace System.Runtime.Remoting
{
    /// <summary>Provides several methods for using and publishing remoted objects and proxies. This class cannot be inherited.</summary>
    [ComVisibleAttribute(true)]
    public static class RemotingServices
    {
    
        /// <summary>Returns a Boolean value that indicates whether the given object is a transparent proxy or a real object.</summary><returns>A Boolean value that indicates whether the object specified in the <paramref name="proxy" /> parameter is a transparent proxy or a real object.</returns><param name="proxy">The reference to the object to check. </param>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecuritySafeCriticalAttribute()]
        public static bool IsTransparentProxy(object proxy)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a Boolean value that indicates whether the object represented by the given proxy is contained in a different context than the object that called the current method.</summary><returns>true if the object is out of the current context; otherwise, false.</returns><param name="tp">The object to check. </param>
        [SecuritySafeCriticalAttribute()]
        public static bool IsObjectOutOfContext(object tp)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a Boolean value that indicates whether the object specified by the given transparent proxy is contained in a different application domain than the object that called the current method.</summary><returns>true if the object is out of the current application domain; otherwise, false.</returns><param name="tp">The object to check. </param>
        public static bool IsObjectOutOfAppDomain(object tp)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the real proxy backing the specified transparent proxy.</summary><returns>The real proxy instance backing the transparent proxy.</returns><param name="proxy">A transparent proxy. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.Success)]
        [SecurityCriticalAttribute()]
        public static RealProxy GetRealProxy(object proxy)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves a session ID for a message.</summary><returns>A session ID string that uniquely identifies the current session.</returns><param name="msg">The <see cref="T:System.Runtime.Remoting.Messaging.IMethodMessage" /> for which a session ID is requested. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string GetSessionIdForMethodMessage(IMethodMessage msg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a lifetime service object that controls the lifetime policy of the specified object.</summary><returns>The object that controls the lifetime of <paramref name="obj" />.</returns><param name="obj">The object to obtain lifetime service for. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static object GetLifetimeService(MarshalByRefObject obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Retrieves the URI for the specified object.</summary><returns>The URI of the specified object if it has one, or null if the object has not yet been marshaled.</returns><param name="obj">The <see cref="T:System.MarshalByRefObject" /> for which a URI is requested. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static string GetObjectUri(MarshalByRefObject obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the URI for the subsequent call to the <see cref="M:System.Runtime.Remoting.RemotingServices.Marshal(System.MarshalByRefObject)" /> method.</summary><param name="obj">The object to set a URI for. </param><param name="uri">The URI to assign to the specified object. </param><exception cref="T:System.Runtime.Remoting.RemotingException"><paramref name="obj" /> is not a local object, has already been marshaled, or the current method has already been called on. </exception><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static void SetObjectUriForMarshal(MarshalByRefObject obj, string uri)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Takes a <see cref="T:System.MarshalByRefObject" />, registers it with the remoting infrastructure, and converts it into an instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class.</summary><returns>An instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class that represents the object specified in the <paramref name="Obj" /> parameter.</returns><param name="Obj">The object to convert. </param><exception cref="T:System.Runtime.Remoting.RemotingException">The <paramref name="Obj" /> parameter is an object proxy. </exception><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static ObjRef Marshal(MarshalByRefObject Obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Converts the given <see cref="T:System.MarshalByRefObject" /> into an instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class with the specified URI.</summary><returns>An instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class that represents the object specified in the <paramref name="Obj" /> parameter.</returns><param name="Obj">The object to convert. </param><param name="URI">The specified URI with which to initialize the new <see cref="T:System.Runtime.Remoting.ObjRef" />. Can be null. </param><exception cref="T:System.Runtime.Remoting.RemotingException"><paramref name="Obj" /> is an object proxy, and the <paramref name="URI" /> parameter is not null. </exception><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static ObjRef Marshal(MarshalByRefObject Obj, string URI)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Takes a <see cref="T:System.MarshalByRefObject" /> and converts it into an instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class with the specified URI, and the provided <see cref="T:System.Type" />.</summary><returns>An instance of the <see cref="T:System.Runtime.Remoting.ObjRef" /> class that represents the object specified in the <paramref name="Obj" /> parameter.</returns><param name="Obj">The object to convert into a <see cref="T:System.Runtime.Remoting.ObjRef" />. </param><param name="ObjURI">The URI the object specified in the <paramref name="Obj" /> parameter is marshaled with. Can be null. </param><param name="RequestedType">The <see cref="T:System.Type" /><paramref name="Obj" /> is marshaled as. Can be null. </param><exception cref="T:System.Runtime.Remoting.RemotingException"><paramref name="Obj" /> is a proxy of a remote object, and the <paramref name="ObjUri" /> parameter is not null. </exception><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" /></PermissionSet>
        [SecuritySafeCriticalAttribute()]
        public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Serializes the specified marshal by reference object into the provided <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary><param name="obj">The object to serialize. </param><param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> into which the object is serialized. </param><param name="context">The source and destination of the serialization. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> or <paramref name="info" /> parameter is null. </exception><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Takes a <see cref="T:System.Runtime.Remoting.ObjRef" /> and creates a proxy object out of it.</summary><returns>A proxy to the object that the given <see cref="T:System.Runtime.Remoting.ObjRef" /> represents.</returns><param name="objectRef">The <see cref="T:System.Runtime.Remoting.ObjRef" /> that represents the remote object for which the proxy is being created. </param><exception cref="T:System.ArgumentException">The <see cref="T:System.Runtime.Remoting.ObjRef" /> instance specified in the <paramref name="objectRef" /> parameter is not well-formed. </exception><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object Unmarshal(ObjRef objectRef)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Takes a <see cref="T:System.Runtime.Remoting.ObjRef" /> and creates a proxy object out of it, refining it to the type on the server.</summary><returns>A proxy to the object that the given <see cref="T:System.Runtime.Remoting.ObjRef" /> represents.</returns><param name="objectRef">The <see cref="T:System.Runtime.Remoting.ObjRef" /> that represents the remote object for which the proxy is being created. </param><param name="fRefine">true to refine the proxy to the type on the server; otherwise, false. </param><exception cref="T:System.ArgumentException">The <see cref="T:System.Runtime.Remoting.ObjRef" /> instance specified in the <paramref name="objectRef" /> parameter is not well-formed. </exception><exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" /><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static object Unmarshal(ObjRef objectRef, bool fRefine)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a proxy for a well-known object, given the <see cref="T:System.Type" /> and URL.</summary><returns>A proxy to the remote object that points to an endpoint served by the specified well-known object.</returns><param name="classToProxy">The <see cref="T:System.Type" /> of a well-known object on the server end to which you want to connect. </param><param name="url">The URL of the server class. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, RemotingConfiguration" /></PermissionSet>
        [ComVisibleAttribute(true)]
        [SecurityCriticalAttribute()]
        public static object Connect(Type classToProxy, string url)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Creates a proxy for a well-known object, given the <see cref="T:System.Type" />, URL, and channel-specific data.</summary><returns>A proxy that points to an endpoint that is served by the requested well-known object.</returns><param name="classToProxy">The <see cref="T:System.Type" /> of the well-known object to which you want to connect. </param><param name="url">The URL of the well-known object. </param><param name="data">Channel specific data. Can be null. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence, RemotingConfiguration" /></PermissionSet>
        [ComVisibleAttribute(true)]
        [SecurityCriticalAttribute()]
        public static object Connect(Type classToProxy, string url, object data)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Stops an object from receiving any further messages through the registered remoting channels.</summary><returns>true if the object was disconnected from the registered remoting channels successfully; otherwise, false.</returns><param name="obj">Object to disconnect from its channel. </param><exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> parameter is null. </exception><exception cref="T:System.ArgumentException">The <paramref name="obj" /> parameter is a proxy. </exception><exception cref="T:System.Security.SecurityException">The immediate caller does not have permission to configure remoting types and channels. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static bool Disconnect(MarshalByRefObject obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a chain of envoy sinks that should be used when sending messages to the remote object represented by the specified proxy.</summary><returns>A chain of envoy sinks associated with the specified proxy.</returns><param name="obj">The proxy of the remote object that requested envoy sinks are associated with. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IMessageSink GetEnvoyChainForProxy(MarshalByRefObject obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the <see cref="T:System.Runtime.Remoting.ObjRef" /> that represents the remote object from the specified proxy.</summary><returns>A <see cref="T:System.Runtime.Remoting.ObjRef" /> that represents the remote object the specified proxy is connected to, or null if the object or proxy have not been marshaled.</returns><param name="obj">A proxy connected to the object you want to create a <see cref="T:System.Runtime.Remoting.ObjRef" /> for. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static ObjRef GetObjRefForProxy(MarshalByRefObject obj)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the method base from the given <see cref="T:System.Runtime.Remoting.Messaging.IMethodMessage" />.</summary><returns>The method base extracted from the <paramref name="msg" /> parameter.</returns><param name="msg">The method message to extract the method base from. </param><exception cref="T:System.Security.SecurityException">Either the immediate caller does not have infrastructure permission, or at least one of the callers higher in the callstack does not have permission to retrieve the type information of non-public members. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a Boolean value that indicates whether the method in the given message is overloaded.</summary><returns>true if the method called in <paramref name="msg" /> is overloaded; otherwise, false.</returns><param name="msg">The message that contains a call to the method in question. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static bool IsMethodOverloaded(IMethodMessage msg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a Boolean value that indicates whether the client that called the method specified in the given message is waiting for the server to finish processing the method before continuing execution.</summary><returns>true if the method is one way; otherwise, false.</returns><param name="method">The method in question. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static bool IsOneWay(MethodBase method)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the <see cref="T:System.Type" /> of the object with the specified URI.</summary><returns>The <see cref="T:System.Type" /> of the object with the specified URI.</returns><param name="URI">The URI of the object whose <see cref="T:System.Type" /> is requested. </param><exception cref="T:System.Security.SecurityException">Either the immediate caller does not have infrastructure permission, or at least one of the callers higher in the callstack does not have permission to retrieve the type information of non-public members. </exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static Type GetServerTypeForUri(string URI)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Connects to the specified remote object, and executes the provided <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> on it.</summary><returns>The response of the remote method.</returns><param name="target">The remote object whose method you want to call. </param><param name="reqMsg">A method call message to the specified remote object's method. </param><exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception><exception cref="T:System.Runtime.Remoting.RemotingException">The method was called from a context other than the native context of the object.</exception><PermissionSet><IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" /><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [SecurityCriticalAttribute()]
        public static IMethodReturnMessage ExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Logs the stage in a remoting exchange to an external debugger.</summary><param name="stage">An internally defined constant that identifies the stage in a remoting exchange.</param><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" /></PermissionSet>
        [ObsoleteAttribute("Use of this method is not recommended. The LogRemotingStage existed for internal diagnostic purposes only.")]
        [SecurityCriticalAttribute()]
        [ConditionalAttribute("REMOTING_PERF")]
        public static void LogRemotingStage(int stage)
        {
             throw new NotImplementedException();
        }
        
        
    }
}
