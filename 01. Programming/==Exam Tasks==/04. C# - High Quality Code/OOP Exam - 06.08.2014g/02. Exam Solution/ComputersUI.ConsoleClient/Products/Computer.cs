namespace ComputersUI.ConsoleClient
{
    using ComputersUI.ConsoleClient.SystemComponents;

    public abstract class Computer
    {
        public Computer(
            ComputerType typeOfComputer, 
            CPU cpuOfComputer, 
            RAM ramOfComputer, 
            HardDrive hardDriveOfComputer, 
            VideoCard videoCardOfComputer, 
            Battery laptopBattery)
        {
            this.TypeOfComputer = typeOfComputer;
            this.CpuOfComputer = cpuOfComputer;
            this.RamOfComputer = ramOfComputer;
            this.HardDriveOfComputer = hardDriveOfComputer;
            this.VideoCardOfComputer = videoCardOfComputer;
            this.LaptopBattery = laptopBattery;
        }

        public ComputerType TypeOfComputer { get; private set; }

        public CPU CpuOfComputer { get; private set; }

        public RAM RamOfComputer { get; private set; }

        public HardDrive HardDriveOfComputer { get; private set; }

        public VideoCard VideoCardOfComputer { get; private set; }

        public Battery LaptopBattery { get; private set; }
    }
}
