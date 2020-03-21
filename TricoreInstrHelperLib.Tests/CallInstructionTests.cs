using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TricoreInstrHelperLib.Tests
{
    [TestClass]
    public class CallInstructionTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOffsetException))]
        public void CallInstruction_WithZeroOffset_Throws()
        {
            var callInstruction = new CallInstruction(0);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(1)]
        [DataRow(3)]
        [DataRow(15)]
        [DataRow(161)]
        [ExpectedException(typeof(InvalidOffsetException))]
        public void CallInstruction_WithOddOffset_Throws(int offset)
        {
            var callInstruction = new CallInstruction(offset);
        }

        [TestMethod]
        public void CallInstruction_WithValidPositiveOffset_Succeeds()
        {
            var callInstruction = new CallInstruction(2);
            byte[] ret = callInstruction.GetInstructionBytes();

            Assert.IsNotNull(ret);
            Assert.AreEqual(4, ret.Length);

            Assert.AreEqual(0x6D, ret[0]);
            Assert.AreEqual(0x00, ret[1]);
            Assert.AreEqual(0x01, ret[2]);
            Assert.AreEqual(0x00, ret[3]);
        }

        [TestMethod]
        public void CallInstruction_WithValidNegativeOffset_test1_Succeeds()
        {
            var callInstruction = new CallInstruction(-2);
            byte[] ret = callInstruction.GetInstructionBytes();

            Assert.IsNotNull(ret);
            Assert.AreEqual(4, ret.Length);

            Assert.AreEqual(0x6D, ret[0]);
            Assert.AreEqual(0xFF, ret[1]);
            Assert.AreEqual(0xFF, ret[2]);
            Assert.AreEqual(0xFF, ret[3]);
        }

        [TestMethod]
        public void CallInstruction_WithValidNegativeOffset_test2_Succeeds()
        {
            var callInstruction = new CallInstruction(-130526);
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

