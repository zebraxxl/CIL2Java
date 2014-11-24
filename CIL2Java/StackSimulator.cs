using CIL2Java.Java;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIL2Java
{
    public static class StackSimulator
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

        private static Dictionary<OpCodes, int> OpCodeToVarIndex = new Dictionary<OpCodes, int>
        {
            {OpCodes.astore, -1},
            {OpCodes.astore_0, 0},
            {OpCodes.astore_1, 1},
            {OpCodes.astore_2, 2},
            {OpCodes.astore_3, 3},

            {OpCodes.istore, -1},
            {OpCodes.istore_0, 0},
            {OpCodes.istore_1, 1},
            {OpCodes.istore_2, 2},
            {OpCodes.istore_3, 3},

            {OpCodes.lstore, -1},
            {OpCodes.lstore_0, 0},
            {OpCodes.lstore_1, 1},
            {OpCodes.lstore_2, 2},
            {OpCodes.lstore_3, 3},

            {OpCodes.fstore, -1},
            {OpCodes.fstore_0, 0},
            {OpCodes.fstore_1, 1},
            {OpCodes.fstore_2, 2},
            {OpCodes.fstore_3, 3},

            {OpCodes.dstore, -1},
            {OpCodes.dstore_0, 0},
            {OpCodes.dstore_1, 1},
            {OpCodes.dstore_2, 2},
            {OpCodes.dstore_3, 3},


            {OpCodes.aload, -1},
            {OpCodes.aload_0, 0},
            {OpCodes.aload_1, 1},
            {OpCodes.aload_2, 2},
            {OpCodes.aload_3, 3},

            {OpCodes.iload, -1},
            {OpCodes.iload_0, 0},
            {OpCodes.iload_1, 1},
            {OpCodes.iload_2, 2},
            {OpCodes.iload_3, 3},

            {OpCodes.lload, -1},
            {OpCodes.lload_0, 0},
            {OpCodes.lload_1, 1},
            {OpCodes.lload_2, 2},
            {OpCodes.lload_3, 3},

            {OpCodes.fload, -1},
            {OpCodes.fload_0, 0},
            {OpCodes.fload_1, 1},
            {OpCodes.fload_2, 2},
            {OpCodes.fload_3, 3},

            {OpCodes.dload, -1},
            {OpCodes.dload_0, 0},
            {OpCodes.dload_1, 1},
            {OpCodes.dload_2, 2},
            {OpCodes.dload_3, 3},
        };

        private static OpCodes[] DoubleSizeVars = new OpCodes[]
        {
            OpCodes.lstore, OpCodes.lstore_0, OpCodes.lstore_1, OpCodes.lstore_2, OpCodes.lstore_3,
            OpCodes.dstore, OpCodes.dstore_0, OpCodes.dstore_1, OpCodes.dstore_2, OpCodes.dstore_3,
            OpCodes.lload, OpCodes.lload_0, OpCodes.lload_1, OpCodes.lload_2, OpCodes.lload_3,
            OpCodes.dload, OpCodes.dload_0, OpCodes.dload_1, OpCodes.dload_2, OpCodes.dload_3,
        };

        public static void SimulateStack(Java.ConstantPool Pool, Java.Attributes.Code resultCode)
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
            int LocalVarCount = 0;

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

                    if (OpCodeToVarIndex.ContainsKey(OpCode))
                    {
                        int varIndex = OpCodeToVarIndex[OpCode];

                        if (varIndex < 0)
                            varIndex = Operand;

                        if (Array.IndexOf(DoubleSizeVars, OpCode) >= 0)
                            varIndex++;

                        LocalVarCount = Math.Max(LocalVarCount, varIndex + 1);
                    }

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
            resultCode.MaxLocals = (ushort)LocalVarCount;
        }
    }
}
