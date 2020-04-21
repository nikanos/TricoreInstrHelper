using Microsoft.VisualStudio.TestTools.UnitTesting;
using TricoreInstrHelperLib.Instructions;

namespace TricoreInstrHelperLib.Tests
{
    [TestClass]
    public class CallInstruction16Tests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOffsetException))]
        public void CallInstruction16_WithZeroOffset_Throws()
        {
            var callInstruction = new CallInstruction16(0);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(1)]
        [DataRow(3)]
        [DataRow(15)]
        [DataRow(161)]
        [ExpectedException(typeof(InvalidOffsetException))]
        public void CallInstruction16_WithOddOffset_Throws(int offset)
        {
            var callInstruction = new CallInstruction16(offset);
        }

        [TestMethod]
        public void CallInstruction16_WithValidPositiveOffset_Succeeds()
        {
            var callInstruction = new CallInstruction16(2);
            byte[] ret = callInstruction.GetInstructionBytes();

            Assert.IsNotNull(ret);
            Assert.AreEqual(2, ret.Length);

            Assert.AreEqual(0x5C, ret[0]);
            Assert.AreEqual(0x01, ret[1]);
        }

        [TestMethod]
        public void CallInstruction16_WithValidNegativeOffset_Succeeds()
        {
            var callInstruction = new CallInstruction16(-2);
            byte[] ret = callInstruction.GetInstructionBytes();

            Assert.IsNotNull(ret);
            Assert.AreEqual(2, ret.Length);

            Assert.AreEqual(0x5C, ret[0]);
            Assert.AreEqual(0xFF, ret[1]);
        }
    }
}

