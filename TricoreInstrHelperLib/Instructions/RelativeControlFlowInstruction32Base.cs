using MiscUtil.Conversion;

namespace TricoreInstrHelperLib.Instructions
{
    abstract class RelativeControlFlowInstruction32Base : RelativeControlFlowInstructionBase
    {
        const int MIN_OFFSET = -(16 * 1024 * 1024);
        const int MAX_OFFSET = (16 * 1024 * 1024) - 1;

        public RelativeControlFlowInstruction32Base(int offset) :
            base(offset, MIN_OFFSET, MAX_OFFSET)
        {
        }

        public override byte[] GetInstructionBytes()
        {
            byte[] ret = new byte[4];
            ret[0] = OpCode;
            var converter = new LittleEndianBitConverter();
            byte[] displacementBytes = converter.GetBytes(Displacement);

            ret[1] = displacementBytes[2];
            ret[2] = displacementBytes[0];
            ret[3] = displacementBytes[1];

            return ret;
        }
    }
}
