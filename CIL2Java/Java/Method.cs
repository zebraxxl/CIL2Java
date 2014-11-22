using System;
using System.Collections.Generic;
using System.IO;

namespace CIL2Java.Java
{
    [Flags]
    public enum MethodAccessFlags : ushort
    {
        Public       = 0x0001,
        Private      = 0x0002,
        Protected    = 0x0004,

        AccessMask = Public | Private | Protected,

        Static       = 0x0008,
        Final        = 0x0010,
        Synchronized = 0x0020,
        Bridge       = 0x0040,
        VarArgs      = 0x0080,
        Native       = 0x0100,
        Abstract     = 0x0400,
        Strict       = 0x0800,
        Synthetic    = 0x1000,
    };

    public class Method
    {
        public MethodAccessFlags AccessFlags { get; set; }
        public string Name { get; set; }
        public string Descriptor { get; set; }
        public List<Attribute> Attributes { get; set; }

        public Method()
        {
            Attributes = new List<Attribute>();
        }

        public void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            Writer.WriteBE((ushort)AccessFlags);
            Writer.WriteBE(Pool.AddConstant(new Constants.Utf8(Name)));
            Writer.WriteBE(Pool.AddConstant(new Constants.Utf8(Descriptor)));

            Writer.WriteBE((ushort)Attributes.Count);
            foreach (Attribute Attribute in Attributes)
                Attribute.Write(Writer, Pool);
        }

        public Method GetWithNewName(string NewName)
        {
            Method Result = new Method();
            Result.AccessFlags = AccessFlags;
            Result.Name = NewName;
            Result.Descriptor = Descriptor;
            Result.Attributes = new List<Attribute>(Attributes);
            return Result;
        }

        public static Method Read(BinaryReader Reader, ConstantPool Pool)
        {
            Method Result = new Method();

            Result.AccessFlags = (MethodAccessFlags)Reader.ReadUInt16BE();
            Result.Name = ((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value;
            Result.Descriptor = ((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value;

            ushort AttrCount = Reader.ReadUInt16BE();
            while (AttrCount-- > 0)
                Result.Attributes.Add(Attribute.ReadAttribute(Reader, Pool));

            return Result;
        }
    }
}
