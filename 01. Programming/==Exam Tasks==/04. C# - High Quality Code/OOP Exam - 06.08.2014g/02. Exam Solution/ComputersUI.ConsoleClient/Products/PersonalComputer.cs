namespace ComputersUI.ConsoleClient
{
    using ComputersUI.ConsoleClient.SystemComponents;

    public class PersonalComputer : Computer
    {
        private Motherboard motherboard = null;

        public PersonalComputer(
            CPU cpuOfComputer,
            RAM ramOfComputer, 
            HardDrive hardDriveOfComputer, 
            VideoCard videoCardOfComputer)
            : base(ComputerType.PC, cpuOfComputer, ramOfComputer, hardDriveOfComputer, videoCardOfComputer, null)
        {
            this.motherboard = 
                new Motherboard(this.CpuOfComputer, this.RamOfComputer, this.HardDriveOfComputer, this.VideoCardOfComputer);
        }

        public string Play(int guessNumber)
        {
            this.motherboard.GenerateRandomNumber(1, 10);
            var number = this.motherboard.LoadRamValue();

            string resultOutput = string.Empty;

            if (number != guessNumber) 
            {
                resultOutput = string.Format("You didn't guess the number {0}.", number);
            }
            else 
            {
                resultOutput = "You win!";
            }

            return resultOutput;
        }
    }
}
