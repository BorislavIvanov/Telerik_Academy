using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComputersUI.ConsoleClient;

namespace ConsoleClientTests
{
    [TestClass]
    public class CPUSquareNumberTests
    {
        [TestMethod]
        public void CPUSquareNumberTests_SquareNumberOf500()
        {
            var dellManufacturer = new DellManufacturer();
            var factoryManager = new FactoryManager(dellManufacturer);

            var pc = factoryManager.MakePersonalComputer();

            var result = pc.CpuOfComputer.SquareNumber(500);

            Assert.AreEqual("Square of 500 is 250000.", result);
        }

        [TestMethod]
        public void CPUSquareNumberTests_SquareNumberOf16()
        {
            var dellManufacturer = new DellManufacturer();
            var factoryManager = new FactoryManager(dellManufacturer);

            var pc = factoryManager.MakePersonalComputer();

            var result = pc.CpuOfComputer.SquareNumber(16);

            Assert.AreEqual("Square of 16 is 256.", result);
        }
    }
}
