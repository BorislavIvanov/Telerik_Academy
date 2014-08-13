namespace ComputersUI.ConsoleClient.SystemComponents
{
    using System;
    using ComputersUI.ConsoleClient.Interfaces;

    public class Motherboard : IMotherboard
    {
        /// <summary>
        /// This Class make instance of new motherboard.
        /// </summary>
        /// <param name="cpuElement">CPU element on mootherboard.</param>
        /// <param name="ramElement">RAM element on motherboard.</param>
        /// <param name="hardDriveElement">Hard drive on mothervboard.</param>
        /// <param name="videoCardElement">Video card on motherboard.</param>
        public Motherboard(CPU cpuElement, RAM ramElement, HardDrive hardDriveElement, VideoCard videoCardElement)
        {
            this.CPUElement = cpuElement;
            this.RAMElement = ramElement;
            this.HardDriveElement = hardDriveElement;
            this.VideoCardElement = videoCardElement;
        }

        /// <summary>
        /// Gets CPUElement element.
        /// </summary>
        public CPU CPUElement { get; private set; }

        /// <summary>
        /// Gets RAM element.
        /// </summary>
        public RAM RAMElement { get; private set; }

        /// <summary>
        /// Gets Hard Drive element.
        /// </summary>
        public HardDrive HardDriveElement { get;  private set; }

        /// <summary>
        /// Gets Video Card element.
        /// </summary>
        public VideoCard VideoCardElement { get; private set; }

        /// <summary>
        /// This method load the value from RAM.
        /// </summary>
        /// <returns>Returns the value from RAM.</returns>
        public int LoadRamValue()
        {
            int valueOfRamElement = this.RAMElement.LoadValue();

            return valueOfRamElement;
        }

        /// <summary>
        /// This method save value to the RAM memory.
        /// </summary>
        /// <param name="value">The parameter who must be saved in RAM memory.</param>
        public void SaveRamValue(int value)
        {
            this.RAMElement.SaveValue(value);
        }

        /// <summary>
        /// This method draw data ot console.
        /// </summary>
        /// <param name="data">Data which must be printed on the console.</param>
        public void DrawOnVideoCard(string data)
        {
            this.VideoCardElement.Draw(data);
        }

        /// <summary>
        /// This method generate random namber with the CPU and after that save this thata to RAM memory.
        /// </summary>
        /// <param name="minNumber">Minimum for random generated number.</param>
        /// <param name="maxNumber">Maximum for random generated number.</param>
        public void GenerateRandomNumber(int minNumber, int maxNumber)
        {
            int generatedNumber = this.CPUElement.GenerateRandomNumber(minNumber, maxNumber);
            this.RAMElement.SaveValue(generatedNumber);
        }

        /// <summary>
        /// This method calcolate the square of the number.
        /// </summary>
        /// <returns>Returns the square of number.</returns>
        public string SquareNumber()
        {
            int numberFromRam = this.RAMElement.LoadValue();

            string resultFromOperation = this.CPUElement.SquareNumber(numberFromRam);

            return resultFromOperation;
        }
    }
}
