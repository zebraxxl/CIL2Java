using System;
using System.Collections.Generic;
using System.IO;

namespace CIL2Java.Java
{
    public class ConstantPoolReader
    {
        private ConstantPool ResultPool;
        private bool[] FiledConsts;
        private byte[][] RawData;

        public ConstantPoolReader()
        {
        }

        public ConstantPool Read(BinaryReader Reader)
        {
            ushort Count = Reader.ReadUInt16BE();

            ResultPool = new ConstantPool();
            FiledConsts = new bool[Count];
            FiledConsts[0] = true;
            RawData = new byte[Count][];

            for (int i = 1; i < Count; i++)
            {
                Constant Result = null;
                ConstantTag Tag = (ConstantTag)Reader.ReadByte();

                switch (Tag)
                {
                    case ConstantTag.Utf8:                  Result = new Constants.Utf8(); break;
                    case ConstantTag.Integer:               Result = new Constants.Integer(); break;
                    case ConstantTag.Float:                 Result = new Constants.Float(); break;
                    case ConstantTag.Long:                  Result = new Constants.Long(); break;
                    case ConstantTag.Double:                Result = new Constants.Double(); break;
                    case ConstantTag.Class:                 Result = new Constants.Class(); break;
                    case ConstantTag.String:                Result = new Constants.String(); break;
                    case ConstantTag.FieldRef:              Result = new Constants.FieldRef(); break;
                    case ConstantTag.MethodRef:             Result = new Constants.MethodRef(); break;
                    case ConstantTag.InterfaceMethodRef:    Result = new Constants.InterfaceMethodRef(); break;
                    case ConstantTag.NameAndType:           Result = new Constants.NameAndType(); break;
                    case ConstantTag.MethodHandle:          Result = new Constants.MethodHandle(); break;
                    case ConstantTag.MethodType:            Result = new Constants.MethodType(); break;
                    case ConstantTag.InvokeDynamic:         Result = new Constants.InvokeDynamic(); break;
                }

                if (Result == null)
                {
                    ResultPool.ForceAddConstant(new Constants.Skip(), (ushort)i);
                    Messages.Message(MessageCode.JavaUnknownConstantTag, ((byte)Tag).ToString());
                    continue;
                }

                RawData[i] = Result.ReadData(Reader);
                ResultPool.ForceAddConstant(Result, (ushort)i);
                if (Result.Is8Byte())
                    FiledConsts[++i] = true;
            }

            for (int i = 1; i < Count; i++)
            {
                GetFilledConstant((ushort)i);
            }

            return ResultPool;
        }

        public Constant GetFilledConstant(ushort i)
        {
            if (!FiledConsts[i])
            {
                ResultPool[i].FillData(RawData[i], this);
                FiledConsts[i] = true;
            }
            return ResultPool[i];
        }
    }
}
