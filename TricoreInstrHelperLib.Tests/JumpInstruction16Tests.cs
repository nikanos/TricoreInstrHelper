using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TricoreInstrHelperLib.Tests
{
    [TestClass]
    public class JumpInstruction16Tests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOffsetException))]
        public void JumpInstruction16_WithZeroOffset_Throws()
        {
            var jumpInstruction = new JumpInstruction16(0);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(1)]
        [DataRow(3)]
        [DataRow(15)]
        [DataRow(161)]
        [ExpectedException(typeof(InvalidOffsetException))]
        public void JumpInstruction16_WithOddOffset_Throws(int offset)
        {
            var jumpInstruction = new JumpInstruction16(offset);
        }

        [TestMethod]
        public void JumpInstruction16_WithValidPositiveOffset_Succeeds()
        {
            var jumpInstruction = new JumpInstruction16(2);
            byte[] ret = jumpInstruction.GetInstructionBytes();

            Assert.IsNotNull(ret);
            Assert.AreEqual(2, ret.Length);

            Assert.AreEqual(0x3C, ret[0]);
            Assert.AreEqual(0x01, ret[1]);
        }

        [TestMethod]
        public void JumpInstruction16_WithValidNegativeOffset_Succeeds()
        {
            var jumpInstruction = new JumpInstruction16(-2);
            byte[] ret = jumpInstruction.GetInstructionBytes();

            Assert.IsNotNull(ret);
            Assert.AreEqual(2, ret.Length);

            Assert.AreEqual(0x3C, ret[0]);
            Assert.AreEqual(0xFF, ret[1]);
        }
    }
}

