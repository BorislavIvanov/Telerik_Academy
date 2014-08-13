//03. Write a program to check if in a given expression the brackets are put correctly.
//    Example of correct expression: ((a+b)/5-d).
//    Example of incorrect expression: )(a+b)).

using System;

    class CorrectBracketsUse
    {
        static void Main()
        {
            Console.Write("Type Something: ");
            string userInput = Console.ReadLine();
            Console.WriteLine();

            bool haveBracket = false;
            int bracket = 0;

            char[] charUserInput = userInput.ToCharArray();

            for (int i = 0; i < charUserInput.Length; i++)
            {
                if (charUserInput[i] == '(')
                {
                    haveBracket = true;
                    bracket++;
                }
                else if (charUserInput[i] == ')')
                {
                    haveBracket = true;
                    bracket--;
                }
            }

            Console.WriteLine("Result: ");

            if (haveBracket == true)
            {
                if (bracket == 0)
                {
                    Console.WriteLine("Brackets are correctly used.");
                }
                else if (bracket > 0)
                {
                    Console.WriteLine("Open Brackets \"(\" are more than the Close Brackets \")\".");
                }
                else if (bracket < 0)
                {
                    Console.WriteLine("Close Brackets \")\" are more than the Open Brackets \"(\".");
                }
            }
            else if (haveBracket == false)
            {
                Console.WriteLine("In Your input don't have bracket!");
            }

            Console.WriteLine();
        }
    }

