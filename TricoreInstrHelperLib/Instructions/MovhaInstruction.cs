using MiscUtil.Conversion;
using System;

namespace TricoreInstrHelperLib.Instructions
{
    class MovhaInstruction : IInstruction
    {
        private UInt16 _addressPart;
        private AddressRegister _addressRegister;

        public MovhaInstruction(UInt16 addressPart, AddressRegister addressRegister)
        {
            _addressPart = addressPart;
            _addressRegister = addressRegister;
        }

        public byte OpCode { get { return Constants.Opcodes.MOVHA; } }

        public byte[] GetInstructionBytes()
        {
            UInt32 result = ((uint)_addressRegister << 28) | ((uint)_addressPart << 12) | OpCode;

            var converter = new LittleEndianBitConverter();
            byte[] resultBytes = converter.GetBytes(result);

            return resultBytes;
        }
    }
}
