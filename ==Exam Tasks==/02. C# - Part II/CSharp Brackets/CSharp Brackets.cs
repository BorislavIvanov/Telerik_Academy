using System;
using System.Collections.Generic;
using System.Text;

class CSharpBrackets
{
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        string tabString = Console.ReadLine();

        StringBuilder formatedCode = new StringBuilder();
        bool firstSymbol = true;
        bool prevIsClosingBrack = false;
        int tabCounter = 0;

        for (int i = 0; i < numberOfLines; i++)
        {
            string inputLine = Console.ReadLine().Trim();
            int position = 0;

            while (position < inputLine.Length)
            {
                if (inputLine[position] != '{' && inputLine[position] != '}' && inputLine[position] != ' ')
                {
                    if (firstSymbol)
                    {
                        for (int t = 0; t < tabCounter; t++)
                        {
                            formatedCode.Append(tabString);
                        }

                        formatedCode.Append(inputLine[position]);
                        firstSymbol = false;
                        position++;
                        prevIsClosingBrack = false;
                    }
                    else
                    {
                        formatedCode.Append(inputLine[position]);
                        firstSymbol = false;
                        position++;
                        prevIsClosingBrack = false;
                    }
                }
                else
                {
                    if (inputLine[position] == ' ')
                    {
                        if (firstSymbol)
                        {
                            for (int t = 0; t < tabCounter; t++)
                            {
                                formatedCode.Append(tabString);
                            }
                            firstSymbol = false;
                            position++;
                            prevIsClosingBrack = false;
                        }
                        else if (inputLine[position] == inputLine[position + 1])
                        {
                            position++;
                            prevIsClosingBrack = false;
                        }
                        else
                        {
                            formatedCode.Append(inputLine[position]);
                            firstSymbol = false;
                            position++;
                            prevIsClosingBrack = false;
                        }
                    }
                    //   {   //
                    else if (inputLine[position] == '{')
                    {
                        if (inputLine.Length == 1)
                        {
                            for (int t = 0; t < tabCounter; t++)
                            {
                                formatedCode.Append(tabString);
                            }

                            formatedCode.Append(inputLine[position]);
                            firstSymbol = false;

                            position++;
                            tabCounter++;
                            prevIsClosingBrack = false;

                        }
                        else if (firstSymbol)
                        {
                            for (int t = 0; t < tabCounter; t++)
                            {
                                formatedCode.Append(tabString);
                            }

                            formatedCode.Append(inputLine[position]);
                            firstSymbol = false;

                            formatedCode.AppendLine();
                            firstSymbol = true;
                            position++;
                            tabCounter++;
                            prevIsClosingBrack = false;
                        }
                        else if (position == inputLine.Length - 1)
                        {
                            formatedCode.AppendLine();
                            firstSymbol = true;

                            for (int t = 0; t < tabCounter; t++)
                            {
                                formatedCode.Append(tabString);
                            }

                            formatedCode.Append(inputLine[position]);
                            firstSymbol = false;
                            position++;
                            tabCounter++;
                            prevIsClosingBrack = false;
                        }
                        else
                        {
                            formatedCode.AppendLine();
                            firstSymbol = true;

                            for (int t = 0; t < tabCounter; t++)
                            {
                                formatedCode.Append(tabString);
                            }

                            formatedCode.Append(inputLine[position]);
                            firstSymbol = false;

                            formatedCode.AppendLine();
                            firstSymbol = true;
                            position++;
                            tabCounter++;
                            prevIsClosingBrack = false;
                        }
                    }
                    //   }   //
                    else if (inputLine[position] == '}')
                    {
                        if (firstSymbol)
                        {
                            tabCounter--;
                            for (int t = 0; t < tabCounter; t++)
                            {
                                formatedCode.Append(tabString);
                            }

                            formatedCode.Append(inputLine[position]);
                            firstSymbol = false;

                            formatedCode.AppendLine();
                            firstSymbol = true;
                            position++;
                            prevIsClosingBrack = true;
                        }
                        else if (position == inputLine.Length - 1)
                        {
                            tabCounter--;
                            formatedCode.AppendLine();
                            firstSymbol = true;

                            for (int t = 0; t < tabCounter; t++)
                            {
                                formatedCode.Append(tabString);
                            }

                            formatedCode.Append(inputLine[position]);
                            firstSymbol = false;
                            position++;
                        }
                        else
                        {
                            tabCounter--;
                            formatedCode.AppendLine();
                            firstSymbol = true;

                            for (int t = 0; t < tabCounter; t++)
                            {
                                formatedCode.Append(tabString);
                            }

                            formatedCode.Append(inputLine[position]);
                            firstSymbol = false;

                            formatedCode.AppendLine();
                            firstSymbol = true;
                            position++;
                            prevIsClosingBrack = true;
                        }
                    }
                }

                if (position == inputLine.Length && !prevIsClosingBrack)
                {
                    formatedCode.AppendLine();
                    firstSymbol = true;
                }
            }
        }

        Console.WriteLine(formatedCode);
    }
}