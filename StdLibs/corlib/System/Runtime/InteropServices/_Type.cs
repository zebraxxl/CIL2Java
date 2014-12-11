using System;
using System.Reflection;
using System.Globalization;

namespace System.Runtime.InteropServices
{
    /// <summary>Exposes the public members of the <see cref="T:System.Type" /> class to the unmanaged code.</summary>
    [GuidAttribute("BCA8B44D-AAD6-3A86-8AB7-03349F4F2DA2")]
    [InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    [TypeLibImportClassAttribute(typeof(Type))]
    [ComVisibleAttribute(true)]
    public interface _Type
    {
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.MemberType" /> property.</summary><returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a type or a nested type.</returns>
        MemberTypes MemberType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.MemberInfo.Name" /> property.</summary><returns>The name of the <see cref="T:System.Type" />.</returns>
        string Name
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.DeclaringType" /> property.</summary><returns>The <see cref="T:System.Type" /> object for the class that declares this member. If the type is a nested type, this property returns the enclosing type.</returns>
        Type DeclaringType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.ReflectedType" /> property.</summary><returns>The <see cref="T:System.Type" /> object through which this <see cref="T:System.Reflection.MemberInfo" /> object was obtained.</returns>
        Type ReflectedType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.GUID" /> property.</summary><returns>The GUID associated with the <see cref="T:System.Type" />.</returns>
        Guid GUID
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.Module" /> property.</summary><returns>The name of the module in which the current <see cref="T:System.Type" /> is defined.</returns>
        Module Module
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.Assembly" /> property.</summary><returns>An <see cref="T:System.Reflection.Assembly" /> instance that describes the assembly containing the current type.</returns>
        Assembly Assembly
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.TypeHandle" /> property.</summary><returns>The handle for the current <see cref="T:System.Type" />.</returns>
        RuntimeTypeHandle TypeHandle
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.FullName" /> property.</summary><returns>A string containing the fully qualified name of the <see cref="T:System.Type" />, including the namespace of the <see cref="T:System.Type" /> but not the assembly.</returns>
        string FullName
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.Namespace" /> property.</summary><returns>The namespace of the <see cref="T:System.Type" />.</returns>
        string Namespace
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.AssemblyQualifiedName" /> property.</summary><returns>The assembly-qualified name of the <see cref="T:System.Type" />, including the name of the assembly from which the <see cref="T:System.Type" /> was loaded.</returns>
        string AssemblyQualifiedName
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.BaseType" /> property.</summary><returns>The <see cref="T:System.Type" /> from which the current <see cref="T:System.Type" /> directly inherits, or null if the current Type represents the <see cref="T:System.Object" /> class.</returns>
        Type BaseType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.UnderlyingSystemType" /> property.</summary><returns>The underlying system type for the <see cref="T:System.Type" />.</returns>
        Type UnderlyingSystemType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.TypeInitializer" /> property.</summary><returns>A <see cref="T:System.Reflection.ConstructorInfo" /> containing the name of the class constructor for the <see cref="T:System.Type" />.</returns>
        ConstructorInfo TypeInitializer
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.Attributes" /> property.</summary><returns>A <see cref="T:System.Reflection.TypeAttributes" /> object representing the attribute set of the <see cref="T:System.Type" />, unless the <see cref="T:System.Type" /> represents a generic type parameter, in which case the value is unspecified.</returns>
        TypeAttributes Attributes
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsNotPublic" /> property.</summary><returns>true if the top-level <see cref="T:System.Type" /> is not declared public; otherwise, false.</returns>
        bool IsNotPublic
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsPublic" /> property.</summary><returns>true if the top-level <see cref="T:System.Type" /> is declared public; otherwise, false.</returns>
        bool IsPublic
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsNestedPublic" /> property.</summary><returns>true if the class is nested and declared public; otherwise, false.</returns>
        bool IsNestedPublic
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsNestedPrivate" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is nested and declared private; otherwise, false.</returns>
        bool IsNestedPrivate
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsNestedFamily" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is nested and visible only within its own family; otherwise, false.</returns>
        bool IsNestedFamily
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsNestedAssembly" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is nested and visible only within its own assembly; otherwise, false.</returns>
        bool IsNestedAssembly
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsNestedFamANDAssem" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is nested and visible only to classes that belong to both its own family and its own assembly; otherwise, false.</returns>
        bool IsNestedFamANDAssem
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsNestedFamORAssem" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is nested and visible only to classes that belong to its own family or to its own assembly; otherwise, false.</returns>
        bool IsNestedFamORAssem
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsAutoLayout" /> property.</summary><returns>true if the class layout attribute AutoLayout is selected for the <see cref="T:System.Type" />; otherwise, false.</returns>
        bool IsAutoLayout
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsLayoutSequential" /> property.</summary><returns>true if the class layout attribute SequentialLayout is selected for the <see cref="T:System.Type" />; otherwise, false.</returns>
        bool IsLayoutSequential
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsExplicitLayout" /> property.</summary><returns>true if the class layout attribute ExplicitLayout is selected for the <see cref="T:System.Type" />; otherwise, false.</returns>
        bool IsExplicitLayout
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsClass" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is a class; otherwise, false.</returns>
        bool IsClass
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsInterface" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is an interface; otherwise, false.</returns>
        bool IsInterface
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsValueType" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is a value type; otherwise, false.</returns>
        bool IsValueType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsAbstract" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is abstract; otherwise, false.</returns>
        bool IsAbstract
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsSealed" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is declared sealed; otherwise, false.</returns>
        bool IsSealed
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsEnum" /> property.</summary><returns>true if the current <see cref="T:System.Type" /> represents an enumeration; otherwise, false.</returns>
        bool IsEnum
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsSpecialName" /> property.</summary><returns>true if the <see cref="T:System.Type" /> has a name that requires special handling; otherwise, false.</returns>
        bool IsSpecialName
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsImport" /> property.</summary><returns>true if the <see cref="T:System.Type" /> has <see cref="T:System.Runtime.InteropServices.ComImportAttribute" />; otherwise, false.</returns>
        bool IsImport
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsSerializable" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is serializable; otherwise, false.</returns>
        bool IsSerializable
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsAnsiClass" /> property.</summary><returns>true if the string format attribute AnsiClass is selected for the <see cref="T:System.Type" />; otherwise, false.</returns>
        bool IsAnsiClass
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsUnicodeClass" /> property.</summary><returns>true if the string format attribute UnicodeClass is selected for the <see cref="T:System.Type" />; otherwise, false.</returns>
        bool IsUnicodeClass
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsAutoClass" /> property.</summary><returns>true if the string format attribute AutoClass is selected for the <see cref="T:System.Type" />; otherwise, false.</returns>
        bool IsAutoClass
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsArray" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is an array; otherwise, false.</returns>
        bool IsArray
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsByRef" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is passed by reference; otherwise, false.</returns>
        bool IsByRef
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsPointer" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is a pointer; otherwise, false.</returns>
        bool IsPointer
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsPrimitive" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is one of the primitive types; otherwise, false.</returns>
        bool IsPrimitive
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsCOMObject" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is a COM object; otherwise, false.</returns>
        bool IsCOMObject
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.HasElementType" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is an array, a pointer, or is passed by reference; otherwise, false.</returns>
        bool HasElementType
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsContextful" /> property.</summary><returns>true if the <see cref="T:System.Type" /> can be hosted in a context; otherwise, false.</returns>
        bool IsContextful
        {
            get;
        }
    
        /// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Type.IsMarshalByRef" /> property.</summary><returns>true if the <see cref="T:System.Type" /> is marshaled by reference; otherwise, false.</returns>
        bool IsMarshalByRef
        {
            get;
        }
    
    
        void GetTypeInfoCount(ref uint pcTInfo);
        
        
        /// <summary>Retrieves the type information for an object, which can then be used to get the type information for an interface.</summary><param name="iTInfo">The type information to return.</param><param name="lcid">The locale identifier for the type information.</param><param name="ppTInfo">Receives a pointer to the requested type information object.</param>
        void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);
        
        
        void GetIDsOfNames(ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);
        
        
        void Invoke(uint dispIdMember, ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
        
        
        string ToString();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.Equals(System.Object)" /> method.</summary><returns>true if the underlying system type of <paramref name="o" /> is the same as the underlying system type of the current <see cref="T:System.Type" />; otherwise, false.</returns><param name="other">The <see cref="T:System.Object" /> whose underlying system type is to be compared with the underlying system type of the current <see cref="T:System.Type" />.</param>
        bool Equals(object other);
        
        
        int GetHashCode();
        
        
        Type GetType();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Type,System.Boolean)" /> method.</summary><returns>An array of custom attributes applied to this member, or an array with zero (0) elements if no attributes have been applied.</returns><param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned. </param><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param>
        object[] GetCustomAttributes(Type attributeType, bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.Assembly.GetCustomAttributes(System.Boolean)" /> method.</summary><returns>An array of custom attributes applied to this member, or an array with zero (0) elements if no attributes have been applied.</returns><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param>
        object[] GetCustomAttributes(bool inherit);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> method.</summary><returns>true if one or more instance of <paramref name="attributeType" /> is applied to this member; otherwise, false.</returns><param name="attributeType">The Type object to which the custom attributes are applied. </param><param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes. </param>
        bool IsDefined(Type attributeType, bool inherit);
        
        
        int GetArrayRank();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetConstructors(System.Reflection.BindingFlags)" /> method.</summary><returns>An array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing all constructors defined for the current <see cref="T:System.Type" /> that match the specified binding constraints, including the type initializer if it is defined. Returns an empty array of type <see cref="T:System.Reflection.ConstructorInfo" /> if no constructors are defined for the current <see cref="T:System.Type" />, if none of the defined constructors match the binding constraints, or if the current <see cref="T:System.Type" /> represents a type parameter of a generic type or method definition.</returns><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null.</param>
        ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetInterface(System.String,System.Boolean)" /> method.</summary><returns>A <see cref="T:System.Type" /> object representing the interface with the specified name, implemented or inherited by the current <see cref="T:System.Type" />, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the interface to get. For generic interfaces, this is the mangled name.</param><param name="ignoreCase">true to perform a case-insensitive search for <paramref name="name" />.-or- false to perform a case-sensitive search for <paramref name="name" />. </param>
        Type GetInterface(string name, bool ignoreCase);
        
        
        Type[] GetInterfaces();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.FindInterfaces(System.Reflection.TypeFilter,System.Object)" /> method.</summary><returns>An array of <see cref="T:System.Type" /> objects representing a filtered list of the interfaces implemented or inherited by the current <see cref="T:System.Type" />.-or- An empty array of type <see cref="T:System.Type" />, if no interfaces matching the filter are implemented or inherited by the current <see cref="T:System.Type" />.</returns><param name="filter">The <see cref="T:System.Reflection.TypeFilter" /> delegate that compares the interfaces against <paramref name="filterCriteria" />. </param><param name="filterCriteria">The search criteria that determines whether an interface should be included in the returned array. </param>
        Type[] FindInterfaces(TypeFilter filter, object filterCriteria);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetEvent(System.String,System.Reflection.BindingFlags)" /> method.</summary><returns>The <see cref="T:System.Reflection.EventInfo" /> object representing the specified event that is declared or inherited by the current <see cref="T:System.Type" />, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of an event that is declared or inherited by the current <see cref="T:System.Type" />. </param><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param>
        EventInfo GetEvent(string name, BindingFlags bindingAttr);
        
        
        EventInfo[] GetEvents();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetEvents(System.Reflection.BindingFlags)" /> method.</summary><returns>An array of <see cref="T:System.Reflection.EventInfo" /> objects representing all events that are declared or inherited by the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.EventInfo" />, if the current <see cref="T:System.Type" /> does not have events, or if none of the events match the binding constraints.</returns><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null.</param>
        EventInfo[] GetEvents(BindingFlags bindingAttr);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetNestedTypes(System.Reflection.BindingFlags)" /> method, and searches for the types nested within the current <see cref="T:System.Type" />, using the specified binding constraints.</summary><returns>An array of <see cref="T:System.Type" /> objects representing all the types nested within the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Type" />, if no types are nested within the current <see cref="T:System.Type" />, or if none of the nested types match the binding constraints.</returns><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null.</param>
        Type[] GetNestedTypes(BindingFlags bindingAttr);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetNestedType(System.String,System.Reflection.BindingFlags)" /> method.</summary><returns>A <see cref="T:System.Type" /> object representing the nested type that matches the specified requirements, if found; otherwise, null.</returns><param name="name">The string containing the name of the nested type to get. </param><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param>
        Type GetNestedType(string name, BindingFlags bindingAttr);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetMember(System.String,System.Reflection.MemberTypes,System.Reflection.BindingFlags)" /> method.</summary><returns>An array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public members with the specified name, if found; otherwise, an empty array.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the members to get. </param><param name="type">The <see cref="T:System.Reflection.MemberTypes" /> value to search for. </param><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return an empty array. </param>
        MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr);
        
        
        MemberInfo[] GetDefaultMembers();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.FindMembers(System.Reflection.MemberTypes,System.Reflection.BindingFlags,System.Reflection.MemberFilter,System.Object)" /> method.</summary><returns>A filtered array of <see cref="T:System.Reflection.MemberInfo" /> objects of the specified member type.-or- An empty array of type <see cref="T:System.Reflection.MemberInfo" />, if the current <see cref="T:System.Type" /> does not have members of type <paramref name="memberType" /> that match the filter criteria.</returns><param name="memberType">A MemberTypes object indicating the type of member to search for. </param><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param><param name="filter">The delegate that does the comparisons, returning true if the member currently being inspected matches the <paramref name="filterCriteria" /> and false otherwise. You can use the FilterAttribute, FilterName, and FilterNameIgnoreCase delegates supplied by this class. The first uses the fields of FieldAttributes, MethodAttributes, and MethodImplAttributes as search criteria, and the other two delegates use String objects as the search criteria. </param><param name="filterCriteria">The search criteria that determines whether a member is returned in the array of MemberInfo objects.The fields of FieldAttributes, MethodAttributes, and MethodImplAttributes can be used in conjunction with the FilterAttribute delegate supplied by this class. </param>
        MemberInfo[] FindMembers(MemberTypes memberType, BindingFlags bindingAttr, MemberFilter filter, object filterCriteria);
        
        
        Type GetElementType();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.IsSubclassOf(System.Type)" /> method.</summary><returns>true if the <see cref="T:System.Type" /> represented by the <paramref name="c" /> parameter and the current <see cref="T:System.Type" /> represent classes, and the class represented by the current <see cref="T:System.Type" /> derives from the class represented by <paramref name="c" />; otherwise, false. This method also returns false if <paramref name="c" /> and the current <see cref="T:System.Type" /> represent the same class.</returns><param name="c">The <see cref="T:System.Type" /> to compare with the current <see cref="T:System.Type" />.</param>
        bool IsSubclassOf(Type c);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.IsInstanceOfType(System.Object)" /> method.</summary><returns>true if the current <see cref="T:System.Type" /> is in the inheritance hierarchy of the object represented by <paramref name="o" />, or if the current <see cref="T:System.Type" /> is an interface that <paramref name="o" /> supports. false if neither of these conditions is the case, or if <paramref name="o" /> is null, or if the current <see cref="T:System.Type" /> is an open generic type (that is, <see cref="P:System.Type.ContainsGenericParameters" /> returns true).</returns><param name="o">The object to compare with the current <see cref="T:System.Type" />.</param>
        bool IsInstanceOfType(object o);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.IsAssignableFrom(System.Type)" /> method.</summary><returns>true if <paramref name="c" /> and the current <see cref="T:System.Type" /> represent the same type, or if the current <see cref="T:System.Type" /> is in the inheritance hierarchy of <paramref name="c" />, or if the current <see cref="T:System.Type" /> is an interface that <paramref name="c" /> implements, or if <paramref name="c" /> is a generic type parameter and the current <see cref="T:System.Type" /> represents one of the constraints of <paramref name="c" />. false if none of these conditions are the case, or if <paramref name="c" /> is null.</returns><param name="c">The <see cref="T:System.Type" /> to compare with the current <see cref="T:System.Type" />.</param>
        bool IsAssignableFrom(Type c);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetInterfaceMap(System.Type)" /> method.</summary><returns>An <see cref="T:System.Reflection.InterfaceMapping" /> object representing the interface mapping for <paramref name="interfaceType" />.</returns><param name="interfaceType">The <see cref="T:System.Type" /> of the interface of which to retrieve a mapping.</param>
        InterfaceMapping GetInterfaceMap(Type interfaceType);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Type[],System.Reflection.ParameterModifier[])" /> method.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method that matches the specified requirements, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the method to get. </param><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param><param name="binder">A <see cref="T:System.Reflection.Binder" /> object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- null, to use the <see cref="P:System.Type.DefaultBinder" />. </param><param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a method that takes no parameters. </param><param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
        MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags)" /> method.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method that matches the specified requirements, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the method to get. </param><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param>
        MethodInfo GetMethod(string name, BindingFlags bindingAttr);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetMethods(System.Reflection.BindingFlags)" /> method.</summary><returns>An array of <see cref="T:System.Reflection.MethodInfo" /> objects representing all methods defined for the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.MethodInfo" />, if no methods are defined for the current <see cref="T:System.Type" />, or if none of the defined methods match the binding constraints.</returns><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null.</param>
        MethodInfo[] GetMethods(BindingFlags bindingAttr);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetField(System.String,System.Reflection.BindingFlags)" /> method.</summary><returns>A <see cref="T:System.Reflection.FieldInfo" /> object representing the field that matches the specified requirements, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the data field to get. </param><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param>
        FieldInfo GetField(string name, BindingFlags bindingAttr);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetFields(System.Reflection.BindingFlags)" /> method.</summary><returns>An array of <see cref="T:System.Reflection.FieldInfo" /> objects representing all fields defined for the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.FieldInfo" />, if no fields are defined for the current <see cref="T:System.Type" />, or if none of the defined fields match the binding constraints.</returns><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null.</param>
        FieldInfo[] GetFields(BindingFlags bindingAttr);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetProperty(System.String,System.Reflection.BindingFlags)" /> method.</summary><returns>A <see cref="T:System.Reflection.PropertyInfo" /> object representing the property that matches the specified requirements, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the property to get. </param><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param>
        PropertyInfo GetProperty(string name, BindingFlags bindingAttr);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetProperty(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Type,System.Type[],System.Reflection.ParameterModifier[])" /> method.</summary><returns>A <see cref="T:System.Reflection.PropertyInfo" /> object representing the property that matches the specified requirements, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the property to get. </param><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param><param name="binder">A <see cref="T:System.Reflection.Binder" /> object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- null, to use the <see cref="P:System.Type.DefaultBinder" />. </param><param name="returnType">The return type of the property. </param><param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the indexed property to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a property that is not indexed. </param><param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
        PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetProperties(System.Reflection.BindingFlags)" /> method.</summary><returns>An array of <see cref="T:System.Reflection.PropertyInfo" /> objects representing all properties of the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.PropertyInfo" />, if the current <see cref="T:System.Type" /> does not have properties, or if none of the properties match the binding constraints.</returns><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null.</param>
        PropertyInfo[] GetProperties(BindingFlags bindingAttr);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetMember(System.String,System.Reflection.BindingFlags)" /> method.</summary><returns>An array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public members with the specified name, if found; otherwise, an empty array.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the members to get. </param><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return an empty array. </param>
        MemberInfo[] GetMember(string name, BindingFlags bindingAttr);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetMembers(System.Reflection.BindingFlags)" /> method.</summary><returns>An array of <see cref="T:System.Reflection.MemberInfo" /> objects representing all members defined for the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.MemberInfo" />, if no members are defined for the current <see cref="T:System.Type" />, or if none of the defined members match the binding constraints.</returns><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null.</param>
        MemberInfo[] GetMembers(BindingFlags bindingAttr);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" /> method.</summary><returns>An <see cref="T:System.Object" /> representing the return value of the invoked member.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the constructor, method, property, or field member to invoke.-or- An empty string ("") to invoke the default member. -or-For IDispatch members, a string representing the DispID, for example "[DispID=3]".</param><param name="invokeAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted. The access can be one of the BindingFlags such as Public, NonPublic, Private, InvokeMethod, GetField, and so on. The type of lookup need not be specified. If the type of lookup is omitted, BindingFlags.Public | BindingFlags.Instance will apply. </param><param name="binder">A <see cref="T:System.Reflection.Binder" /> object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- null, to use the <see cref="P:System.Type.DefaultBinder" />. </param><param name="target">The <see cref="T:System.Object" /> on which to invoke the specified member. </param><param name="args">An array containing the arguments to pass to the member to invoke. </param><param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="args" /> array. A parameter's associated attributes are stored in the member's signature. The default binder does not process this parameter. </param><param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> object representing the globalization locale to use, which may be necessary for locale-specific conversions, such as converting a numeric String to a Double.-or- null to use the current thread's <see cref="T:System.Globalization.CultureInfo" />. </param><param name="namedParameters">An array containing the names of the parameters to which the values in the <paramref name="args" /> array are passed. </param>
        object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Globalization.CultureInfo)" /> method.</summary><returns>An <see cref="T:System.Object" /> representing the return value of the invoked member.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the constructor, method, property, or field member to invoke.-or- An empty string ("") to invoke the default member. -or-For IDispatch members, a string representing the DispID, for example "[DispID=3]".</param><param name="invokeAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted. The access can be one of the BindingFlags such as Public, NonPublic, Private, InvokeMethod, GetField, and so on. The type of lookup need not be specified. If the type of lookup is omitted, BindingFlags.Public | BindingFlags.Instance will apply. </param><param name="binder">A <see cref="T:System.Reflection.Binder" /> object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- null, to use the <see cref="P:System.Type.DefaultBinder" />. </param><param name="target">The <see cref="T:System.Object" /> on which to invoke the specified member. </param><param name="args">An array containing the arguments to pass to the member to invoke. </param><param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> object representing the globalization locale to use, which may be necessary for locale-specific conversions, such as converting a numeric String to a Double.-or- null to use the current thread's <see cref="T:System.Globalization.CultureInfo" />. </param>
        object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, CultureInfo culture);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[])" /> method.</summary><returns>An <see cref="T:System.Object" /> representing the return value of the invoked member.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the constructor, method, property, or field member to invoke.-or- An empty string ("") to invoke the default member. -or-For IDispatch members, a string representing the DispID, for example "[DispID=3]".</param><param name="invokeAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted. The access can be one of the BindingFlags such as Public, NonPublic, Private, InvokeMethod, GetField, and so on. The type of lookup need not be specified. If the type of lookup is omitted, BindingFlags.Public | BindingFlags.Instance will apply. </param><param name="binder">A <see cref="T:System.Reflection.Binder" /> object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- null, to use the <see cref="P:System.Type.DefaultBinder" />. </param><param name="target">The <see cref="T:System.Object" /> on which to invoke the specified member. </param><param name="args">An array containing the arguments to pass to the member to invoke. </param>
        object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> method.</summary><returns>A <see cref="T:System.Reflection.ConstructorInfo" /> object representing the constructor that matches the specified requirements, if found; otherwise, null.</returns><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param><param name="binder">A <see cref="T:System.Reflection.Binder" /> object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- null, to use the <see cref="P:System.Type.DefaultBinder" />. </param><param name="callConvention">The <see cref="T:System.Reflection.CallingConventions" /> object that specifies the set of rules to use regarding the order and layout of arguments, how the return value is passed, what registers are used for arguments, and the stack is cleaned up. </param><param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the constructor to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a constructor that takes no parameters. </param><param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
        ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Type[],System.Reflection.ParameterModifier[])" /> method.</summary><returns>A <see cref="T:System.Reflection.ConstructorInfo" /> object representing the constructor that matches the specified requirements, if found; otherwise, null.</returns><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param><param name="binder">A <see cref="T:System.Reflection.Binder" /> object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- null, to use the <see cref="P:System.Type.DefaultBinder" />. </param><param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the constructor to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a constructor that takes no parameters.-or- <see cref="F:System.Type.EmptyTypes" />. </param><param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the parameter type array. The default binder does not process this parameter. </param>
        ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetConstructor(System.Type[])" /> method.</summary><returns>A <see cref="T:System.Reflection.ConstructorInfo" /> object representing the public instance constructor whose parameters match the types in the parameter type array, if found; otherwise, null.</returns><param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the desired constructor.-or- An empty array of <see cref="T:System.Type" /> objects, to get a constructor that takes no parameters. Such an empty array is provided by the static field <see cref="F:System.Type.EmptyTypes" />.</param>
        ConstructorInfo GetConstructor(Type[] types);
        
        
        ConstructorInfo[] GetConstructors();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> method.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the method that matches the specified requirements, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the method to get. </param><param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null. </param><param name="binder">A <see cref="T:System.Reflection.Binder" /> object that defines a set of properties and enables binding, which can involve selection of an overloaded method, coercion of argument types, and invocation of a member through reflection.-or- null, to use the <see cref="P:System.Type.DefaultBinder" />. </param><param name="callConvention">The <see cref="T:System.Reflection.CallingConventions" /> object that specifies the set of rules to use regarding the order and layout of arguments, how the return value is passed, what registers are used for arguments, and how the stack is cleaned up. </param><param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a method that takes no parameters. </param><param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
        MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetMethod(System.String,System.Type[],System.Reflection.ParameterModifier[])" /> method.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the public method that matches the specified requirements, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the public method to get. </param><param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a method that takes no parameters. </param><param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
        MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetMethod(System.String,System.Type[])" /> method.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the public method whose parameters match the specified argument types, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the public method to get. </param><param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the method to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a method that takes no parameters. </param>
        MethodInfo GetMethod(string name, Type[] types);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetMethod(System.String)" /> method.</summary><returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the public method with the specified name, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the public method to get.</param>
        MethodInfo GetMethod(string name);
        
        
        MethodInfo[] GetMethods();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetField(System.String)" /> method.</summary><returns>A <see cref="T:System.Reflection.FieldInfo" /> object representing the public field with the specified name, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the data field to get.</param>
        FieldInfo GetField(string name);
        
        
        FieldInfo[] GetFields();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetInterface(System.String)" /> method.</summary><returns>A <see cref="T:System.Type" /> object representing the interface with the specified name, implemented or inherited by the current <see cref="T:System.Type" />, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the interface to get. For generic interfaces, this is the mangled name.</param>
        Type GetInterface(string name);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetEvent(System.String)" /> method.</summary><returns>An array of <see cref="T:System.Reflection.EventInfo" /> objects representing all events that are declared or inherited by the current <see cref="T:System.Type" /> that match the specified binding constraints.-or- An empty array of type <see cref="T:System.Reflection.EventInfo" />, if the current <see cref="T:System.Type" /> does not have events, or if none of the events match the binding constraints.</returns><param name="name">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.-or- Zero, to return null.</param>
        EventInfo GetEvent(string name);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetProperty(System.String,System.Type,System.Type[],System.Reflection.ParameterModifier[])" /> method.</summary><returns>A <see cref="T:System.Reflection.PropertyInfo" /> object representing the public property that matches the specified requirements, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the public property to get. </param><param name="returnType">The return type of the property. </param><param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the indexed property to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a property that is not indexed. </param><param name="modifiers">An array of <see cref="T:System.Reflection.ParameterModifier" /> objects representing the attributes associated with the corresponding element in the <paramref name="types" /> array. The default binder does not process this parameter. </param>
        PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetProperty(System.String,System.Type,System.Type[])" /> method.</summary><returns>A <see cref="T:System.Reflection.PropertyInfo" /> object representing the public property whose parameters match the specified argument types, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the public property to get. </param><param name="returnType">The return type of the property. </param><param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the indexed property to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a property that is not indexed. </param>
        PropertyInfo GetProperty(string name, Type returnType, Type[] types);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetProperty(System.String,System.Type[])" /> method.</summary><returns>A <see cref="T:System.Reflection.PropertyInfo" /> object representing the public property whose parameters match the specified argument types, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the public property to get. </param><param name="types">An array of <see cref="T:System.Type" /> objects representing the number, order, and type of the parameters for the indexed property to get.-or- An empty array of the type <see cref="T:System.Type" /> (that is, Type[] types = new Type[0]) to get a property that is not indexed. </param>
        PropertyInfo GetProperty(string name, Type[] types);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetProperty(System.String,System.Type)" /> method.</summary><returns>A <see cref="T:System.Reflection.PropertyInfo" /> object representing the public property with the specified name, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the public property to get. </param><param name="returnType">The return type of the property. </param>
        PropertyInfo GetProperty(string name, Type returnType);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetProperty(System.String)" /> method.</summary><returns>A <see cref="T:System.Reflection.PropertyInfo" /> object representing the public property with the specified name, if found; otherwise, null.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the public property to get. </param>
        PropertyInfo GetProperty(string name);
        
        
        PropertyInfo[] GetProperties();
        
        
        Type[] GetNestedTypes();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetNestedType(System.String)" /> method.</summary><returns>A <see cref="T:System.Type" /> object representing the public nested type with the specified name, if found; otherwise, null.</returns><param name="name">The string containing the name of the nested type to get.</param>
        Type GetNestedType(string name);
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.GetMember(System.String)" /> method.</summary><returns>An array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public members with the specified name, if found; otherwise, an empty array.</returns><param name="name">The <see cref="T:System.String" /> containing the name of the public members to get.</param>
        MemberInfo[] GetMember(string name);
        
        
        MemberInfo[] GetMembers();
        
        
        /// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Type.Equals(System.Type)" /> method.</summary><returns>true if the underlying system type of <paramref name="o" /> is the same as the underlying system type of the current <see cref="T:System.Type" />; otherwise, false.</returns><param name="o">The <see cref="T:System.Type" /> whose underlying system type is to be compared with the underlying system type of the current <see cref="T:System.Type" />.</param>
        bool Equals(Type o);
        
        
    }
}
