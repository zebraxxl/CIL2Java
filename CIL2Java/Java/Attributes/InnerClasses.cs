using System;
using System.Collections.Generic;

namespace CIL2Java.Java.Attributes
{
    public class InnerClasses : Attribute
    {
        [Flags]
        public enum InnerClassAccessFlags: ushort
        {
            Public     = 0x0001,
            Private    = 0x0002,
            Protected  = 0x0004,
            Static     = 0x0008,
            Final      = 0x0010,
            Interface  = 0x0200,
            Abstract   = 0x0400,
            Synthetic  = 0x1000,
            Annotation = 0x2000,
            Enum       = 0x4000
        }

        public struct InnerClass
        {
            public string InnerClassInfo;
            public string OuterClassInfo;
            public string InnerName;
            public InnerClassAccessFlags AccessFlags;
        }

        public List<InnerClass> Classes { get; set; }

        public InnerClasses()
        {
            Name = "InnerClasses";
            Classes = new List<InnerClass>();
        }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);

            uint Length = (uint)(Classes.Count * 8) + 2;
            Writer.WriteBE(Length);
            Writer.WriteBE((ushort)Classes.Count);

            foreach (InnerClass Class in Classes)
            {
                Writer.WriteBE(Pool.AddConstant(new Constants.Class(Class.InnerClassInfo)));

                if (Class.OuterClassInfo == null)
                    Writer.WriteBE((ushort)0);
                else
                    Writer.WriteBE(Pool.AddConstant(new Constants.Class(Class.OuterClassInfo)));

                if (Class.InnerName == null)
                    Writer.WriteBE((ushort)0);  //anonymous inner class
                else
                    Writer.WriteBE(Pool.AddConstant(new Constants.Utf8(Class.InnerName)));
                Writer.WriteBE((ushort)Class.AccessFlags);
            }
        }

        public override string ToString()
        {
            string Result = base.ToString() + Environment.NewLine + "Classes:" + Environment.NewLine;

            foreach (InnerClass Class in Classes)
            {
                Result += "  InnerClass: " + (Class.InnerClassInfo != null ? Class.InnerClassInfo : "null")
                    + " OutterClass: " + (Class.OuterClassInfo != null ? Class.OuterClassInfo : "null") +
                    " InnerName: " + (Class.InnerName != null ? Class.InnerName : "null") +
                    " AccessFlags: " + Class.AccessFlags.ToString() + Environment.NewLine;
            }

            return Result;
        }

        public override void Dump(System.IO.StreamWriter writer, string indent)
        {
            writer.WriteLine("{0}Classes (count: {1}):", indent, Classes.Count);
            for (int i = 0; i < Classes.Count; i++)
            {
                writer.WriteLine("{0}{1,6:G}: InnerClass: {2}", indent, i, Classes[i].InnerClassInfo ?? "null");
                writer.WriteLine("{0}       OutterClass: {1}", indent, Classes[i].OuterClassInfo ?? "null");
                writer.WriteLine("{0}         InnerName: {1}", indent, Classes[i].InnerName ?? "null");
                writer.WriteLine("{0}       AccessFlags: {1}", indent, Classes[i].AccessFlags.ToString());
            }
        }

        protected override void Read(uint Length, System.IO.BinaryReader Reader, ConstantPool Pool)
        {
            ushort Count = Reader.ReadUInt16BE();

            for (int i = 0; i < Count; i++)
            {
                InnerClass Class = new InnerClass();

                ushort InnerClassInfoIndex = Reader.ReadUInt16BE();
                ushort OuterClassInfoIndex = Reader.ReadUInt16BE();
                ushort InnerNameIndex = Reader.ReadUInt16BE();

                Class.InnerClassInfo = InnerClassInfoIndex != 0 ? ((Constants.Class)Pool[InnerClassInfoIndex]).Value : null;
                Class.OuterClassInfo = OuterClassInfoIndex != 0 ? ((Constants.Class)Pool[OuterClassInfoIndex]).Value : null;
                Class.InnerName = InnerNameIndex != 0 ? ((Constants.Utf8)Pool[InnerNameIndex]).Value : null;
                Class.AccessFlags = (InnerClassAccessFlags)Reader.ReadUInt16BE();
                Classes.Add(Class);
            }
        }
    }
}
