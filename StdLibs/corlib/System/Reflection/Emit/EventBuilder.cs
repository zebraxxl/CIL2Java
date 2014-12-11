using System.Runtime.InteropServices;
using System.Security;
using System.Reflection;

namespace System.Reflection.Emit
{
    /// <summary>Defines events for a class.</summary>
    [ComDefaultInterfaceAttribute(typeof(_EventBuilder))]
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    public sealed class EventBuilder : _EventBuilder
    {
    
        public EventToken GetEventToken()
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the method used to subscribe to this event.</summary><param name="mdBuilder">A MethodBuilder object that represents the method used to subscribe to this event. </param><exception cref="T:System.ArgumentNullException"><paramref name="mdBuilder" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has been called on the enclosing type. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetAddOnMethod(MethodBuilder mdBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the method used to unsubscribe to this event.</summary><param name="mdBuilder">A MethodBuilder object that represents the method used to unsubscribe to this event. </param><exception cref="T:System.ArgumentNullException"><paramref name="mdBuilder" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has been called on the enclosing type. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetRemoveOnMethod(MethodBuilder mdBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the method used to raise this event.</summary><param name="mdBuilder">A MethodBuilder object that represents the method used to raise this event. </param><exception cref="T:System.ArgumentNullException"><paramref name="mdBuilder" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has been called on the enclosing type. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetRaiseMethod(MethodBuilder mdBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Adds one of the "other" methods associated with this event. "Other" methods are methods other than the "on" and "raise" methods associated with an event. This function can be called many times to add as many "other" methods.</summary><param name="mdBuilder">A MethodBuilder object that represents the other method. </param><exception cref="T:System.ArgumentNullException"><paramref name="mdBuilder" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has been called on the enclosing type. </exception>
        [SecuritySafeCriticalAttribute()]
        public void AddOtherMethod(MethodBuilder mdBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Set a custom attribute using a specified custom attribute blob.</summary><param name="con">The constructor for the custom attribute. </param><param name="binaryAttribute">A byte blob representing the attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> or <paramref name="binaryAttribute" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has been called on the enclosing type. </exception>
        [ComVisibleAttribute(true)]
        [SecuritySafeCriticalAttribute()]
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets a custom attribute using a custom attribute builder.</summary><param name="customBuilder">An instance of a helper class to describe the custom attribute. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> is null. </exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has been called on the enclosing type. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
        {
             throw new NotImplementedException();
        }



        void _EventBuilder.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _EventBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _EventBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _EventBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
