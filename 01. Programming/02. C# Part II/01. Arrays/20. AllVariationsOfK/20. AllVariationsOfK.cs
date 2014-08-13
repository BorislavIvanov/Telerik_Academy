// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
//Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

    class AllVariationsOfK
    {
        static void Main()
        {
            Console.Write("Please Enter Number N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Please Enter Number K: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Result: ");

            int[] array = new int[k];
            for (int i = 0; i < k; i++)
            {
                array[i] = 1;
            }
            int c;
            do
            {
                c = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    c = (array[i] == n) ? c + 1 : c;
                    Console.Write(" {0}", array[i]);
                }
                Console.WriteLine();

                array[0]++;
                for (int j = 0; j < k; j++)
                {
                    if (array[j] > n && j < k - 1)
                    {
                        array[j] = 1;
                        array[j + 1]++;
                    }
                }
            } while (c != k);

            Console.WriteLine();
        }
    }

