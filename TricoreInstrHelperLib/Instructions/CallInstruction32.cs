﻿namespace TricoreInstrHelperLib.Instructions
{
    class CallInstruction32 : RelativeControlFlowInstruction32Base
    {
        public CallInstruction32(int offset) :
            base(offset)
        {

        }

        public override byte OpCode { get { return Constants.Opcodes.CALL32; } }

    }
}
