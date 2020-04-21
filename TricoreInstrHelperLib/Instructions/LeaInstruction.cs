using MiscUtil.Conversion;
using System;

namespace TricoreInstrHelperLib.Instructions
{
    class LeaInstruction : IInstruction
    {
        private UInt16 _addressPart;
        private AddressRegister _addressRegister;

        public LeaInstruction(UInt16 addressPart, AddressRegister addressRegister)
        {
            _addressPart = addressPart;
            _addressRegister = addressRegister;
        }

        public byte OpCode
        {
            get
            {
                return 0xD9;
            }
        }

        public byte[] GetInstructionBytes()
        {
            byte addrpart3 = (byte)(_addressPart & 0x3F);
            byte addrpart2 = (byte)((_addressPart >> 6) & 0xF);
            byte addrpart1 = (byte)((_addressPart >> 10) & 0x3F);

            UInt32 result = ((uint)addrpart2 << 28) |
                            ((uint)addrpart1 << 22) |
                            ((uint)addrpart3 << 16) |
                            ((uint)_addressRegister << 12) |
                            ((uint)_addressRegister << 8) |
                            OpCode;

            var converter = new LittleEndianBitConverter();
            byte[] resultBytes = converter.GetBytes(result);

            return resultBytes;
        }
    }
}
