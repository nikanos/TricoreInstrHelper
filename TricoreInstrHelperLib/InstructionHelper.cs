using System;
using System.Text;

namespace TricoreInstrHelperLib
{
    public class InstructionHelper
    {
        public static string GetInstructionString(ControlFlowInstructionType controlFlowInstructionType, UInt32 addressStart, UInt32 addressEnd)
        {
            int offset = (int)(addressEnd - addressStart);
            IInstruction instruction = RelativeControlFlowInstructionFactory.CreateInstruction(controlFlowInstructionType, offset);
            byte[] instructionBytes = instruction.GetInstructionBytes();

            return FormatInstructionBytes(instructionBytes);
        }

        private static string FormatInstructionBytes(byte[] instructionBytes)
        {
            StringBuilder sb = new StringBuilder();
            foreach(byte b in instructionBytes)
                sb.AppendFormat("{0:X02}", b);
            return sb.ToString();
        }
    }
}
