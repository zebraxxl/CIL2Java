using System.IO;
using System.Text;

namespace CIL2Java.Java.Constants
{
    public class Utf8 : Constant
    {
        public string Value { get; set; }

        public Utf8()
        {
            Tag = ConstantTag.Utf8;
            Value = "";
        }

        public Utf8(string Value)
        {
            this.Tag = ConstantTag.Utf8;
            this.Value = Value;
        }

        public override void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);

            byte[] Utf8EncodedValue = Encoding.UTF8.GetBytes(Value);

            Writer.WriteBE((ushort)Utf8EncodedValue.Length);
            Writer.Write(Utf8EncodedValue);
        }


        protected override bool CompareEqwals(Constant c)
        {
            return Value == ((Utf8)c).Value;
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
            ushort Legnth = Reader.ReadUInt16BE();
            return Reader.ReadBytes(Legnth);
        }

        public override void FillData(byte[] Data, ConstantPoolReader Reader)
        {
            Value = Encoding.UTF8.GetString(Data);
        }
    }
}
