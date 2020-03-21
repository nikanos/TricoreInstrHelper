using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricoreInstrHelperLib
{
    public class JumpInstruction16 : RelativeControlFlowInstruction16Base
    {
        public JumpInstruction16(int offset) :
            base(offset)
        {

        }

        public override byte OpCode
        {
            get
            {
                return 0x3C;
            }
        }

    }
}
