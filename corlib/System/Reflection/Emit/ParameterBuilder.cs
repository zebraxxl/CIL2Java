using System.Runtime.InteropServices;
using System.Security;
using System;
using System.Reflection;

namespace System.Reflection.Emit
{
    /// <summary>Creates or associates parameter information.</summary>
    [ComVisibleAttribute(true)]
    [ClassInterfaceAttribute(ClassInterfaceType.None)]
    [ComDefaultInterfaceAttribute(typeof(_ParameterBuilder))]
    public class ParameterBuilder : _ParameterBuilder
    {
    
        /// <summary>Retrieves the name of this parameter.</summary><returns>Read-only. Retrieves the name of this parameter.</returns>
        public virtual string Name
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the signature position for this parameter.</summary><returns>Read-only. Retrieves the signature position for this parameter.</returns>
        public virtual int Position
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves the attributes for this parameter.</summary><returns>Read-only. Retrieves the attributes for this parameter.</returns>
        public virtual int Attributes
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves whether this is an input parameter.</summary><returns>Read-only. Retrieves whether this is an input parameter.</returns>
        public bool IsIn
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves whether this parameter is an output parameter.</summary><returns>Read-only. Retrieves whether this parameter is an output parameter.</returns>
        public bool IsOut
        {
            get { throw new NotImplementedException(); }
        }
    
        /// <summary>Retrieves whether this parameter is optional.</summary><returns>Read-only. Specifies whether this parameter is optional.</returns>
        public bool IsOptional
        {
            get { throw new NotImplementedException(); }
        }
    
    
        /// <summary>Specifies the marshaling for this parameter.</summary><param name="unmanagedMarshal">The marshaling information for this parameter. </param><exception cref="T:System.ArgumentNullException"><paramref name="unmanagedMarshal" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        [ObsoleteAttribute("An alternate API is available: Emit the MarshalAs custom attribute instead. http://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual void SetMarshal(UnmanagedMarshal unmanagedMarshal)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Sets the default value of the parameter.</summary><param name="defaultValue">The default value of this parameter. </param><exception cref="T:System.ArgumentException">The parameter is not one of the supported types.-or-The type of <paramref name="defaultValue" /> does not match the type of the parameter.-or-The parameter is of type <see cref="T:System.Object" /> or other reference type, <paramref name="defaultValue" /> is not null, and the value cannot be assigned to the reference type. </exception>
        [SecuritySafeCriticalAttribute()]
        public virtual void SetConstant(object defaultValue)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Set a custom attribute using a specified custom attribute blob.</summary><param name="con">The constructor for the custom attribute. </param><param name="binaryAttribute">A byte blob representing the attributes. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> or <paramref name="binaryAttribute" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        [ComVisibleAttribute(true)]
        public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
        {
             throw new NotImplementedException();
        }
        
        
        /// <summary>Set a custom attribute using a custom attribute builder.</summary><param name="customBuilder">An instance of a helper class to define the custom attribute. </param><exception cref="T:System.ArgumentNullException"><paramref name="con" /> is null. </exception>
        [SecuritySafeCriticalAttribute()]
        public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
        {
             throw new NotImplementedException();
        }
        
        
        public virtual ParameterToken GetToken()
        {
             throw new NotImplementedException();
        }



        void _ParameterBuilder.GetTypeInfoCount(ref uint pcTInfo)
        {
            throw new NotImplementedException();
        }

        void _ParameterBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
        {
            throw new NotImplementedException();
        }

        void _ParameterBuilder.GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
        {
            throw new NotImplementedException();
        }

        void _ParameterBuilder.Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
        {
            throw new NotImplementedException();
        }
    }
}
