using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiscUtil.Conversion;

namespace TricoreInstrHelperLib
{
    public abstract class RelativeControlFlowInstruction32Base : RelativeControlFlowInstructionBase
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
            var converter = new BigEndianBitConverter();
            byte[] absDisplacementBytes = converter.GetBytes(Displacement);

            ret[1] = absDisplacementBytes[1];
            ret[2] = absDisplacementBytes[3];
            ret[3] = absDisplacementBytes[2];

            return ret;
        }
    }
}
