using System.IO;

namespace CIL2Java.Java.Constants
{
    public class String : Constant
    {
        public string Value { get; set; }

        public String()
        {
            Tag = ConstantTag.String;
            Value = "";
        }

        public String(string Value)
        {
            this.Tag = ConstantTag.String;
            this.Value = Value;
        }

        public override void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);
            Writer.WriteBE(Pool.AddConstant(new Utf8(Value)));            
        }

        protected override bool CompareEqwals(Constant c)
        {
            return Value == ((String)c).Value;
        }

        protected override int GetHash()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value;
        }

        public override byte[] ReadData(BinaryReader Reader)
        {
            return Reader.ReadBytes(2);
        }

        public override void FillData(byte[] Data, ConstantPoolReader Reader)
        {
            Value = ((Utf8)Reader.GetFilledConstant(BitConverterBE.ToUInt16(Data, 0))).Value;
        }
    }
}
