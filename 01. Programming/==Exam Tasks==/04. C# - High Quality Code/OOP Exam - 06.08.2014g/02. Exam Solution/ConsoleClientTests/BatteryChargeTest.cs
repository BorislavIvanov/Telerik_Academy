namespace ConsoleClientTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ComputersUI.ConsoleClient;

    [TestClass]
    public class BatteryChargeTest
    {
        [TestMethod]
        public void BatteryChargeTest_ChargeWithTenPercents_MustReturn60()
        {
            var dellManufacturer = new DellManufacturer();
            var factoryManager = new FactoryManager(dellManufacturer);

            var laptop = factoryManager.MakeLaptop();

            laptop.LaptopBattery.Charge(10);

            var result = laptop.LaptopBattery.Percentage;

            Assert.AreEqual(60, result);
        }

        [TestMethod]
        public void BatteryChargeTest_OverchargeWith200Percents_MustReturn100()
        {
            var dellManufacturer = new DellManufacturer();
            var factoryManager = new FactoryManager(dellManufacturer);

            var laptop = factoryManager.MakeLaptop();

            laptop.LaptopBattery.Charge(200);

            var result = laptop.LaptopBattery.Percentage;

            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void BatteryChargeTest_FullEmptyTheBatteryWith200_MustReturnZero()
        {
            var dellManufacturer = new DellManufacturer();
            var factoryManager = new FactoryManager(dellManufacturer);

            var laptop = factoryManager.MakeLaptop();

            laptop.LaptopBattery.Charge(-200);

            var result = laptop.LaptopBattery.Percentage;

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void BatteryChargeTest_FullChargingTheBatteryFromZero_MustReturn100()
        {
            var dellManufacturer = new DellManufacturer();
            var factoryManager = new FactoryManager(dellManufacturer);

            var laptop = factoryManager.MakeLaptop();

            laptop.LaptopBattery.Charge(-200);
            laptop.LaptopBattery.Charge(100);

            var result = laptop.LaptopBattery.Percentage;

            Assert.AreEqual(100, result);
        }
    }
}
