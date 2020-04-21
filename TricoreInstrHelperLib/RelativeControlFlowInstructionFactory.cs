using System;
using TricoreInstrHelperLib.Instructions;

namespace TricoreInstrHelperLib
{
    class RelativeControlFlowInstructionFactory
    {
        public static IInstruction CreateInstruction(ControlFlowInstruction controlFlowInstruction, int offset)
        {
            switch (controlFlowInstruction)
            {
                case ControlFlowInstruction.Jump16:
                    return new JumpInstruction16(offset);
                case ControlFlowInstruction.Call16:
                    return new CallInstruction16(offset);
                case ControlFlowInstruction.Jump32:
                    return new JumpInstruction32(offset);
                case ControlFlowInstruction.Call32:
                    return new CallInstruction32(offset);
            }
            throw new ApplicationException($"Unhandled ControlFlowInstruction {controlFlowInstruction}");
        }
    }
}
