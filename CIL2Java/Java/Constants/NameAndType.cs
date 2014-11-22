using System.IO;

namespace CIL2Java.Java.Constants
{
    public class NameAndType : Constant
    {
        public string Name { get; set; }
        public string Descriptor { get; set; }

        public NameAndType()
        {
            Tag = ConstantTag.NameAndType;
            Name = "";
            Descriptor = "";
        }

        public NameAndType(string Name, string Descriptor)
        {
            this.Tag = ConstantTag.NameAndType;
            this.Name = Name;
            this.Descriptor = Descriptor;
        }

        public override void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);
            Writer.WriteBE(Pool.AddConstant(new Utf8(Name)));
            Writer.WriteBE(Pool.AddConstant(new Utf8(Descriptor)));
        }

        protected override bool CompareEqwals(Constant c)
        {
            NameAndType Another = (NameAndType)c;

            return ((Name == Another.Name) && (Descriptor == Another.Descriptor));
        }

        protected override int GetHash()
        {
            return Name.GetHashCode() + Descriptor.GetHashCode();
        }

        public override string ToString()
        {
            return Name + ":" + Descriptor;
        }

        public override byte[] ReadData(BinaryReader Reader)
        {
            return Reader.ReadBytes(4);
        }

        public override void FillData(byte[] Data, ConstantPoolReader Reader)
        {
            ushort NameIndex = BitConverterBE.ToUInt16(Data, 0);
            ushort DescriptorIndex = BitConverterBE.ToUInt16(Data, 2);

            Name = ((Utf8)Reader.GetFilledConstant(NameIndex)).Value;
            Descriptor = ((Utf8)Reader.GetFilledConstant(DescriptorIndex)).Value;
        }
    }
}
