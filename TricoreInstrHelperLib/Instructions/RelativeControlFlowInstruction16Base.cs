using MiscUtil.Conversion;

namespace TricoreInstrHelperLib.Instructions
{
    abstract class RelativeControlFlowInstruction16Base : RelativeControlFlowInstructionBase
    {
        const int MIN_OFFSET = -256;
        const int MAX_OFFSET = 255;

        public RelativeControlFlowInstruction16Base(int offset) :
            base(offset, MIN_OFFSET, MAX_OFFSET)
        {
        }

        public override byte[] GetInstructionBytes()
        {
            byte[] ret = new byte[2];
            ret[0] = OpCode;
            var converter = new LittleEndianBitConverter();
            byte[] displacementBytes = converter.GetBytes(Displacement);
            ret[1] = displacementBytes[0];
            return ret;
        }
    }
}
