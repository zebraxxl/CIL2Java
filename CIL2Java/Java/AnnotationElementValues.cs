using System.IO;

namespace CIL2Java.Java
{
    public partial class Annotation
    {
        public class ByteElementValue : ElementValue
        {
            public sbyte Value { get; set; }

            public ByteElementValue()
            {
                Tag = ElementValueTag.Byte;
                Value = 0;
            }

            public ByteElementValue(sbyte Value)
                :base()
            {
                Tag = ElementValueTag.Byte;
                this.Value = Value;
            }
            public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
            {
                base.Write(Writer, Pool);
                Writer.WriteBE(Pool.AddConstant(new Java.Constants.Integer(Value)));
            }

            public override string ToString()
            {
                return base.ToString() + Value.ToString();
            }

            public new static ByteElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                return new ByteElementValue((sbyte)(((Constants.Integer)Pool[Reader.ReadUInt16BE()]).Value));
            }
        }

        public class BooleanElementValue : ElementValue
        {
            public bool Value { get; set; }

            public BooleanElementValue()
            {
                Tag = ElementValueTag.Boolean;
                Value = false;
            }

            public BooleanElementValue(bool Value)
                : base()
            {
                Tag = ElementValueTag.Boolean;
                this.Value = Value;
            }

            public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
            {
                base.Write(Writer, Pool);
                Writer.WriteBE(Pool.AddConstant(new Java.Constants.Integer(Value ? 1 : 0)));
            }

            public override string ToString()
            {
                return base.ToString() + Value.ToString();
            }

            public new static BooleanElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                return new BooleanElementValue(((Constants.Integer)Pool[Reader.ReadUInt16BE()]).Value == 1);
            }
        }

        public class ShortElementValue : ElementValue
        {
            public short Value { get; set; }

            public ShortElementValue()
            {
                Tag = ElementValueTag.Short;
                Value = 0;
            }

            public ShortElementValue(short Value)
                : base()
            {
                Tag = ElementValueTag.Short;
                this.Value = Value;
            }

            public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
            {
                base.Write(Writer, Pool);
                Writer.WriteBE(Pool.AddConstant(new Java.Constants.Integer(Value)));
            }

            public override string ToString()
            {
                return base.ToString() + Value.ToString();
            }

            public new static ShortElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                return new ShortElementValue((short)(((Constants.Integer)Pool[Reader.ReadUInt16BE()]).Value));
            }
        }

        public class CharElementValue : ElementValue
        {
            public char Value { get; set; }

            public CharElementValue()
            {
                Tag = ElementValueTag.Char;
                Value = '\0';
            }

            public CharElementValue(char Value)
                : base()
            {
                Tag = ElementValueTag.Char;
                this.Value = Value;
            }

            public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
            {
                base.Write(Writer, Pool);
                Writer.WriteBE(Pool.AddConstant(new Java.Constants.Integer((ushort)Value)));
            }

            public override string ToString()
            {
                return base.ToString() + Value.ToString();
            }

            public new static CharElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                return new CharElementValue((char)(((Constants.Integer)Pool[Reader.ReadUInt16BE()]).Value));
            }
        }

        public class IntegerElementValue : ElementValue
        {
            public int Value { get; set; }

            public IntegerElementValue()
            {
                Tag = ElementValueTag.Integer;
                Value = 0;
            }

            public IntegerElementValue(int Value)
                : base()
            {
                Tag = ElementValueTag.Integer;
                this.Value = Value;
            }

            public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
            {
                base.Write(Writer, Pool);
                Writer.WriteBE(Pool.AddConstant(new Java.Constants.Integer(Value)));
            }

            public override string ToString()
            {
                return base.ToString() + Value.ToString();
            }

            public new static IntegerElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                return new IntegerElementValue(((Constants.Integer)Pool[Reader.ReadUInt16BE()]).Value);
            }
        }

        public class LongElementValue : ElementValue
        {
            public long Value { get; set; }

            public LongElementValue()
            {
                Tag = ElementValueTag.Long;
                Value = 0;
            }

            public LongElementValue(long Value)
                : base()
            {
                Tag = ElementValueTag.Long;
                this.Value = Value;
            }

            public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
            {
                base.Write(Writer, Pool);
                Writer.WriteBE(Pool.AddConstant(new Java.Constants.Long(Value)));
            }

            public override string ToString()
            {
                return base.ToString() + Value.ToString();
            }

            public new static LongElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                return new LongElementValue(((Constants.Long)Pool[Reader.ReadUInt16BE()]).Value);
            }
        }

        public class FloatElementValue : ElementValue
        {
            public float Value { get; set; }

            public FloatElementValue()
            {
                Tag = ElementValueTag.Float;
                Value = 0.0f;
            }

            public FloatElementValue(float Value)
                : base()
            {
                Tag = ElementValueTag.Float;
                this.Value = Value;
            }

            public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
            {
                base.Write(Writer, Pool);
                Writer.WriteBE(Pool.AddConstant(new Java.Constants.Float(Value)));
            }

            public override string ToString()
            {
                return base.ToString() + Value.ToString();
            }

            public new static FloatElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                return new FloatElementValue(((Constants.Float)Pool[Reader.ReadUInt16BE()]).Value);
            }
        }

        public class DoubleElementValue : ElementValue
        {
            public double Value { get; set; }

            public DoubleElementValue()
            {
                Tag = ElementValueTag.Double;
                Value = 0.0f;
            }

            public DoubleElementValue(double Value)
                : base()
            {
                Tag = ElementValueTag.Double;
                this.Value = Value;
            }

            public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
            {
                base.Write(Writer, Pool);
                Writer.WriteBE(Pool.AddConstant(new Java.Constants.Double(Value)));
            }

            public override string ToString()
            {
                return base.ToString() + Value.ToString();
            }

            public new static DoubleElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                return new DoubleElementValue(((Constants.Double)Pool[Reader.ReadUInt16BE()]).Value);
            }
        }

        public class StringElementValue : ElementValue
        {
            public string Value { get; set; }

            public StringElementValue()
            {
                Tag = ElementValueTag.String;
                Value = "";
            }

            public StringElementValue(string Value)
                : base()
            {
                Tag = ElementValueTag.String;
                this.Value = Value;
            }

            public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
            {
                base.Write(Writer, Pool);
                Writer.WriteBE(Pool.AddConstant(new Java.Constants.Utf8(Value)));
            }

            public override string ToString()
            {
                return base.ToString() + '\"' + Value.Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\r", "\\r") + '\"';
            }

            public new static StringElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                return new StringElementValue(((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value);
            }
        }

        public class EnumElementValue : ElementValue
        {
            public string Type { get; set; }
            public string Name { get; set; }

            public EnumElementValue()
            {
                Tag = ElementValueTag.Enum;
                Type = "";
                Name = "";
            }

            public EnumElementValue(string Type, string Name)
                : base()
            {
                Tag = ElementValueTag.Enum;
                this.Type = Type;
                this.Name = Name;
            }

            public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
            {
                base.Write(Writer, Pool);
                Writer.WriteBE(Pool.AddConstant(new Java.Constants.Utf8(Type)));
                Writer.WriteBE(Pool.AddConstant(new Java.Constants.Utf8(Name)));
            }

            public override string ToString()
            {
                return base.ToString() + Type + "." + Name;
            }

            public new static EnumElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                return new EnumElementValue(
                    ((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value,
                    ((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value
                    );
            }
        }

        public class ClassElementValue : ElementValue
        {
            public string Class { get; set; }

            public ClassElementValue()
            {
                Tag = ElementValueTag.Class;
                Class = "";
            }

            public ClassElementValue(string Class)
                : base()
            {
                Tag = ElementValueTag.Class;
                this.Class = Class;
            }

            public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
            {
                base.Write(Writer, Pool);
                Writer.WriteBE(Pool.AddConstant(new Java.Constants.Utf8(Class)));
            }

            public override string ToString()
            {
                return base.ToString() + Class;
            }

            public new static ClassElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                return new ClassElementValue(((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value);
            }
        }

        public class AnnotationElementValue : ElementValue
        {
            public Annotation Value { get; set; }

            public AnnotationElementValue()
            {
                Tag = ElementValueTag.Annotation;
                Value = null;
            }

            public AnnotationElementValue(Annotation Value)
                : base()
            {
                Tag = ElementValueTag.Annotation;
                this.Value = Value;
            }

            public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
            {
                if (Value == null)
                    return;

                base.Write(Writer, Pool);
                Value.Write(Writer, Pool);
            }

            public override string ToString()
            {
                return base.ToString() + Value.ToString();
            }

            public static new AnnotationElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                return new AnnotationElementValue(Annotation.Read(Reader, Pool));
            }
        }

        public class ArrayElementValue : ElementValue
        {
            public ElementValue[] Value { get; set; }

            public ArrayElementValue()
            {
                Tag = ElementValueTag.Array;
                Value = null;
            }

            public ArrayElementValue(ElementValue[] Value)
                : base()
            {
                Tag = ElementValueTag.Array;
                this.Value = Value;
            }

            public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
            {
                if (Value == null)
                    return;

                base.Write(Writer, Pool);
                Writer.WriteBE((ushort)Value.Length);
                for (int i = 0; i < Value.Length; i++)
                {
                    Value[i].Write(Writer, Pool);
                }
            }

            public override string ToString()
            {
                return base.ToString() + " { " + string.Join(", ", (object[])Value) + " }";
            }

            public static new ArrayElementValue Read(BinaryReader Reader, ConstantPool Pool)
            {
                ushort Length = Reader.ReadUInt16BE();
                ElementValue[] Values = new ElementValue[Length];

                for (int i = 0; i < Length; i++)
                    Values[i] = ElementValue.Read(Reader, Pool);

                return new ArrayElementValue(Values);
            }
        }
    }
}
