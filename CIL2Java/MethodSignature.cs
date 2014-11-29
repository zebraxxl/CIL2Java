using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public struct MethodSignature
    {
        public string Name;
        public string[] Parameters;

        public MethodSignature(InterMethod method)
        {
            this.Name = method.Name;
            this.Parameters = method.Parameters.Select(IP => IP.Type.Fullname).ToArray();
        }

        public MethodSignature(MethodReference methodRef)
        {
            this.Name = methodRef.Name;
            this.Parameters = methodRef.Parameters.Select(PD => PD.ParameterType.FullName).ToArray();
        }

        public static bool operator==(MethodSignature a, MethodSignature b)
        {
            if (a.Name != b.Name) return false;
            if (a.Parameters.Length != b.Parameters.Length) return false;
            for (int i = 0; i < a.Parameters.Length; i++)
                if (a.Parameters[i] != b.Parameters[i])
                    return false;
            return true;
        }
        public static bool operator !=(MethodSignature a, MethodSignature b)
        {
            if (a.Name != b.Name) return true;
            if (a.Parameters.Length != b.Parameters.Length) return true;
            for (int i = 0; i < a.Parameters.Length; i++)
                if (a.Parameters[i] != b.Parameters[i])
                    return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is MethodSignature)) return false;

            MethodSignature o = (MethodSignature)obj;
            return this == o;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Parameters.Select(s => s.GetHashCode()).Sum();
        }
    }
}
