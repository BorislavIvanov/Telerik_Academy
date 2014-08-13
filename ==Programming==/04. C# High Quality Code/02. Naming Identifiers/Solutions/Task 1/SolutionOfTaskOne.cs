class Program
{
    const int maxCount = 6;

    class PrintResult
    {
        void PrintBoolResult(bool value)
        {
            string boolValueToString = value.ToString();
            Console.WriteLine(boolInputValueToString);
        }
    }
	
    public static void InputData()
    {
        Program.PrintResult resultPrinter = new Program.PrintResult();
		
        resultPrinter.PrintBoolResult(true);
    }
}