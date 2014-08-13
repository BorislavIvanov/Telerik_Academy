using System;

class MissCat2011
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        int cat1 = 0;
        int cat2 = 0;
        int cat3 = 0;
        int cat4 = 0;
        int cat5 = 0;
        int cat6 = 0;
        int cat7 = 0;
        int cat8 = 0;
        int cat9 = 0;
        int cat10 = 0;
        
        for (int i = 0; i < numberN; i++)
        {
            int vote = int.Parse(Console.ReadLine());
            if (vote == 1)
            {
                cat1 += 1;
            }
            if (vote == 2)
            {
                cat2 += 1;
            } if (vote == 3)
            {
                cat3 += 1;
            } if (vote == 4)
            {
                cat4 += 1;
            } if (vote == 5)
            {
                cat5 += 1;
            } if (vote == 6)
            {
                cat6 += 1;
            } if (vote == 7)
            {
                cat7 += 1;
            } if (vote == 8)
            {
                cat8 += 1;
            } if (vote == 9)
            {
                cat9 += 1;
            } if (vote == 10)
            {
                cat10 += 1;
            }
        }

        int winner = 0;
        int winnerNumber = 0;

        if (cat10 > winner)
        {
            winner = cat10;
            winnerNumber = 10;
        }
        if (cat9 > winner)
        {
            winner = cat9;
            winnerNumber = 9;
        }
        if (cat8 > winner)
        {
            winner = cat8;
            winnerNumber = 8;
        }
        if (cat7 > winner)
        {
            winner = cat7;
            winnerNumber = 7;
        }
        if (cat6 > winner)
        {
            winner = cat6;
            winnerNumber = 6;
        }
        if (cat5 > winner)
        {
            winner = cat5;
            winnerNumber = 5;
        }
        if (cat4 > winner)
        {
            winner = cat4;
            winnerNumber = 4;
        }
        if (cat3 > winner)
        {
            winner = cat3;
            winnerNumber = 3;
        }
        if (cat2 > winner)
        {
            winner = cat2;
            winnerNumber = 2;
        }
        if (cat1 >= winner)
        {
            winner = cat1;
            winnerNumber = 1;
        }

        Console.WriteLine(winnerNumber);
    }
}

