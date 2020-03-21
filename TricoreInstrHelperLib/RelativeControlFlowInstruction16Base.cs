using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiscUtil.Conversion;

namespace TricoreInstrHelperLib
{
    public abstract class RelativeControlFlowInstruction16Base : RelativeControlFlowInstructionBase
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
            var converter = new BigEndianBitConverter();
            byte[] displacementBytes = converter.GetBytes(Displacement);
            ret[1] = displacementBytes[3];
            return ret;
        }
    }
}
