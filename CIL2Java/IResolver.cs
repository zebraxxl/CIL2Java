using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CIL2Java
{
    public interface IResolver
    {
        InterType Resolve(TypeReference typeRef, List<InterGenericArgument> genericArgs);
        InterType Resolve(string Fullname);
        InterField Resolve(FieldReference fldRef, List<InterGenericArgument> genericArgs);
        InterMethod Resolve(MethodReference methodRef, List<InterGenericArgument> genericArgs);
        int GetGenericsArgsIndex(string GenericsArgsString);
    }
}
