using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindNumbersLINQ
{
    private int[] numbers;

    public int[] Numbers
    {
        get { return this.numbers; }
        set { this.numbers = value; }
    }
    public FindNumbersLINQ(int[] numbers)
    {
        this.Numbers = numbers;
    }

    public void LINQPrint()
    {
        var correctNumbers =
            from number in this.Numbers
            where (number % 21) == 0
            select number;

        Console.Write("[ ");
        foreach (int number in correctNumbers)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine("]");
    }
}