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
        private readonly int MIN_OFFSET;
        private readonly int MAX_OFFSET;
        private int _offset;

        public RelativeControlFlowInstructionBase(int offset, int minOffset, int maxOffset)
        {
            this.MIN_OFFSET = minOffset;
            this.MAX_OFFSET = maxOffset;
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

        public abstract byte[] GetInstructionBytes();
    }
}
