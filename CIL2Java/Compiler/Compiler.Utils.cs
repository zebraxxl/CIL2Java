using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public partial class Compiler
    {
        private void DummyLink(string typeName)
        {
            TypeDefinition typeDef = loadedModules.Select(MD => MD.GetType(typeName)).Where(T => T != null).FirstOrDefault();

            if (typeDef != null)
            {
                typeDef.Methods.Where(M => M.Name == ClassNames.DummyLinkMethodName).ForEach(M =>
                    ((IResolver)this).Resolve(M, null));
            }
        }
    }
}
