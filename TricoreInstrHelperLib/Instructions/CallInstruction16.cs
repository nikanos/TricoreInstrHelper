namespace TricoreInstrHelperLib.Instructions
{
    class CallInstruction16 : RelativeControlFlowInstruction16Base
    {
        public CallInstruction16(int offset) :
            base(offset)
        {

        }

        public override byte OpCode { get { return Constants.Opcodes.CALL16; } }
    }
}
