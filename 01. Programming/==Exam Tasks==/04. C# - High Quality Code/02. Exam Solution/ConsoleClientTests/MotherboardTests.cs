namespace ConsoleClientTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ComputersUI.ConsoleClient;

    [TestClass]
    public class MotherboardTests
    {
        [TestMethod]
        public void LoadRamValue_LoadValueWhenIsEmpty_MustReturnZero()
        {
            var dellManufacturer = new DellManufacturer();
            var factoryManager = new FactoryManager(dellManufacturer);

            var pc = factoryManager.MakePersonalComputer();

            var result = pc.RamOfComputer.LoadValue();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void LoadRamValue_LoadValueWhenIsNotEpmty_MustReturnFive()
        {
            var dellManufacturer = new DellManufacturer();
            var factoryManager = new FactoryManager(dellManufacturer);

            var pc = factoryManager.MakePersonalComputer();

            pc.RamOfComputer.SaveValue(5);

            var result = pc.RamOfComputer.LoadValue();

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void SaveRamValue_SaveValueWhenIsEpmty_MustReturnFive()
        {
            var dellManufacturer = new DellManufacturer();
            var factoryManager = new FactoryManager(dellManufacturer);

            var pc = factoryManager.MakePersonalComputer();

            pc.RamOfComputer.SaveValue(5);

            var result = pc.RamOfComputer.LoadValue();

            Assert.AreEqual(5, result);
        }
    }
}
