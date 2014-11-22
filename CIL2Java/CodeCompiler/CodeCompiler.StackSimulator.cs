using System;
using System.Collections.Generic;
using System.Linq;
using CIL2Java.Java;

namespace CIL2Java
{
    public partial class CodeCompiler
    {
        private class StackImitator
        {
            private int val;
            private int max;

            public StackImitator()
            {
                val = 0;
                max = 0;
            }

            public int Value { get { return val; } set { val = value; max = Math.Max(val, max); } }
            public int MaxValue { get { return max; } }

            public void Push(int Count)
            {
                val += Count;
                max = Math.Max(val, max);
            }

            public void Pop(int Count)
            {
                val -= Count;
                max = Math.Max(val, max);
            }
        }

        private void SimulateStack(Java.ConstantPool Pool)
        {
            List<int> SimulatedInstructions = new List<int>();
            Dictionary<int, int> Branches = new Dictionary<int, int>();
            StackImitator Stack = new StackImitator();

            Branches.Add(0, 0);
            foreach (Java.Attributes.Code.Exception E in resultCode.ExceptionTable)
                Branches.Add(E.HandlerPC, 1);

            byte[] Code = resultCode.CodeBytes;
            int CodeLength = Code.Length;
            bool LastWide = false;

            while (Branches.Count > 0)
            {
                KeyValuePair<int, int> Branch = Branches.First();
                Branches.Remove(Branch.Key);

                Stack.Value = Branch.Value;
                int Position = Branch.Key;

                while (Position < CodeLength)
                {
                    if (SimulatedInstructions.Contains(Position))
                        break;
                    SimulatedInstructions.Add(Position);

                    Java.OpCodes OpCode = (Java.OpCodes)Code[Position];
                    if (OpCode == Java.OpCodes.wide)
                    {
                        LastWide = true;
                        Position++;
                        continue;
                    }

                    ByteCode.JavaInstructionDescption Desc = ByteCode.JavaInstructions[OpCode];
                    int Size = Desc.Size;
                    if (LastWide)
                    {
                        Size = (Size - 1) * 2 + 1;
                        LastWide = false;
                    }

                    int Operand = 0;
                    if ((Desc.OpType != ByteCode.JavaOperandType.None) && (Desc.OpType != ByteCode.JavaOperandType.Special))
                        Operand = BitConverterBE.ReadAsInt32(Code, Position + 1, Size - 1);

                    if (Desc.OpType == ByteCode.JavaOperandType.Special)
                    {
                        if (OpCode == Java.OpCodes.invokeinterface)
                        {
                            Operand = BitConverterBE.ReadAsInt32(Code, Position + 1, Size - 1);
                            uint tmp = ((uint)((Operand & 0xffff0000) >> 16) | (uint)((Operand & 0xffff) << 16));
                            Operand = unchecked((int)tmp);
                        }
                    }

                    if (Desc.PopAction != null)
                        Stack.Pop(Desc.PopAction(Operand, Pool));
                    if (Desc.PushAction != null)
                        Stack.Push(Desc.PushAction(Operand, Pool));

                    if (Desc.BranchType == ByteCode.JavaBranchType.Break)
                        break;
                    else if (Desc.BranchType == ByteCode.JavaBranchType.Conditional)
                    {
                        if ((OpCode == Java.OpCodes.jsr) || (OpCode == Java.OpCodes.jsr_w))
                            Stack.Push(1);

                        int NextPosition = Position + Operand;

                        if (!Branches.ContainsKey(NextPosition))
                            Branches.Add(NextPosition, Stack.Value);

                        if ((OpCode == Java.OpCodes.jsr) || (OpCode == Java.OpCodes.jsr_w))
                            Stack.Pop(0);

                        Position += Size;
                    }
                    else if (Desc.BranchType == ByteCode.JavaBranchType.Switch)
                    {
                        int PaddingLength = (4 - ((Position + 1) % 4)) % 4;
                        int SwitchArrayStart = Position + PaddingLength + 1;
                        int NextPosition = BitConverterBE.ReadAsInt32(Code, SwitchArrayStart, 4);

                        if (OpCode == Java.OpCodes.lookupswitch)
                        {
                            int Count = BitConverterBE.ReadAsInt32(Code, SwitchArrayStart + 4, 4);
                            for (int i = 0; i < Count; i++)
                            {
                                int Offset = BitConverterBE.ReadAsInt32(Code, SwitchArrayStart + 8 + (i * 8) + 4, 4);
                                int NextPos = Position + Offset;
                                if (!Branches.ContainsKey(NextPos))
                                    Branches.Add(Position + Offset, Stack.Value);
                            }
                        }
                        else if (OpCode == Java.OpCodes.tableswitch)
                        {
                            int low = BitConverterBE.ReadAsInt32(Code, SwitchArrayStart + 4, 4);
                            int hight = BitConverterBE.ReadAsInt32(Code, SwitchArrayStart + 8, 4);

                            for (int i = 0; i < hight - low + 1; i++)
                            {
                                int Offset = BitConverterBE.ReadAsInt32(Code, SwitchArrayStart + 12 + (i * 4), 4);
                                int NextPos = Position + Offset;
                                if (!Branches.ContainsKey(NextPos))
                                    Branches.Add(Position + Offset, Stack.Value);
                            }
                        }

                        Position += NextPosition;
                    }
                    else if (Desc.BranchType == ByteCode.JavaBranchType.Goto)
                    {
                        Position += Operand;
                    }
                    else if (Desc.BranchType == ByteCode.JavaBranchType.Next)
                    {
                        Position += Size;
                    }
                }
            }

            resultCode.MaxStack = (ushort)Stack.MaxValue;
        }
    }
}
