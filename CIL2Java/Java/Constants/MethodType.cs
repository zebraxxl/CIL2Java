using System.IO;

namespace CIL2Java.Java.Constants
{
    public class MethodType : Constant
    {
        public string Descriptor { get; set; }

        public MethodType()
        {
            Tag = ConstantTag.MethodType;
            Descriptor = "";
        }

        public MethodType(string Descriptor)
        {
            this.Tag = ConstantTag.MethodType;
            this.Descriptor = Descriptor;
        }

        public override void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);
            Writer.WriteBE(Pool.AddConstant(new Utf8(Descriptor)));
        }

        protected override bool CompareEqwals(Constant c)
        {
            return Descriptor == ((MethodType)c).Descriptor;
        }

        protected override int GetHash()
        {
            return Descriptor.GetHashCode();
        }

        public override string ToString()
        {
            return Descriptor;
        }

        public override byte[] ReadData(BinaryReader Reader)
        {
            return Reader.ReadBytes(2);
        }

        public override void FillData(byte[] Data, ConstantPoolReader Reader)
        {
            Descriptor = ((Utf8)Reader.GetFilledConstant(BitConverterBE.ToUInt16(Data, 0))).Value;
        }
    }
}
