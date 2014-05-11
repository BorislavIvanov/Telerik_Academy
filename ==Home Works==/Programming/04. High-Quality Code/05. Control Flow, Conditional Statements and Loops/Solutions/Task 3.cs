class Task_3
{
    int i = 0;
    bool expectedValueFound = false;

    for (i = 0; i < 100; i++)
    {
        if (i % 10 == 0)
        {
            if (array[i] == expectedValue)
            {
                expectedValueFound = true;
                break;
            }
        }

        Console.WriteLine("{0}, ", array[i]);
    }
    // More code here.
    if (expectedValueFound)
    {
        Console.WriteLine("Value Found");
    }
}