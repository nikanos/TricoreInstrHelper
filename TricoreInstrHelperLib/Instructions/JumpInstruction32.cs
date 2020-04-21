namespace TricoreInstrHelperLib.Instructions
{
    class JumpInstruction32 : RelativeControlFlowInstruction32Base
    {
        public JumpInstruction32(int offset) :
            base(offset)
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
