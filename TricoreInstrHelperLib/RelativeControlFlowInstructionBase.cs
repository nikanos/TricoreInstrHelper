using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiscUtil.Conversion;

namespace TricoreInstrHelperLib
{
    public abstract class RelativeControlFlowInstructionBase : IInstruction
    {
        const int MAX_OFFSET = (16 * 1024 * 1024) - 1;
        const int MIN_OFFSET = -(16 * 1024 * 1024);
        private int _offset;

        public RelativeControlFlowInstructionBase(int offset)
        {
            this.Offset = offset;
        }

        public int Offset
        {
            get
            {
                return _offset;
            }
            set
            {
                if (value == 0)
                    throw new InvalidOffsetException("Offset should not be zero");

                if ((value % 2) != 0)
                    throw new InvalidOffsetException("Offset should be even");

                if (value > MAX_OFFSET)
                    throw new InvalidOffsetException($"Offset should not be greater than {MAX_OFFSET}");

                if (value < MIN_OFFSET)
                    throw new InvalidOffsetException($"Offset should not be less than {MIN_OFFSET}");

                _offset = value;
            }
        }

        public int Displacement
        {
            get { return Offset / 2; }
        }

        public abstract byte OpCode
        {
            get;
        }

        public byte[] GetInstructionBytes()
        {
            byte[] ret = new byte[4];
            ret[0] = OpCode;
            int absDisplacement = Displacement;
            var converter = new BigEndianBitConverter();
            byte[] absDisplacementBytes = converter.GetBytes(absDisplacement);

            ret[1] = absDisplacementBytes[1];
            ret[2] = absDisplacementBytes[3];
            ret[3] = absDisplacementBytes[2];

            return ret;
        }
    }
}
