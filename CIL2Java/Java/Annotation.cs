using System;
using System.Collections.Generic;
using System.IO;

namespace CIL2Java.Java
{
    public partial class Annotation
    {
        public enum ElementValueTag : byte
        {
            Byte        = 0x42,
            Char        = 0x43,
            Double      = 0x44,
            Float       = 0x46,
            Integer     = 0x49,
            Long        = 0x4A,
            Short       = 0x53,
            Boolean     = 0x5A,
            String      = 0x73,
            Enum        = 0x65,
            Class       = 0x63,
            Annotation  = 0x40,
            Array       = 0x5B
        }

        public class ElementValue
        {
            public ElementValueTag Tag { get; protected set; }

            public static ElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                ElementValueTag Tag = (ElementValueTag)Reader.ReadByte();

                switch (Tag)
                {
                    case ElementValueTag.Byte: return ByteElementValue.Read(Reader, Pool);
                    case ElementValueTag.Char: return CharElementValue.Read(Reader, Pool);
                    case ElementValueTag.Double: return DoubleElementValue.Read(Reader, Pool);
                    case ElementValueTag.Float: return FloatElementValue.Read(Reader, Pool);
                    case ElementValueTag.Integer: return IntegerElementValue.Read(Reader, Pool);
                    case ElementValueTag.Long: return LongElementValue.Read(Reader, Pool);
                    case ElementValueTag.Short: return ShortElementValue.Read(Reader, Pool);
                    case ElementValueTag.Boolean: return BooleanElementValue.Read(Reader, Pool);
                    case ElementValueTag.String: return StringElementValue.Read(Reader, Pool);
                    case ElementValueTag.Enum: return EnumElementValue.Read(Reader, Pool);
                    case ElementValueTag.Class: return ClassElementValue.Read(Reader, Pool);
                    case ElementValueTag.Annotation: return AnnotationElementValue.Read(Reader, Pool);
                    case ElementValueTag.Array: return ArrayElementValue.Read(Reader, Pool);
                    default: return null;
                }
            }

            public virtual void Write(BinaryWriter Writer, ConstantPool Pool)
            {
                Writer.Write((byte)Tag);
            }

            public override string ToString()
            {
                return "[" + Tag.ToString() + "]";
            }
        }

        public string Type { get; set; }
        public Dictionary<string, ElementValue> ValuePairs { get; private set; }

        public Annotation()
        {
            Type = null;
            ValuePairs = new Dictionary<string, ElementValue>();
        }

        public static Annotation Read(BinaryReader Reader, ConstantPool Pool)
        {
            Annotation Result = new Annotation();
            Result.Type = ((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value;

            ushort KeyValueCount = Reader.ReadUInt16BE();
            while (KeyValueCount-- > 0)
            {
                string Key = ((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value;
                ElementValue Value = ElementValue.Read(Reader, Pool);
                if (Value != null)
                    Result.ValuePairs.Add(Key, Value);
            }

            return Result;
        }

        public void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            Writer.WriteBE(Pool.AddConstant(new Java.Constants.Utf8(Type)));
            Writer.WriteBE((ushort)ValuePairs.Count);

            foreach (KeyValuePair<string, ElementValue> Element in ValuePairs)
            {
                Writer.WriteBE(Pool.AddConstant(new Java.Constants.Utf8(Element.Key)));
                Element.Value.Write(Writer, Pool);
            }
        }

        public override string ToString()
        {
            string Result = "Annotation:" + Environment.NewLine + "  Type: " + Type + Environment.NewLine + "  Value pairs:" + Environment.NewLine;

            foreach (KeyValuePair<string, ElementValue> V in ValuePairs)
            {
                Result += "    " + V.Key + " = " + V.Value.ToString() + Environment.NewLine;
            }

            return Result;
        }
    }
}
