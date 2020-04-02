using System;

namespace TricoreInstrHelperLib
{
    class RelativeControlFlowInstructionFactory
    {
        public static IInstruction CreateInstruction(ControlFlowInstructionType controlFlowInstructionType, int offset)
        {
            switch (controlFlowInstructionType)
            {
                case ControlFlowInstructionType.Jump16:
                    return new JumpInstruction16(offset);
                case ControlFlowInstructionType.Call16:
                    return new CallInstruction16(offset);
                case ControlFlowInstructionType.Jump32:
                    return new JumpInstruction32(offset);
                case ControlFlowInstructionType.Call32:
                    return new CallInstruction32(offset);
            }
            throw new ApplicationException($"Unhandled ControlFlowInstructionType {controlFlowInstructionType}");
        }
    }
}
