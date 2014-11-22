using System;
using System.Collections.Generic;
using System.IO;

namespace CIL2Java.Java
{
    [Flags]
    public enum FieldAccessFlags : ushort
    {
        Public    = 0x0001,
        Private   = 0x0002,
        Protected = 0x0004,
        Static    = 0x0008,
        Final     = 0x0010,
        Volatile  = 0x0040,
        Transient = 0x0080,
        Synthetic = 0x1000,
        Enum      = 0x4000
    };

    public class Field
    {
        public FieldAccessFlags AccessFlags { get; set; }
        public string Name { get; set; }
        public string Descriptor { get; set; }
        public List<Attribute> Attributes { get; set; }

        public Field()
        {
            Attributes = new List<Attribute>();
        }

        public void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            Writer.WriteBE((ushort)AccessFlags);
            Writer.WriteBE(Pool.AddConstant(new Constants.Utf8(Name)));
            Writer.WriteBE(Pool.AddConstant(new Constants.Utf8(Descriptor)));

            Writer.WriteBE((ushort)Attributes.Count);
            foreach (Attribute Attr in Attributes)
                Attr.Write(Writer, Pool);
        }

        public static Field Read(BinaryReader Reader, ConstantPool Pool)
        {
            Field Result = new Field();
            Result.AccessFlags = (FieldAccessFlags)Reader.ReadUInt16BE();
            Result.Name = ((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value;
            Result.Descriptor = ((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value;

            ushort AttrCount = Reader.ReadUInt16BE();
            while (AttrCount-- > 0)
                Result.Attributes.Add(Attribute.ReadAttribute(Reader, Pool));

            return Result;
        }
    }
}
