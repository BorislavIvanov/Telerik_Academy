//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
//Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;

class TheSumIsZero
{
    static void Main()
    {
        Console.Title = "The Sum Is Zero";

        Console.Write("Enter First Number:  ");
        int one = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Number: ");
        int two = int.Parse(Console.ReadLine());
        Console.Write("Enter Third Number:  ");
        int three = int.Parse(Console.ReadLine());
        Console.Write("Enter Fourth Number: ");
        int four = int.Parse(Console.ReadLine());
        Console.Write("Enter Fifth Number:  ");
        int five = int.Parse(Console.ReadLine());

        Console.WriteLine(new string ('-', 15));

        //Знам че от тук на долу начинът не е най-удачният и с цикъл е по-добре но така реших да бъде :)

        if (one + two + three == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0 ", one, two, three);
        }

        if (two + three + four == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", two, three, four);
        }

        if (three + four + five == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", three, four, five);
        }

        if (one + two + four == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", one, two, four);
        }

        if (one + two + five == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", one, two, five);
        }

        if (one + four + five == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", one, four, five);
        }

        if (two + four + five == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", two, four, five);
        }

        if (one + three + five == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", one, three, five);
        }

        if (one + three + four == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", one, three, four);
        }

        if (two + three + five == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", two, three, five);
        }
    }
}

