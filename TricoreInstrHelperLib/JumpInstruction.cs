﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricoreInstrHelperLib
{
    public class JumpInstruction : RelativeControlFlowInstructionBase
    {
        public JumpInstruction(int offset) : base(offset)
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