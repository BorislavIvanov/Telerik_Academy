namespace ComputersUI.ConsoleClient.SystemComponents
{
    using System;

    public class VideoCard
    {
        public VideoCard(bool isMonochrome)
        {
            this.IsMonochrome = isMonochrome;
        }

        public bool IsMonochrome { get; private set; }

        public void Draw(string outputMessage)
        {
            if (this.IsMonochrome)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(outputMessage);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(outputMessage);
                Console.ResetColor();
            }
        }
    }
}
