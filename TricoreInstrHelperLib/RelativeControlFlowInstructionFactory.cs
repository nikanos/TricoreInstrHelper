using System;

namespace TricoreInstrHelperLib
{
    class RelativeControlFlowInstructionFactory
    {
        public static IInstruction CreateInstruction(ControlFlowInstructionType controlFlowInstructionType, int offset)
        {
            switch (controlFlowInstructionType)
            {
                case ControlFlowInstructionType.Call:
                    return new CallInstruction(offset);
                case ControlFlowInstructionType.Jump:
                    return new JumpInstruction(offset);
            }
            throw new ApplicationException($"Unhandled ControlFlowInstructionType {controlFlowInstructionType}");
        }
    }
}
