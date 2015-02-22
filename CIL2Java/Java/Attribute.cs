using System.IO;

namespace CIL2Java.Java
{
    namespace Attributes
    {
        public class RawAttribute : Attribute
        {
            public byte[] Value { get; protected set; }

            public override void Write(BinaryWriter Writer, ConstantPool Pool)
            {
                base.Write(Writer, Pool);
                Writer.WriteBE((uint)Value.Length);
                Writer.Write(Value);
            }

            protected override void Read(uint Length, BinaryReader Reader, ConstantPool Pool)
            {
                Value = Reader.ReadBytes((int)Length);
            }
        }
    }

    public abstract class Attribute
    {
        public string Name { get; protected set; }

        protected abstract void Read(uint Length, BinaryReader Reader, ConstantPool Pool);

        public virtual void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            Writer.WriteBE(Pool.AddConstant(new Constants.Utf8(Name)));
        }

        public override string ToString()
        {
            return "Name: " + Name;
        }

        public virtual void Dump(StreamWriter writer, string indent)
        {
        }

        public static Attribute ReadAttribute(BinaryReader Reader, ConstantPool Pool)
        {
            string Name = ((Constants.Utf8)Pool[Reader.ReadUInt16BE()]).Value;
            uint Length = Reader.ReadUInt32BE();
            long Next = (long)Reader.BaseStream.Position - (long)(Length - 6);

            Attribute Result = null;

            if (Name == "AnnotationDefault")
                Result = new Attributes.AnnotationDefault();
            else if (Name == "Code")
                Result = new Attributes.Code();
            else if (Name == "ConstantValue")
                Result = new Attributes.ConstantValue();
            else if (Name == "Deprecated")
                Result = new Attributes.Deprecated();
            else if (Name == "Exceptions")
                Result = new Attributes.Exceptions();
            else if (Name == "InnerClasses")
                Result = new Attributes.InnerClasses();
            else if (Name == "LineNumberTable")
                Result = new Attributes.LineNumberTable();
            else if (Name == "LocalVariableTable")
                Result = new Attributes.LocalVariableTable();
            else if (Name == "RuntimeVisibleAnnotations")
                Result = new Attributes.RuntimeVisibleAnnotations();
            else if (Name == "RuntimeInvisibleAnnotations")
                Result = new Attributes.RuntimeInvisibleAnnotations();
            else if (Name == "RuntimeVisibleParameterAnnotations")
                Result = new Attributes.RuntimeVisibleParameterAnnotations(Reader.ReadByte());
            else if (Name == "RuntimeInvisibleParameterAnnotations")
                Result = new Attributes.RuntimeInvisibleParameterAnnotations(Reader.ReadByte());
            else if (Name == "Signature")
                Result = new Attributes.Signature();
            else if (Name == "SourceFile")
                Result = new Attributes.SourceFile();
            else if (Name == "Synthetic")
                Result = new Attributes.Synthetic();
            else
            {
                Result = new Attributes.RawAttribute();
                Result.Name = Name;
            }

            Result.Read(Length, Reader, Pool);
            return Result;
        }
    }
}
