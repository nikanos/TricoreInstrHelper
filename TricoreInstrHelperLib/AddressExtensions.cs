using System;

namespace TricoreInstrHelperLib
{
    
    public static class AddressExtensions
    {
        // Loading a 32-bit constant into an address register is accomplished using MOVH.A
        // followed by an LEA that uses the base plus 16-bit offset addressing mode. For example:
        // movh.a a5, ((ADDRESS + 8000H)>>16) & FFFFH
        // lea a5, [a5] (ADDRESS & FFFFH)

        public static UInt16 MovhAddressPart(this UInt32 dWord)
        {
            return (UInt16)(((dWord + 0x8000) >> 16) & 0xFFFF);
        }

        public static UInt16 LeaAddressPart(this UInt32 dWord)
        {
            return (UInt16)(dWord & 0xFFFF);
        }
    }
}
