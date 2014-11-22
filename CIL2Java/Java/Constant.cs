using System.IO;

namespace CIL2Java.Java
{
    public enum ConstantTag : byte
    {
        Skip = 0,
        Utf8 = 1,
        Integer = 3,
        Float = 4,
        Long = 5,
        Double = 6,
        Class = 7,
        String = 8,
        FieldRef = 9,
        MethodRef = 10,
        InterfaceMethodRef = 11,
        NameAndType = 12,
        MethodHandle = 15,
        MethodType = 16,
        InvokeDynamic = 18
    }

    public abstract class Constant
    {
        public ConstantTag Tag { get; protected set; }

        protected abstract bool CompareEqwals(Constant c);
        protected abstract int GetHash();

        public static bool operator==(Constant f, Constant s)
        {
            if (((object)f == null) && ((object)s == null))
                return true;
            if (((object)f == null) || ((object)s == null))
                return false;

            if (f.Tag != s.Tag)
                return false;
            return f.CompareEqwals(s);
        }

        public static bool operator!=(Constant f, Constant s)
        {
            if (((object)f == null) && ((object)s == null))
                return false;
            if (((object)f == null) || ((object)s == null))
                return true;

            if (f.Tag != s.Tag)
                return true;
            return !f.CompareEqwals(s);
        }

        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType())
                return false;
            return this == (Constant)obj;
        }

        public override int GetHashCode()
        {
            return (int)Tag + GetHash();
        }

        public virtual bool Is8Byte()
        {
            return false;
        }

        public virtual void Write(BinaryWriter Writer, ConstantPool Pool)
        {
            Writer.Write((byte)Tag);
        }

        public abstract byte[] ReadData(BinaryReader Reader);
        public abstract void FillData(byte[] Data, ConstantPoolReader Reader);
    }

    namespace Constants
    {
        public class Skip : Constant
        {
            public Skip()
            {
                Tag = ConstantTag.Skip;
            }

            protected override bool CompareEqwals(Constant c)
            {
                return true;
            }

            public override void Write(BinaryWriter Writer, ConstantPool Pool)
            {
            }

            protected override int GetHash()
            {
                return 0;
            }

            public override byte[] ReadData(BinaryReader Reader)
            {
                return new byte[0];
            }

            public override void FillData(byte[] Data, ConstantPoolReader Reader)
            {
            }
        }
    }
}
