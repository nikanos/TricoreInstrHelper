using System;
using System.Text;
using TricoreInstrHelperLib.Instructions;

namespace TricoreInstrHelperLib
{
    public class InstructionHelper
    {
        public static string GetRelativeControlFlowInstructionString(ControlFlowInstruction controlFlowInstruction, UInt32 addressStart, UInt32 addressEnd)
        {
            int offset = (int)(addressEnd - addressStart);
            IInstruction instruction = RelativeControlFlowInstructionFactory.CreateInstruction(controlFlowInstruction, offset);
            byte[] instructionBytes = instruction.GetInstructionBytes();

            return FormatInstructionBytes(instructionBytes);
        }

        public static string GetAssignAddressInstructionString(AddressRegister addressRegister, UInt32 address)
        {
            UInt16 movhAddressPart = address.MovhAddressPart();
            UInt16 leaAddressPart = address.LeaAddressPart();

            var movhaInstruction = new MovhaInstruction(movhAddressPart, addressRegister);
            var leaInstruction = new LeaInstruction(leaAddressPart, addressRegister);

            byte[] movhaInstructionBytes = movhaInstruction.GetInstructionBytes();
            byte[] leaInstructionBytes = leaInstruction.GetInstructionBytes();

            return FormatInstructionBytes(movhaInstructionBytes) + " " + FormatInstructionBytes(leaInstructionBytes);
        }

        private static string FormatInstructionBytes(byte[] instructionBytes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in instructionBytes)
                sb.AppendFormat("{0:X02}", b);
            return sb.ToString();
        }
    }
}
