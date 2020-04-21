namespace TricoreInstrHelperLib.Instructions
{
    class JumpInstruction16 : RelativeControlFlowInstruction16Base
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
