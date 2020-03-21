using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TricoreInstrHelperLib.Tests
{
    [TestClass]
    public class CallInstruction32Tests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOffsetException))]
        public void CallInstruction32_WithZeroOffset_Throws()
        {
            var callInstruction = new CallInstruction32(0);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(1)]
        [DataRow(3)]
        [DataRow(15)]
        [DataRow(161)]
        [ExpectedException(typeof(InvalidOffsetException))]
        public void CallInstruction32_WithOddOffset_Throws(int offset)
        {
            var callInstruction = new CallInstruction32(offset);
        }

        [TestMethod]
        public void CallInstruction32_WithValidPositiveOffset_Succeeds()
        {
            var callInstruction = new CallInstruction32(2);
            byte[] ret = callInstruction.GetInstructionBytes();

            Assert.IsNotNull(ret);
            Assert.AreEqual(4, ret.Length);

            Assert.AreEqual(0x6D, ret[0]);
            Assert.AreEqual(0x00, ret[1]);
            Assert.AreEqual(0x01, ret[2]);
            Assert.AreEqual(0x00, ret[3]);
        }

        [TestMethod]
        public void CallInstruction32_WithValidNegativeOffset_test1_Succeeds()
        {
            var callInstruction = new CallInstruction32(-2);
            byte[] ret = callInstruction.GetInstructionBytes();

            Assert.IsNotNull(ret);
            Assert.AreEqual(4, ret.Length);

            Assert.AreEqual(0x6D, ret[0]);
            Assert.AreEqual(0xFF, ret[1]);
            Assert.AreEqual(0xFF, ret[2]);
            Assert.AreEqual(0xFF, ret[3]);
        }

        [TestMethod]
        public void CallInstruction32_WithValidNegativeOffset_test2_Succeeds()
        {
            var callInstruction = new CallInstruction32(-130526);
            byte[] ret = callInstruction.GetInstructionBytes();

            Assert.IsNotNull(ret);
            Assert.AreEqual(4, ret.Length);

            Assert.AreEqual(0x6D, ret[0]);
            Assert.AreEqual(0xFF, ret[1]);
            Assert.AreEqual(0x11, ret[2]);
            Assert.AreEqual(0x01, ret[3]);
        }
    }
}

