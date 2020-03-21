using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricoreInstrHelperLib
{
    public class JumpInstruction32 : RelativeControlFlowInstruction32Base
    {
        public JumpInstruction32(int offset) : base(offset)
        {

        }

        public override byte OpCode
        {
            get
            {
                return 0x1D;
            }
        }

    }
}
