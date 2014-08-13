namespace ComputersUI.ConsoleClient
{
    using System;
    using ComputersUI.ConsoleClient.SystemComponents;
    
    public class Laptop : Computer
    {
        private Motherboard motherboard = null;

        public Laptop(
            CPU cpuOfComputer, 
            RAM ramOfComputer, 
            HardDrive hardDriveOfComputer, 
            VideoCard videoCardOfComputer, 
            Battery laptopBattery)
            : base(ComputerType.PC, cpuOfComputer, ramOfComputer, hardDriveOfComputer, videoCardOfComputer, laptopBattery)
        {
            this.motherboard = 
                new Motherboard(this.CpuOfComputer, this.RamOfComputer, this.HardDriveOfComputer, this.VideoCardOfComputer);
        }

        public string ChargeBattery(int percentage)
        {
            LaptopBattery.Charge(percentage);

            string resultOutput = string.Empty;

            resultOutput = string.Format("Battery status: {0}", LaptopBattery.Percentage);

            return resultOutput;
        }
    }
}
