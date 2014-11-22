using System;
using System.Collections.Generic;

namespace CIL2Java.Java.Constants
{
    public class InvokeDynamic : Constant
    {
        public ushort BootstrapMethodAttrIndex { get; set; }
        public string Name { get; set; }
        public string Descriptor { get; set; }

        public InvokeDynamic()
        {
            Tag = ConstantTag.InvokeDynamic;
            BootstrapMethodAttrIndex = 0;
            Name = "";
            Descriptor = "";
        }

        public InvokeDynamic(ushort BootstrapMethodAttrIndex, string Name, string Descriptor)
        {
            this.Tag = ConstantTag.InvokeDynamic;
            this.BootstrapMethodAttrIndex = BootstrapMethodAttrIndex;
            this.Name = Name;
            this.Descriptor = Descriptor;
        }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);
            Writer.WriteBE(BootstrapMethodAttrIndex);
            Writer.WriteBE(Pool.AddConstant(new NameAndType(Name, Descriptor)));
        }

        protected override bool CompareEqwals(Constant c)
        {
            InvokeDynamic A = (InvokeDynamic)c;

            return ((BootstrapMethodAttrIndex == A.BootstrapMethodAttrIndex) && (Name == A.Name) && (Descriptor == A.Descriptor));
        }

        protected override int GetHash()
        {
            return BootstrapMethodAttrIndex ^ Name.GetHashCode() ^ Descriptor.GetHashCode();
        }

        public override string ToString()
        {
            return BootstrapMethodAttrIndex.ToString() + "." + Name + ":" + Descriptor;
        }

        public override byte[] ReadData(System.IO.BinaryReader Reader)
        {
            return Reader.ReadBytes(4);
        }

        public override void FillData(byte[] Data, ConstantPoolReader Reader)
        {
            BootstrapMethodAttrIndex = BitConverterBE.ToUInt16(Data, 0);

            NameAndType N = (NameAndType)Reader.GetFilledConstant(BitConverterBE.ToUInt16(Data, 2));
            Name = N.Name;
            Descriptor = N.Descriptor;
        }
    }
}
