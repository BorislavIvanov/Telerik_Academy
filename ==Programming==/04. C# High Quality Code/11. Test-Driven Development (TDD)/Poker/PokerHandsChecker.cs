using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5 || HasRepeatingCards(hand))
            {
                return false;
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (IsValidHand(hand))
            {
                for (int i = 0; i < hand.Cards.Count; i++)
                {
                    var cardsFound = hand.Cards.ToList().FindAll(x => x.Face == hand.Cards[i].Face);
                    if (cardsFound.Count == 4)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            bool isFullHouse = false;
            if (IsValidHand(hand))
            {
                bool hasThree = HasThree(hand);
                bool hasTwo = HasTwo(hand);
                if (hasThree && hasTwo)
                {
                    isFullHouse = true;
                }
            }
            return isFullHouse;
        }

        

        public bool IsFlush(IHand hand)
        {
            if (IsValidHand(hand))
            {
                for (int i = 1; i < hand.Cards.Count - 1; i++)
                {
                    if (!(hand.Cards[0].Suit.Equals(hand.Cards[i].Suit)))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public bool IsStraight(IHand hand)
        {
            bool isStraight = false;
            if (IsValidHand(hand))
            {
                IHand orderedHand = OrderHand(hand);
                bool areOrdered = AreOrdered(orderedHand, 5);
                if (areOrdered)
                {
                    isStraight = true;
                }
            }
            return isStraight;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            bool isTreeOfAKind = false;
            if (IsValidHand(hand) && HasThree(hand))
            {
                isTreeOfAKind = true;
            }
            return isTreeOfAKind;
        }

        public bool IsTwoPair(IHand hand)
        {
            bool isTwoPair = false;
            if (IsValidHand(hand) && !IsOnePair(hand) && !IsThreeOfAKind(hand) && !IsStraight(hand) && !IsStraightFlush(hand)
                && !IsFlush(hand) && !IsFullHouse(hand) && !IsFourOfAKind(hand))
            {
                isTwoPair = true;
            }
            return isTwoPair;
        }

        public bool IsOnePair(IHand hand)
        {
            bool isOnePair = false;
            if (IsValidHand(hand) && HasTwo(hand))
            {
                isOnePair = true;
            }
            return isOnePair;
        }

        public bool IsHighCard(IHand hand)
        {
            bool isHighCard = false;
            if (IsValidHand(hand) && !IsOnePair(hand) && !IsThreeOfAKind(hand) && !IsStraight(hand) && !IsStraightFlush(hand)
                && !IsFlush(hand) && !IsFullHouse(hand) && !IsFourOfAKind(hand))
            {
                isHighCard = true;
            }
            return isHighCard;
        }

        public HandStrenght CheckHandStrenght(IHand hand)
        {
            if (IsStraightFlush(hand))
            {
                return HandStrenght.StraightFlush;
            }
            else if (IsFourOfAKind(hand))
            {
                return HandStrenght.FourOfAKind;
            }
            else if (IsFullHouse(hand))
            {
                return HandStrenght.FullHouse;
            }
            else if (IsFlush(hand))
            {
                return HandStrenght.Flush;
            }
            else if (IsStraight(hand))
            {
                return HandStrenght.Straight;
            }
            else if (IsThreeOfAKind(hand))
            {
                return HandStrenght.ThreeOfAKind;
            }
            else if (IsTwoPair(hand))
            {
                return HandStrenght.TwoPair;
            }
            else if (IsOnePair(hand))
            {
                return HandStrenght.OnePair;
            }
            else
            {
                return HandStrenght.HighCard;
            }
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            HandStrenght firstHandStrenght = CheckHandStrenght(firstHand);
            HandStrenght secondHandStrenght = CheckHandStrenght(secondHand);

            if (firstHandStrenght > secondHandStrenght)
            {
                return -1;
            }
            if (firstHandStrenght == secondHandStrenght)
            {
                return 0;
            }
            return 1;
        }

        private bool HasRepeatingCards(IHand hand)
        {
            IList<ICard> checkCards = hand.Cards.ToList();
            bool hasRepeating = false;
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                ICard currentCard = checkCards[i];
                checkCards.Remove(currentCard);
                if (checkCards.Contains(currentCard))
                {
                    hasRepeating = true;
                    break;
                }
                checkCards.Add(currentCard);
            }
            return hasRepeating;
        }

        private bool HasTwo(IHand hand)
        {
            bool hasTwo = false;
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                var checkedForTwo = hand.Cards.ToList().FindAll(x => x.Face == hand.Cards[i].Face);
                if (checkedForTwo.Count == 2)
                {
                    hasTwo = true;
                    break;
                }
            }
            return hasTwo;
        }

        private static bool HasThree(IHand hand)
        {
            bool hasTree = false;
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                var checkedForThree = hand.Cards.ToList().FindAll(x => x.Face == hand.Cards[i].Face);
                if (checkedForThree.Count == 3)
                {
                    hasTree = true;
                    break;
                }
            }
            return hasTree;
        }

        private IHand OrderHand(IHand hand)
        {
            IList<ICard> orderedCards = new List<ICard>();
            IList<ICard> checkCards = hand.Cards.ToList();
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                var minCard = checkCards.Min();
                checkCards.Remove(minCard);
                orderedCards.Add(minCard);
            }
            IHand newHand = new Hand(orderedCards.ToArray());
            return newHand;
        }

        private bool AreOrdered(IHand hand, int countOfOrdered)
        {
            bool areOrdered = true;
            int currentCard = (int)hand.Cards[0].Face;
            for (int i = 1; i < countOfOrdered; i++)
            {
                currentCard = currentCard + 1;
                int checkingCard = (int)hand.Cards[i].Face;
                if (currentCard != checkingCard)
                {
                    areOrdered = false;
                    break;
                }

            }
            return areOrdered;
        }
    }
}
