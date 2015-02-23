using System;
using System.Collections.Generic;
using System.IO;

namespace CIL2Java.Java.Attributes
{
    public class RuntimeInvisibleParameterAnnotations : Attribute
    {
        public List<Annotation>[] ParamsAnnotations { get; private set; }

        public bool HasValues
        {
            get
            {
                for (int i = 0; i < ParamsAnnotations.Length; i++)
                    if (ParamsAnnotations[i].Count > 0)
                        return true;

                return false;
            }
        }

        public RuntimeInvisibleParameterAnnotations(int ParamsCount)
        {
            Name = "RuntimeInvisibleParameterAnnotations";
            ParamsAnnotations = new List<Annotation>[ParamsCount];

            for (int i = 0; i < ParamsCount; i++)
                ParamsAnnotations[i] = new List<Annotation>();
        }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);

            MemoryStream TmpStream = new MemoryStream();
            BinaryWriter TmpWriter = new BinaryWriter(TmpStream);

            TmpWriter.Write((byte)ParamsAnnotations.Length);

            for (int i = 0; i < ParamsAnnotations.Length; i++)
            {
                TmpWriter.WriteBE((ushort)ParamsAnnotations[i].Count);

                foreach (Annotation A in ParamsAnnotations[i])
                {
                    A.Write(TmpWriter, Pool);
                }
            }

            byte[] ByteArray = TmpStream.ToArray();
            TmpStream.Close();

            Writer.WriteBE(ByteArray.Length);
            Writer.Write(ByteArray);
        }

        public override string ToString()
        {
            string Result = base.ToString() + Environment.NewLine;

            for (int i = 0; i < ParamsAnnotations.Length; i++)
            {
                Result += "Parameter " + i.ToString() + " annotations:" + Environment.NewLine;

                foreach (Annotation A in ParamsAnnotations[i])
                {
                    string[] Lines = A.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string Line in Lines)
                        Result += "  " + Line + Environment.NewLine;
                }
            }
            return Result;
        }

        public override void Dump(TextWriter writer, string indent)
        {
            writer.WriteLine("{0}Count: {1}", indent, ParamsAnnotations.Length);
            for (int i = 0; i < ParamsAnnotations.Length; i++)
            {
                writer.WriteLine("{0}{1,6:G} Count: {1}", indent, i, ParamsAnnotations[i].Count);
                for (int j = 0; j < ParamsAnnotations[i].Count; j++)
                {
                    writer.WriteLine("{0}      {1,6:G}:", indent, j);
                    ParamsAnnotations[i][j].Dump(writer, indent + "            ");
                }
            }
        }

        protected override void Read(uint Length, BinaryReader Reader, ConstantPool Pool)
        {
            for (int i = 0; i < ParamsAnnotations.Length; i++)
            {
                ushort Count = Reader.ReadUInt16BE();
                for (int j = 0; j < Count; j++)
                    ParamsAnnotations[i].Add(Annotation.Read(Reader, Pool));
            }
        }
    }
}
