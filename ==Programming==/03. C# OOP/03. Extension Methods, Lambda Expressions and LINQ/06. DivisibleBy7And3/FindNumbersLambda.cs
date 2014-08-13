using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindNumbersLambda
{
    private int[] numbers;

    public int[] Numbers
    {
        get { return this.numbers; }
        set { this.numbers = value; }
    }
    public FindNumbersLambda(int[] numbers)
    {
        this.Numbers = numbers;
    }

    public void LambdaPrint()
    {
        var correctNumbers = this.Numbers.Where(x => (x % 21) == 0);

        Console.Write("[ ");
        foreach (int number in correctNumbers)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine("]");
    }
}

