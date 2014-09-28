using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LevenshteinDistanceSolution
{
    private const decimal CostDelete = 0.9M;
    private const decimal CostInsert = 0.8M;
    private const decimal CostReplace = 1M;

    public static void Main()
    {
        var result1 = Compute("developer", "enveloped");
        Console.WriteLine("Words: developer -> enveloped");
        Console.WriteLine("Distance = {0}", result1);
        Console.WriteLine();

        var result2 = Compute("developer", "eveloper");
        Console.WriteLine("Words: developer -> eveloper");
        Console.WriteLine("Distance = {0}", result2);
        Console.WriteLine();

        var result3 = Compute("eveloper", "enveloper");
        Console.WriteLine("Words: eveloper -> enveloper");
        Console.WriteLine("Distance = {0}", result3);
        Console.WriteLine();

        var result4 = Compute("eveloper", "");
        Console.WriteLine("Words: eveloper ->  ");
        Console.WriteLine("Distance = {0}", result4);
        Console.WriteLine();

        var result5 = Compute("", "eveloper");
        Console.WriteLine("Words:  -> enveloper");
        Console.WriteLine("Distance = {0}", result5);
        Console.WriteLine();

        var result6 = Compute("", "");
        Console.WriteLine("Words:  -> ");
        Console.WriteLine("Distance = {0}", result6);
    }

    /// <summary>
    /// Compute the distance between two words.
    /// </summary>
    public static decimal Compute(string word1, string word2)
    {
        decimal[,] table;

        int n = word1.Length;
        int m = word2.Length;
        table = new decimal[n + 1, m + 1];

        // Step 1: Fill cost of deletions
        for (int row = 0; row <= n; row++)
        {
            table[row, 0] = row * CostDelete;
        }

        // Step 2: Fill cost of insertions
        for (int col = 0; col <= m; col++)
        {
            table[0, col] = col * CostInsert;
        }

        // Step 3: Calculate and choose min cost operation
        for (int row = 1; row <= n; row++)
        {
            // Step 4
            for (int col = 1; col <= m; col++)
            {
                // Step 5: Calculate the cost of replacing. If the letters are equal it is 0, otherwise its the replace operation cost
                decimal cost = (word2[col - 1] == word1[row - 1]) ? 0 : CostReplace;

                // Step 6: Find the minimal cost operation of the 3 possible
                decimal delete = table[row - 1, col] + CostDelete;
                decimal replace = table[row - 1, col - 1] + cost;
                decimal insert = table[row, col - 1] + CostInsert;

                table[row, col] = Math.Min(
                    Math.Min(delete, insert),
                    replace);
            }
        }

        // Step 7: Take and return the result (most down-right cell)
        return table[n, m];
    }
}