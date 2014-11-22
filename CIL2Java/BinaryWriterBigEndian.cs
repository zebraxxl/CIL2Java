using System;
using System.IO;

namespace CIL2Java
{
    public static class BinaryWriterBigEndian
    {
        public static byte[] Reverse(byte[] Value)
        {
            Array.Reverse(Value);
            return Value;
        }

        public static void WriteBE(this BinaryWriter Writer, short Value)
        {
            byte[] arr = Reverse(BitConverter.GetBytes(Value));
            Writer.Write(arr);
        }

        public static void WriteBE(this BinaryWriter Writer, ushort Value)
        {
            byte[] arr = Reverse(BitConverter.GetBytes(Value));
            Writer.Write(arr);
        }

        public static void WriteBE(this BinaryWriter Writer, int Value)
        {
            byte[] arr = Reverse(BitConverter.GetBytes(Value));
            Writer.Write(arr);
        }

        public static void WriteBE(this BinaryWriter Writer, uint Value)
        {
            byte[] arr = Reverse(BitConverter.GetBytes(Value));
            Writer.Write(arr);
        }

        public static void WriteBE(this BinaryWriter Writer, long Value)
        {
            byte[] arr = Reverse(BitConverter.GetBytes(Value));
            Writer.Write(arr);
        }

        public static void WriteBE(this BinaryWriter Writer, ulong Value)
        {
            byte[] arr = Reverse(BitConverter.GetBytes(Value));
            Writer.Write(arr);
        }

        public static void WriteBE(this BinaryWriter Writer, float Value)
        {
            byte[] arr = Reverse(BitConverter.GetBytes(Value));
            Writer.Write(arr);
        }

        public static void WriteBE(this BinaryWriter Writer, double Value)
        {
            byte[] arr = Reverse(BitConverter.GetBytes(Value));
            Writer.Write(arr);
        }
    }
}
