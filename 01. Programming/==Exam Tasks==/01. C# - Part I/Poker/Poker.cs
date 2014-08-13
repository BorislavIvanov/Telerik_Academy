using System;
using System.Collections.Generic;

class Poker
{
    static void Main()
    {
        List<int> cards = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "J": cards.Add(11);
                    break;
                case "Q": cards.Add(12);
                    break;
                case "K": cards.Add(13);
                    break;
                case "A": cards.Add(14);
                    break;
                default: cards.Add(int.Parse(input));
                    break;
            }
        }

        cards.Sort();

        if (cards[0] == cards[1] && cards[1] == cards[2] && cards[2] == cards[3] && cards[3] == cards[4])
        {
            Console.WriteLine("Impossible");
        }
        else if ((cards[0] == cards[1] && cards[1] == cards[2] && cards[2] == cards[3]) || 
                    cards[1] == cards[2] && cards[2] == cards[3] && cards[3] == cards[4])
        {
            Console.WriteLine("Four of a Kind");
        }
        else if ((cards[0] == cards[1] && (cards[2] == cards[3] && cards[3] == cards[4])) ||
                    ((cards[0] == cards[1] && cards[1] == cards[2]) && cards[3] == cards[4]))
        {
            Console.WriteLine("Full House");
        }
        else if ((cards[0] == cards[1] - 1 && cards[1] == cards[2] - 1 && cards[2] == cards[3] - 1 && cards[3] == cards[4] - 1) ||
                    cards[4] - 13 == cards[0] - 1 && cards[0] == cards[1] - 1 && cards[1] == cards[2] - 1 && cards[2] == cards[3] - 1)
        {
            Console.WriteLine("Straight");
        }
        else if ((cards[0] == cards[1] && cards[1] == cards[2]) || 
                                (cards[1] == cards[2] && cards[2] == cards[3]) || 
                                    (cards[2] == cards[3] && cards[3] == cards[4]))
        {
            Console.WriteLine("Three of a Kind");
        }
        else if ((cards[0] == cards[1] && cards[2] == cards[3]) || 
                    (cards[1] == cards[2] && cards[3] == cards[4]) || 
                        (cards[0] == cards[1] && cards[3] == cards[4]))
        {
            Console.WriteLine("Two Pairs");
        }
        else if (cards[0] == cards[1] || cards[1] == cards[2] || cards[2] == cards[3] || cards[3] == cards[4])
        {
            Console.WriteLine("One Pair");
        }
        else
        {
            Console.WriteLine("Nothing");
        }
    }
}