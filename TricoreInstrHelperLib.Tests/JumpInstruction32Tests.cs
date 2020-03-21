using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TricoreInstrHelperLib.Tests
{
    [TestClass]
    public class JumpInstruction32Tests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOffsetException))]
        public void JumpInstruction32_WithZeroOffset_Throws()
        {
            var jumpInstruction = new JumpInstruction32(0);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(1)]
        [DataRow(3)]
        [DataRow(15)]
        [DataRow(161)]
        [ExpectedException(typeof(InvalidOffsetException))]
        public void JumpInstruction32_WithOddOffset_Throws(int offset)
        {
            var jumpInstruction = new JumpInstruction32(offset);
        }

        [TestMethod]
        public void JumpInstruction32_WithValidPositiveOffset_Succeeds()
        {
            var jumpInstruction = new JumpInstruction32(2);
            byte[] ret = jumpInstruction.GetInstructionBytes();

            Assert.IsNotNull(ret);
            Assert.AreEqual(4, ret.Length);

            Assert.AreEqual(0x1D, ret[0]);
            Assert.AreEqual(0x00, ret[1]);
            Assert.AreEqual(0x01, ret[2]);
            Assert.AreEqual(0x00, ret[3]);
        }

        [TestMethod]
        public void JumpInstruction32_WithValidNegativeOffset_Succeeds()
        {
            var jumpInstruction = new JumpInstruction32(-2);
            byte[] ret = jumpInstruction.GetInstructionBytes();

            Assert.IsNotNull(ret);
            Assert.AreEqual(4, ret.Length);

            Assert.AreEqual(0x1D, ret[0]);
            Assert.AreEqual(0xFF, ret[1]);
            Assert.AreEqual(0xFF, ret[2]);
            Assert.AreEqual(0xFF, ret[3]);
        }
    }
}

