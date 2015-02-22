using System;
using System.Collections.Generic;
using System.IO;

namespace CIL2Java.Java.Attributes
{
    public class RuntimeInvisibleAnnotations : Attribute
    {
        public List<Annotation> Annotations { get; private set; }

        public RuntimeInvisibleAnnotations()
        {
            Name = "RuntimeInvisibleAnnotations";
            Annotations = new List<Annotation>();
        }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);

            MemoryStream TmpStream = new MemoryStream();
            BinaryWriter TmpWriter = new BinaryWriter(TmpStream);

            TmpWriter.WriteBE((ushort)Annotations.Count);
            foreach (Annotation A in Annotations)
                A.Write(TmpWriter, Pool);

            byte[] ByteArray = TmpStream.ToArray();
            TmpStream.Close();

            Writer.WriteBE(ByteArray.Length);
            Writer.Write(ByteArray);
        }

        public override string ToString()
        {
            string Result = base.ToString() + Environment.NewLine + "Values:" + Environment.NewLine;

            foreach (Annotation A in Annotations)
            {
                string[] Lines = A.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string Line in Lines)
                    Result += "  " + Line + Environment.NewLine;
            }

            return Result;
        }

        public override void Dump(StreamWriter writer, string indent)
        {
            writer.WriteLine("{0}Count: {1}", indent, Annotations.Count);
            for (int i = 0; i < Annotations.Count; i++)
            {
                writer.WriteLine("{0}{1,6G}:", i);
                Annotations[i].Dump(writer, indent + "      ");
            }
        }

        protected override void Read(uint Length, BinaryReader Reader, ConstantPool Pool)
        {
            ushort Count = Reader.ReadUInt16BE();
            for (int i = 0; i < Count; i++)
                Annotations.Add(Annotation.Read(Reader, Pool));
        }
    }
}
