namespace TricoreInstrHelperLib
{
    public class CallInstruction : RelativeControlFlowInstructionBase
    {
        public CallInstruction(int offset) : base(offset)
        {

        }

        public override byte OpCode
        {
            get
            {
                return 0x6D;
            }
        }

    }
}
