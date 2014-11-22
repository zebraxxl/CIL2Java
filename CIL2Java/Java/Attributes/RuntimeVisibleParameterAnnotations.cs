using System;
using System.Collections.Generic;
using System.IO;

namespace CIL2Java.Java.Attributes
{
    public static class RuntimeParameterAnnotations
    {
        private static string BaseTypeChars = "BCDFIJSZ";

        public static int GetParametersCount(string Descriptor)
        {
            int Result = 0;
            int i = 1;

            if (Descriptor[0] != '(')
                return -1;

            while ((i < Descriptor.Length) && (Descriptor[i] != ')'))
            {
                while ((i < Descriptor.Length) && (Descriptor[i] == '['))
                    i++;
                if (i == Descriptor.Length)
                    return -1;

                if (BaseTypeChars.Contains(Descriptor[i].ToString()))
                    Result++;
                else if (Descriptor[i] == 'L')
                {
                    Result++;
                    while ((i < Descriptor.Length) && (Descriptor[i] != ';'))
                        i++;
                    if (i == Descriptor.Length)
                        return -1;
                }
                else
                    return -1;

                i++;
            }

            return Result;
        }
    }

    public class RuntimeVisibleParameterAnnotations : Attribute
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

        public RuntimeVisibleParameterAnnotations(int ParamsCount)
        {
            Name = "RuntimeVisibleParameterAnnotations";
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
