using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricoreInstrHelperLib
{
    public static class Constants
    {
        public static class Opcodes
        {
            public const byte CALL16 = 0x5C;
            public const byte CALL32 = 0x6D;
            public const byte JUMP16 = 0x3C;
            public const byte JUMP32 = 0x1D;
            public const byte LEA = 0xD9;
            public const byte MOVHA = 0x91;
        }
    }
}
