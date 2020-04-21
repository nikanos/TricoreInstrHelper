using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TricoreInstrHelperLib.Instructions;

namespace TricoreInstrHelperLib.Tests
{
    [TestClass]
    public class AssignAddressInstructionTests
    {
        [TestMethod]
        public void MovhaInstruction_WithValidAddressToA15_Succeeds()
        {
            UInt16 address = 0x8006;
            AddressRegister addressRegister = AddressRegister.A15;
            var movhaInstruction = new MovhaInstruction(address, addressRegister);
            byte[] ret = movhaInstruction.GetInstructionBytes();

            Assert.AreEqual(4, ret.Length);

            Assert.AreEqual(0x91, ret[0]);
            Assert.AreEqual(0x60, ret[1]);
            Assert.AreEqual(0x00, ret[2]);
            Assert.AreEqual(0xF8, ret[3]);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow((UInt16)0x8006, AddressRegister.A15, 0x916000F8)]
        [DataRow((UInt16)0xC000, AddressRegister.A13, 0x910000DC)]
        [DataRow((UInt16)0xD000, AddressRegister.A15, 0x910000FD)]
        public void MovhaInstruction_WithValidAddressesAndAddressRegisters_Succeeds(UInt16 address, AddressRegister addressRegister, UInt32 expectedResult)
        {
            var movhaInstruction = new MovhaInstruction(address, addressRegister);
            byte[] ret = movhaInstruction.GetInstructionBytes();
            byte[] expectedBytes = BitConverter.GetBytes(expectedResult);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(expectedBytes);

            Assert.AreEqual(4, ret.Length);

            Assert.AreEqual(expectedBytes[0], ret[0]);
            Assert.AreEqual(expectedBytes[1], ret[1]);
            Assert.AreEqual(expectedBytes[2], ret[2]);
            Assert.AreEqual(expectedBytes[3], ret[3]);
        }

        [TestMethod]
        public void LeaInstruction_WithValidAddressToA15_Succeeds()
        {
            UInt16 address = 0x125C;
            AddressRegister addressRegister = AddressRegister.A15;
            var movhaInstruction = new LeaInstruction(address, addressRegister);
            byte[] ret = movhaInstruction.GetInstructionBytes();

            Assert.AreEqual(4, ret.Length);

            Assert.AreEqual(0xD9, ret[0]);
            Assert.AreEqual(0xFF, ret[1]);
            Assert.AreEqual(0x1C, ret[2]);
            Assert.AreEqual(0x91, ret[3]);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow((UInt16)0x125C, AddressRegister.A15, 0xD9FF1C91)]
        [DataRow((UInt16)0x049C, AddressRegister.A13, 0xD9DD5C20)]
        [DataRow((UInt16)0xB364, AddressRegister.A15, 0xD9FF24DB)]
        public void LeaInstruction_WithValidAddressesAndAddressRegisters_Succeeds(UInt16 address, AddressRegister addressRegister, UInt32 expectedResult)
        {
            var leaInstruction = new LeaInstruction(address, addressRegister);
            byte[] ret = leaInstruction.GetInstructionBytes();
            byte[] expectedBytes = BitConverter.GetBytes(expectedResult);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(expectedBytes);

            Assert.AreEqual(4, ret.Length);

            Assert.AreEqual(expectedBytes[0], ret[0]);
            Assert.AreEqual(expectedBytes[1], ret[1]);
            Assert.AreEqual(expectedBytes[2], ret[2]);
            Assert.AreEqual(expectedBytes[3], ret[3]);
        }
    }
}
