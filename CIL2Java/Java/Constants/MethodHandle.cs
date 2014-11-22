using System;
using System.Collections.Generic;

namespace CIL2Java.Java.Constants
{
    public class MethodHandle : Constant
    {
        public enum ReferenceKind : byte
        {
            Unknown = 0,
            GetField = 1,
            GetStatic = 2,
            PutField = 3,
            PutStatic = 4,
            InvokeVirtual = 5,
            InvokeStatic = 6,
            InvokeSpecial = 7,
            NewInvokeSpecial = 8,
            InvokeInterface = 9,
        }

        public ReferenceKind Kind { get; set; }
        public Constant Reference { get; set; }

        public MethodHandle()
        {
            Tag = ConstantTag.MethodHandle;
            Kind = ReferenceKind.Unknown;
            Reference = null;
        }

        public MethodHandle(ReferenceKind Kind, Constant Reference)
        {
            this.Tag = ConstantTag.MethodHandle;
            this.Kind = Kind;
            this.Reference = Reference;
        }

        public override void Write(System.IO.BinaryWriter Writer, ConstantPool Pool)
        {
            base.Write(Writer, Pool);
            Writer.Write((byte)Kind);
            Writer.WriteBE(Pool.AddConstant(Reference));
        }

        protected override bool CompareEqwals(Constant c)
        {
            if (Kind != ((MethodHandle)c).Kind)
                return false;
            return (Reference == ((MethodHandle)c).Reference);
        }

        protected override int GetHash()
        {
            return (int)Kind ^ (Reference != null ? Reference.GetHashCode() : 0);
        }

        public override string ToString()
        {
            return "[" + Kind.ToString() + "] " + (Reference != null ? Reference.ToString() : "(null)"); 
        }

        public override byte[] ReadData(System.IO.BinaryReader Reader)
        {
            return Reader.ReadBytes(3);
        }

        public override void FillData(byte[] Data, ConstantPoolReader Reader)
        {
            Kind = (ReferenceKind)Data[0];
            Reference = Reader.GetFilledConstant(BitConverterBE.ToUInt16(Data, 1));
        }
    }
}
