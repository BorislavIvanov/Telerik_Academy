//Write a program that can solve these tasks:
//*Reverses the digits of a number
//*Calculates the average of a sequence of integers
//*Solves a linear equation a * x + b = 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DifferentTasksSolving
{
    static void Main()
    {
        Console.WriteLine("1. Reversing digits of a number.");
        Console.WriteLine();
        Console.WriteLine("2. Calculating the average of a sequence of integers.");
        Console.WriteLine();
        Console.WriteLine("3. Solving a linear equation.");
        Console.WriteLine();
        Console.Write("Your choice? 1,2 or 3: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine();
        switch (input)
        {
            case 1:
                ReverseDig();
                break;
            case 2:
                CalcAvg();
                break;
            case 3:
                SolveLequation();
                break;
            default:
                Console.WriteLine("Wrong choice! Try again! Choose from 1, 2 or 3 ");
                break;
        }
    }

    private static void SolveLequation()
    {
        decimal a = 0m;
        do
        {
            Console.WriteLine("Enter a and b of the equation a*x+b=0 (a!=0).");
            Console.Write("Enter A: ");
            a = decimal.Parse(Console.ReadLine());
        } while (a == 0m);
        Console.Write("Enter B: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine();
        decimal x = (-b) / a;
        Console.WriteLine("x = " + x);
        Console.WriteLine();
    }

    private static void CalcAvg()
    {
        //aL - specify array's length
        int aL = 0;
        do
        {
            Console.WriteLine("Specify the length of the sequence:");
            aL = int.Parse(Console.ReadLine());
        } while (aL < 1);

        int sum = 0;
        int[] arr = new int[aL];

        Console.WriteLine("Enter the {0} integers separated by Enters:", aL);

        for (int i = 0; i < aL; i++)
        {
            bool check = false;

            do
            {
                Console.Write("{0}. - ", i + 1);
                string temp = Console.ReadLine();
                bool trp = int.TryParse(temp, out arr[i]);
                if (trp == true)
                {
                    check = true;
                }
            } while (check == false);
            sum += arr[i];
            Console.WriteLine();
        }
        Console.WriteLine("Average = " + sum / aL);
    }

    private static void ReverseDig()
    {

        ulong n = 0;
        do
        {
            Console.WriteLine("Enter a positive number in range from 0 to 18,446,744,073,709,551,615: ");
            n = ulong.Parse(Console.ReadLine());
        } while (n < 1);
        string number = n.ToString();
        StringBuilder sb = new StringBuilder();

        for (int i = number.Length - 1; i >= 0; i--)
        {
            sb.Append(number[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Reversed = " + sb.ToString());
        Console.WriteLine();
    }
}

