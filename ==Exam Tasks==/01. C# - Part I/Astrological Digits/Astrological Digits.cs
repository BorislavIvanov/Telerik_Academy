using System;

class Program
{
    static void Main(string[] args)
    {
        string N = Console.ReadLine();

        while (N.Length != 1)
        {
            ulong calculation = 0;

            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] != '-' && N[i] != '.')
                {
                    calculation += ulong.Parse(N[i].ToString());
                }
            }

            N = calculation.ToString();
        }

        Console.WriteLine(N);
    }
}