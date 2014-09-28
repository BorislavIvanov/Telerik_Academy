using System;
using System.Collections.Generic;
using System.Linq;

class KnapsackProblemSolution
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Knapsack Problem Solution :)");
        Console.WriteLine();
        Console.ResetColor();

        // Checking input size of the knapsack.
        string consoleInputKnapsackSize = default(string);
        int knapsackSize = default(int);
        ValidateTheInputKnapsackSize(ref consoleInputKnapsackSize, ref knapsackSize);

        // Checking input count of products.
        string consoleInputProductsCount = default(string);
        int productsCount = default(int);
        ValidateTheInputProductsCount(ref consoleInputProductsCount, ref productsCount);

        Console.WriteLine();
        Console.WriteLine("Example for product adding...");
        Console.WriteLine("beer–3-2 => name=beer – weight=3 - cost=2");
        Console.WriteLine();

        // In this dictionary will be added to all products.
        Dictionary<string, List<int>> allProducts = new Dictionary<string, List<int>>();

        // This for loop will get all inputed products from console.
        GetAllInputedProductsFromConsole(productsCount, allProducts);

        // Verify that only one product is added and return it as a result.
        if (allProducts.Count == 1)
        {
            string firstProductName = allProducts.ElementAt(0).Key;
            int firstProductWeight = allProducts.ElementAt(0).Value[0];
            int firstProductCost = allProducts.ElementAt(0).Value[1];

            Console.WriteLine("Best solution is: Name=" + firstProductName + 
                " - Weight=" + firstProductWeight + " - Cost=" + firstProductCost);

            return;
        }

        // Arrays for dynamic programming solution of the problem.
        int[,] valuesArray = new int[productsCount + 1, knapsackSize + 1];
        int[,] keepArray = new int[productsCount + 1, knapsackSize + 1];

        InputTheProductsDataIntoArrays(allProducts, valuesArray, keepArray);

        List<string> bestSolutionItems = new List<string>();

        FindBestSolutionItems(knapsackSize, allProducts, keepArray, bestSolutionItems);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.Write("Best choice is: ");
        Console.WriteLine(string.Join(", ", bestSolutionItems));
        Console.ResetColor();

        Console.ReadLine();
    }

    private static void InputTheProductsDataIntoArrays(Dictionary<string, List<int>> allProducts, int[,] valuesArray, int[,] keepArray)
    {
        for (int r = 1; r < valuesArray.GetLength(0); r++)
        {
            var currentProduct = allProducts.ElementAt(r - 1);
            int currentProductWeight = currentProduct.Value[0];
            int currentProductCost = currentProduct.Value[1];

            for (int c = 1; c < valuesArray.GetLength(1); c++)
            {
                if (currentProductWeight == c)
                {
                    if (valuesArray[r - 1, c] <= currentProductCost)
                    {
                        valuesArray[r, c] = currentProductCost;
                        keepArray[r, c] = 1;
                    }
                    else
                    {
                        valuesArray[r, c] = valuesArray[r - 1, c];
                    }
                }
                else if (currentProductWeight < c)
                {
                    int remainingSpace = c - currentProductWeight;
                    int secondItemCost = valuesArray[r - 1, remainingSpace];

                    int currentCostPlusOneMoreItem = currentProductCost + secondItemCost;

                    if (currentCostPlusOneMoreItem >= valuesArray[r - 1, c])
                    {
                        valuesArray[r, c] = currentCostPlusOneMoreItem;
                        keepArray[r, c] = 1;
                    }
                    else
                    {
                        valuesArray[r, c] = valuesArray[r - 1, c];
                    }
                }
            }
        }
    }

    private static void FindBestSolutionItems(int knapsackSize, Dictionary<string, List<int>> allProducts, int[,] keepArray, List<string> bestSolutionItems)
    {
        bool traceContinue = true;
        int currentRow = keepArray.GetLength(0) - 1;
        int currentCol = keepArray.GetLength(1) - 1;
        int currentKnapsackWeight = 0;

        while (traceContinue)
        {
            int currentCell = keepArray[currentRow, currentCol];

            if (currentCell == 1)
            {
                var currentBestSolutionItem = allProducts.ElementAt(currentRow - 1);

                if ((currentKnapsackWeight + currentBestSolutionItem.Value[0]) <= knapsackSize)
                {
                    bestSolutionItems.Add(currentBestSolutionItem.Key);
                    currentKnapsackWeight += currentBestSolutionItem.Value[0];
                }
                else
                {
                    traceContinue = false;
                }

                currentRow--;
                currentCol--;
            }
            else
            {
                currentRow--;
            }

            if (currentRow == 0)
            {
                traceContinue = false;
            }
        }
    }

    private static void GetAllInputedProductsFromConsole(int productsCount, Dictionary<string, List<int>> allProducts)
    {
        for (int i = 0; i < productsCount; i++)
        {
            Console.Write("Enter product " + (i + 1) + ": ");
            string inputProduct = Console.ReadLine();
            var arrOfProductValues = inputProduct.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);

            string prodctName = default(string);
            int productWeight = default(int);
            int productCost = default(int);

            // Checking is the product are correct.
            while (arrOfProductValues.Length < 3 ||
                (arrOfProductValues[0].Length == 0 ||
                (!int.TryParse(arrOfProductValues[1], out productWeight) || productWeight < 1) ||
                (!int.TryParse(arrOfProductValues[2], out productCost) || productCost < 1)))
            {
                Console.Write("ReEnter product " + (i + 1) + ": ");
                inputProduct = Console.ReadLine();
                arrOfProductValues = inputProduct.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
            }

            // Adding the product into Dictionary.
            prodctName = arrOfProductValues[0];
            productWeight = int.Parse(arrOfProductValues[1]);
            productCost = int.Parse(arrOfProductValues[2]);

            allProducts.Add(prodctName, new List<int> { productWeight, productCost });
        }
    }

    private static void ValidateTheInputProductsCount(ref string consoleInputProductsCount, ref int productsCount)
    {
        do
        {
            Console.Write("Enter the count of products: ");
            consoleInputProductsCount = Console.ReadLine();
        }
        while (!int.TryParse(consoleInputProductsCount, out productsCount) || productsCount < 1);
    }

    private static void ValidateTheInputKnapsackSize(ref string consoleInputKnapsackSize, ref int knapsackSize)
    {
        do
        {
            Console.Write("Enter the size of Knapsack: ");
            consoleInputKnapsackSize = Console.ReadLine();
        }
        while (!int.TryParse(consoleInputKnapsackSize, out knapsackSize) || knapsackSize < 1);
    }
}