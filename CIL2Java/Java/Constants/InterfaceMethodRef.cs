using System.IO;

namespace CIL2Java.Java.Constants
{
    public class InterfaceMethodRef : Constant
    {
        public string Class { get; set; }
        public string Name { get; set; }
        public string Descriptor { get; set; }

        public InterfaceMethodRef()
        {
            Tag = ConstantTag.InterfaceMethodRef;
            Class = "";
            Name = "";
            Descriptor = "";
        }

        public InterfaceMethodRef(string Class, string Name, string Descriptor)
        {
            this.Tag = ConstantTag.InterfaceMethodRef;
            this.Class = Class;
            this.Name = Name;
            this.Descriptor = Descriptor;
        }

        public override void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);
            Writer.WriteBE(Pool.AddConstant(new Class(Class)));
            Writer.WriteBE(Pool.AddConstant(new NameAndType(Name, Descriptor)));
        }

        protected override bool CompareEqwals(Constant c)
        {
            InterfaceMethodRef Another = (InterfaceMethodRef)c;

            return ((Class == Another.Class) && (Name == Another.Name) && (Descriptor == Another.Descriptor));
        }

        protected override int GetHash()
        {
            return Class.GetHashCode() + Name.GetHashCode() + Descriptor.GetHashCode();
        }

        public override string ToString()
        {
            return Class + "." + Name + ":" + Descriptor;
        }

        public override byte[] ReadData(BinaryReader Reader)
        {
            return Reader.ReadBytes(4);
        }

        public override void FillData(byte[] Data, ConstantPoolReader Reader)
        {
            ushort ClassIndex = BitConverterBE.ToUInt16(Data, 0);
            ushort NameAndTypeIndex = BitConverterBE.ToUInt16(Data, 2);

            Class ClassConst = (Class)Reader.GetFilledConstant(ClassIndex);
            NameAndType NameAndTypeConst = (NameAndType)Reader.GetFilledConstant(NameAndTypeIndex);

            this.Class = ClassConst.Value;
            this.Name = NameAndTypeConst.Name;
            this.Descriptor = NameAndTypeConst.Descriptor;
        }
    }
}
