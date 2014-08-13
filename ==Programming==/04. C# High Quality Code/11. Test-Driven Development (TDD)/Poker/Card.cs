using System;
using System.Text;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            switch (this.Face)
            {
                case CardFace.Two: output.Append('2');
                    break;
                case CardFace.Three: output.Append('3');
                    break;
                case CardFace.Four: output.Append('4');
                    break;
                case CardFace.Five: output.Append('5');
                    break;
                case CardFace.Six: output.Append('6');
                    break;
                case CardFace.Seven: output.Append('7');
                    break;
                case CardFace.Eight: output.Append('8');
                    break;
                case CardFace.Nine: output.Append('9');
                    break;
                case CardFace.Ten: output.Append("10");
                    break;
                case CardFace.Jack: output.Append('J');
                    break;
                case CardFace.Queen: output.Append('Q');
                    break;
                case CardFace.King: output.Append('K');
                    break;
                case CardFace.Ace: output.Append('A');
                    break;
                default:
                    break;
            }

            switch (this.Suit)
            {
                case CardSuit.Clubs: output.Append('♣');
                    break;
                case CardSuit.Diamonds: output.Append('♦');
                    break;
                case CardSuit.Hearts: output.Append('♥');
                    break;
                case CardSuit.Spades: output.Append('♠');
                    break;
                default:
                    break;
            }

            return output.ToString();
        }
    }
}
