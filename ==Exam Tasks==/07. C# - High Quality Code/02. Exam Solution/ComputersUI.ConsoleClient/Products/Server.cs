namespace ComputersUI.ConsoleClient
{
    using ComputersUI.ConsoleClient.SystemComponents;

    public class Server : Computer
    {
        private Motherboard motherboard = null;

        public Server(
            CPU cpuOfComputer, 
            RAM ramOfComputer, 
            HardDrive hardDriveOfComputer,
            VideoCard videoCardOfComputer)
            : base(ComputerType.PC, cpuOfComputer, ramOfComputer, hardDriveOfComputer, videoCardOfComputer, null)
        {
            this.motherboard = 
                new Motherboard(this.CpuOfComputer, this.RamOfComputer, this.HardDriveOfComputer, this.VideoCardOfComputer);
        }

        public string Process(int data)
        {
            this.motherboard.SaveRamValue(data);

            string processResult = this.motherboard.SquareNumber();

            return processResult;
        }
    }
}
