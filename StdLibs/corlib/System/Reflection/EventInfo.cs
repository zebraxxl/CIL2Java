using System.Runtime.InteropServices;
using System;
using System.Diagnostics;

namespace System.Reflection
{
    /// <summary>Discovers the attributes of an event and provides access to event metadata.</summary>
    [Serializable]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_EventInfo))]
    [ComVisibleAttribute(true)]
    public abstract class EventInfo : MemberInfo, _EventInfo
    {
        /// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is an event.</summary><returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is an event.</returns>
        public override MemberTypes MemberType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the attributes for this event.</summary><returns>The read-only attributes for this event.</returns>
        public abstract EventAttributes Attributes
        {
            get;
        }
    
        /// <summary>Gets the <see cref="T:System.Reflection.MethodInfo" /> object for the <see cref="M:System.Reflection.EventInfo.AddEventHandler(System.Object,System.Delegate)" /> method of the event, including non-public methods.</summary><returns>The <see cref="T:System.Reflection.MethodInfo" /> object for the <see cref="M:System.Reflection.EventInfo.AddEventHandler(System.Object,System.Delegate)" /> method.</returns>
        public virtual MethodInfo AddMethod
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the MethodInfo object for removing a method of the event, including non-public methods.</summary><returns>The MethodInfo object for removing a method of the event.</returns>
        public virtual MethodInfo RemoveMethod
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the method that is called when the event is raised, including non-public methods.</summary><returns>The method that is called when the event is raised.</returns>
        public virtual MethodInfo RaiseMethod
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets the Type object of the underlying event-handler delegate associated with this event.</summary><returns>A read-only Type object representing the delegate event handler.</returns><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public virtual Type EventHandlerType
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the EventInfo has a name with a special meaning.</summary><returns>true if this event has a special name; otherwise, false.</returns>
        public bool IsSpecialName
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Gets a value indicating whether the event is multicast.</summary><returns>true if the delegate is an instance of a multicast delegate; otherwise, false.</returns><exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public virtual bool IsMulticast
        {
            get { throw new NotImplementedException(); }
        }
    
    
        protected EventInfo()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.EventInfo" /> objects are equal.</summary><returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.EventInfo" /> objects are equal.</summary><returns>true if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator ==(EventInfo left, EventInfo right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Indicates whether two <see cref="T:System.Reflection.EventInfo" /> objects are not equal.</summary><returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        /// <summary>Indicates whether two <see cref="T:System.Reflection.EventInfo" /> objects are not equal.</summary><returns>true if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, false.</returns><param name="left">The first object to compare.</param><param name="right">The second object to compare.</param>
        public static bool operator !=(EventInfo left, EventInfo right)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary><returns>true if <paramref name="obj" /> equals the type and value of this instance; otherwise, false.</returns><param name="obj">An object to compare with this instance, or null.</param>
        public override bool Equals(object obj)
        {
             throw new NotImplementedException();
        }
        
        
        public override int GetHashCode()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Returns the methods that have been associated with the event in metadata using the .other directive, specifying whether to include non-public methods.</summary><returns>An array of <see cref="T:System.Reflection.EventInfo" /> objects representing methods that have been associated with an event in metadata by using the .other directive. If there are no methods matching the specification, an empty array is returned.</returns><param name="nonPublic">true to include non-public methods; otherwise, false.</param><exception cref="T:System.NotImplementedException">This method is not implemented.</exception>
        public virtual MethodInfo[] GetOtherMethods(bool nonPublic)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>When overridden in a derived class, retrieves the MethodInfo object for the <see cref="M:System.Reflection.EventInfo.AddEventHandler(System.Object,System.Delegate)" /> method of the event, specifying whether to return non-public methods.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method used to add an event handler delegate to the event source.</returns><param name="nonPublic">true if non-public methods can be returned; otherwise, false. </param><exception cref="T:System.MethodAccessException"><paramref name="nonPublic" /> is true, the method used to add an event handler delegate is non-public, and the caller does not have permission to reflect on non-public methods. </exception>
        public abstract MethodInfo GetAddMethod(bool nonPublic);
        
        
        /// <summary>When overridden in a derived class, retrieves the MethodInfo object for removing a method of the event, specifying whether to return non-public methods.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method used to remove an event handler delegate from the event source.</returns><param name="nonPublic">true if non-public methods can be returned; otherwise, false. </param><exception cref="T:System.MethodAccessException"><paramref name="nonPublic" /> is true, the method used to add an event handler delegate is non-public, and the caller does not have permission to reflect on non-public methods. </exception>
        public abstract MethodInfo GetRemoveMethod(bool nonPublic);
        
        
        /// <summary>When overridden in a derived class, returns the method that is called when the event is raised, specifying whether to return non-public methods.</summary><returns>A MethodInfo object that was called when the event was raised.</returns><param name="nonPublic">true if non-public methods can be returned; otherwise, false. </param><exception cref="T:System.MethodAccessException"><paramref name="nonPublic" /> is true, the method used to add an event handler delegate is non-public, and the caller does not have permission to reflect on non-public methods. </exception>
        public abstract MethodInfo GetRaiseMethod(bool nonPublic);
        
        
        public MethodInfo[] GetOtherMethods()
        {
             throw new NotImplementedException();
        }
        
        
        public MethodInfo GetAddMethod()
        {
             throw new NotImplementedException();
        }
        
        
        public MethodInfo GetRemoveMethod()
        {
             throw new NotImplementedException();
        }
        
        
        public MethodInfo GetRaiseMethod()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds an event handler to an event source.</summary><param name="target">The event source. </param><param name="handler">Encapsulates a method or methods to be invoked when the event is raised by the target. </param><exception cref="T:System.InvalidOperationException">The event does not have a public add accessor.</exception><exception cref="T:System.ArgumentException">The handler that was passed in cannot be used. </exception><exception cref="T:System.MethodAccessException">The caller does not have access permission to the member. </exception><exception cref="T:System.Reflection.TargetException">The <paramref name="target" /> parameter is null and the event is not static.-or- The <see cref="T:System.Reflection.EventInfo" /> is not declared on the target. </exception>
        [DebuggerHiddenAttribute()]
        [DebuggerStepThroughAttribute()]
        public virtual void AddEventHandler(object target, Delegate handler)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Removes an event handler from an event source.</summary><param name="target">The event source. </param><param name="handler">The delegate to be disassociated from the events raised by target. </param><exception cref="T:System.InvalidOperationException">The event does not have a public remove accessor. </exception><exception cref="T:System.ArgumentException">The handler that was passed in cannot be used. </exception><exception cref="T:System.Reflection.TargetException">The <paramref name="target" /> parameter is null and the event is not static.-or- The <see cref="T:System.Reflection.EventInfo" /> is not declared on the target. </exception><exception cref="T:System.MethodAccessException">The caller does not have access permission to the member. </exception>
        [DebuggerStepThroughAttribute()]
        [DebuggerHiddenAttribute()]
        public virtual void RemoveEventHandler(object target, Delegate handler)
        {
             throw new NotImplementedException();
        }



        MemberTypes _EventInfo.MemberType
        {
            get { throw new NotImplementedException(); }
        }

        string _EventInfo.Name
        {
            get { throw new NotImplementedException(); }
        }

        Type _EventInfo.DeclaringType
        {
            get { throw new NotImplementedException(); }
        }

        Type _EventInfo.ReflectedType
        {
            get { throw new NotImplementedException(); }
        }

        EventAttributes _EventInfo.Attributes
        {
            get { throw new NotImplementedException(); }
        }

        Type _EventInfo.EventHandlerType
        {
            get { throw new NotImplementedException(); }
        }

        bool _EventInfo.IsSpecialName
        {
            get { throw new NotImplementedException(); }
        }

        bool _EventInfo.IsMulticast
        {
            get { throw new NotImplementedException(); }
        }

        void _EventInfo.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _EventInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _EventInfo.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _EventInfo.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }

        string _EventInfo.ToString()
        {
            throw new NotImplementedException();
        }

        bool _EventInfo.Equals(object other)
        {
            throw new NotImplementedException();
        }

        int _EventInfo.GetHashCode()
        {
            throw new NotImplementedException();
        }

        Type _EventInfo.GetType()
        {
            throw new NotImplementedException();
        }

        object[] _EventInfo.GetCustomAttributes(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        object[] _EventInfo.GetCustomAttributes(bool inherit)
        {
            throw new NotImplementedException();
        }

        bool _EventInfo.IsDefined(Type attributeType, bool inherit)
        {
            throw new NotImplementedException();
        }

        MethodInfo _EventInfo.GetAddMethod(bool nonPublic)
        {
            throw new NotImplementedException();
        }

        MethodInfo _EventInfo.GetRemoveMethod(bool nonPublic)
        {
            throw new NotImplementedException();
        }

        MethodInfo _EventInfo.GetRaiseMethod(bool nonPublic)
        {
            throw new NotImplementedException();
        }

        MethodInfo _EventInfo.GetAddMethod()
        {
            throw new NotImplementedException();
        }

        MethodInfo _EventInfo.GetRemoveMethod()
        {
            throw new NotImplementedException();
        }

        MethodInfo _EventInfo.GetRaiseMethod()
        {
            throw new NotImplementedException();
        }

        void _EventInfo.AddEventHandler(object target, Delegate handler)
        {
            throw new NotImplementedException();
        }

        void _EventInfo.RemoveEventHandler(object target, Delegate handler)
        {
            throw new NotImplementedException();
        }
    }
}
