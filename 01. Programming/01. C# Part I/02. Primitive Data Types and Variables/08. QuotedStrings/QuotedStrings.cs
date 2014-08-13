//Declare two string variables and assign them with following value:
//"The "use" of quotations causes difficulties."
//Do the above in two different ways: with and without using quoted strings.

using System;

class QuotedStrings
{
    static void Main()
    {
        Console.Title = "QuotedStrings";

        string @case1 = "The \"use\" of quotations causes difficulties.";
        string @case2 = "The use of quotations causes difficulties.";

        Console.WriteLine("Case 1 - {0}\nCase 2 - {1}", @case1, @case2);
    }
}

