namespace ComputersUI.ConsoleClient.SystemComponents
{
    using System;

    public class CPU
    {
        private const int MathematicalPower = 2;
        private static readonly Random RandomGenerator = new Random();

        public CPU(byte numberOfCores, byte numberOfBits) 
        {
            this.NumberOfCores = numberOfCores;
            this.NumberOfBits = numberOfBits;
        }

        public byte NumberOfCores { get; private set; }

        public byte NumberOfBits { get; private set; }

        public string SquareNumber(int number)
        {
            var result = string.Empty;

            if (this.NumberOfBits == 32)
            {
                result = this.SquareNumber32(number);
            }
            else if (this.NumberOfBits == 64)
            {
                result = this.SquareNumber64(number);
            }
            else if (this.NumberOfBits == 128)
            {
                result = this.SquareNumber128(number);
            }

            return result;
        }

        public int GenerateRandomNumber(int minNumber, int maxNumber)
        {
            int randomNumber = RandomGenerator.Next(minNumber, maxNumber);

            return randomNumber;
        }

        private string SquareNumber32(int number)
        {
            string calculationResult = string.Empty;

            if (number < 0)
            {
                calculationResult = "Number too low.";
            }
            else if (number > 500)
            {
                calculationResult = "Number too high.";
            }
            else
            {
                int result = 1;

                for (int i = 0; i < MathematicalPower; i++)
                {
                    result *= number;
                }

                calculationResult = string.Format("Square of {0} is {1}.", number, result);
            }

            return calculationResult;
        }

        private string SquareNumber64(int number)
        {
            string calculationResult = string.Empty;

            if (number < 0)
            {
                calculationResult = "Number too low.";
            }
            else if (number > 1000)
            {
                calculationResult = "Number too high.";
            }
            else
            {
                int result = 1;

                for (int i = 0; i < MathematicalPower; i++)
                {
                    result *= number;
                }

                calculationResult = string.Format("Square of {0} is {1}.", number, result);
            }

            return calculationResult;
        }

        private string SquareNumber128(int number)
        {
            string calculationResult = string.Empty;

            if (number < 0)
            {
                calculationResult = "Number too low.";
            }
            else if (number > 2000)
            {
                calculationResult = "Number too high.";
            }
            else
            {
                int result = 1;

                for (int i = 0; i < MathematicalPower; i++)
                {
                    result *= number;
                }

                calculationResult = string.Format("Square of {0} is {1}.", number, result);
            }

            return calculationResult;
        }
    }
}
