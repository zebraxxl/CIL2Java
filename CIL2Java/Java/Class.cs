using System;
using System.Collections.Generic;
using System.IO;

namespace CIL2Java.Java
{
    [Flags]
    public enum ClassAccessFlag : ushort
    {
        Public     = 0x0001,
        Final      = 0x0010,
        Super      = 0x0020,
        Interface  = 0x0200,
        Abstract   = 0x0400,
        Synthetic  = 0x1000,
        Annotation = 0x2000,
        Enum       = 0x4000
    }

    public class Class
    {
        private const uint Magic = 0xCAFEBABE;

        public ushort MinorVersion { get; private set; }
        public ushort MajorVersion { get; private set; }

        public ConstantPool ConstantPool { get; private set; }

        public ClassAccessFlag AccessFlag { get; set; }
        public string ThisClass { get; set; }
        public string SuperClass { get; set; }

        public List<string> Interfaces { get; private set; }
        public List<Field> Fields { get; private set; }
        public List<Method> Methods { get; private set; }
        public List<Attribute> Attributes { get; private set; }

        public Class()
        {
            ConstantPool = new ConstantPool();
            //ConstantPool.AddConstant(new Constants.Skip());

            AccessFlag = 0;
            ThisClass = "";
            SuperClass = null;
            Interfaces = new List<string>();
            Fields = new List<Field>();
            Methods = new List<Method>();
            Attributes = new List<Attribute>();
            MajorVersion = 49;
            MinorVersion = 0;
        }

        public void Write(Stream Output)
        {
            ConstantPool ConstantPoolCopy = new Java.ConstantPool(ConstantPool);

            MemoryStream ClassBodyStream = new MemoryStream();
            BinaryWriter ClassBodyWriter = new BinaryWriter(ClassBodyStream);

            ClassBodyWriter.WriteBE((ushort)AccessFlag);
            ClassBodyWriter.WriteBE(ConstantPoolCopy.AddConstant(new Constants.Class(ThisClass)));
            if (SuperClass != null)
                ClassBodyWriter.WriteBE(ConstantPoolCopy.AddConstant(new Constants.Class(SuperClass)));
            else
                ClassBodyWriter.WriteBE((ushort)0);

            ClassBodyWriter.WriteBE((ushort)Interfaces.Count);
            foreach(string Interface in Interfaces)
                ClassBodyWriter.WriteBE(ConstantPoolCopy.AddConstant(new Constants.Class(Interface)));

            ClassBodyWriter.WriteBE((ushort)Fields.Count);
            foreach (Field Field in Fields)
                Field.Write(ClassBodyWriter, ConstantPoolCopy);

            ClassBodyWriter.WriteBE((ushort)Methods.Count);
            foreach (Method Method in Methods)
                Method.Write(ClassBodyWriter, ConstantPoolCopy);

            ClassBodyWriter.WriteBE((ushort)Attributes.Count);
            foreach (Attribute Attribute in Attributes)
                Attribute.Write(ClassBodyWriter, ConstantPoolCopy);

            ClassBodyWriter.Flush();
            ClassBodyWriter.Seek(0, SeekOrigin.Begin);

            byte[] ClassBody = ClassBodyStream.ToArray();
            ClassBodyWriter.Close();

            ClassBodyWriter = new BinaryWriter(Output);

            ClassBodyWriter.WriteBE(Magic);
            ClassBodyWriter.WriteBE(MinorVersion);
            ClassBodyWriter.WriteBE(MajorVersion);

            int CountPosition = (int)Output.Position;
            ClassBodyWriter.WriteBE((ushort)0);
            for (ushort i = 0; i < ConstantPoolCopy.Length; i++)
                ConstantPoolCopy[i].Write(ClassBodyWriter, ConstantPoolCopy);
            ClassBodyWriter.Seek(CountPosition, SeekOrigin.Begin);
            ClassBodyWriter.WriteBE(ConstantPoolCopy.Length);
            ClassBodyWriter.Seek(0, SeekOrigin.End);
            ClassBodyWriter.Write(ClassBody);
        }

        public static Class Read(Stream Input)
        {
            BinaryReader Reader = new BinaryReader(Input);

            uint FileMagic = Reader.ReadUInt32BE();
            if (FileMagic != Magic)
                return null;

            ConstantPoolReader CPReader = new ConstantPoolReader();

            Class Result = new Class();

            Result.MinorVersion = Reader.ReadUInt16BE();
            Result.MajorVersion = Reader.ReadUInt16BE();
            ConstantPool Pool = Result.ConstantPool = CPReader.Read(Reader);

            Result.AccessFlag = (ClassAccessFlag)Reader.ReadUInt16BE();
            Result.ThisClass = ((Constants.Class)Pool[Reader.ReadUInt16BE()]).Value;

            ushort SuperClassIndex = Reader.ReadUInt16BE();
            if (SuperClassIndex != 0)
                Result.SuperClass = ((Constants.Class)Pool[SuperClassIndex]).Value;

            ushort InterfacesCount = Reader.ReadUInt16BE();
            while (InterfacesCount-- > 0)
                Result.Interfaces.Add(((Constants.Class)Pool[Reader.ReadUInt16BE()]).Value);

            ushort FieldsCount = Reader.ReadUInt16BE();
            while (FieldsCount-- > 0)
                Result.Fields.Add(Field.Read(Reader, Pool));

            ushort MethodsCount = Reader.ReadUInt16BE();
            while (MethodsCount-- > 0)
                Result.Methods.Add(Method.Read(Reader, Pool));

            ushort AttrCount = Reader.ReadUInt16BE();
            while (AttrCount-- > 0)
                Result.Attributes.Add(Attribute.ReadAttribute(Reader, Pool));

            return Result;
        }
    }
}
