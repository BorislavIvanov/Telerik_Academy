#Test-Driven Development (TDD)

**Exercise:**

Finish the "``Poker``" project given in the Visual Studio Solution "[11. Test-Driven-Development-Demo+Homework.zip](https://github.com/BorislavIvanov/Telerik_Academy/tree/master/01.%20Programming/04.%20C%23%20High%20Quality%20Code/11.%20Test-Driven%20Development%20(TDD)/Exercise%20Files)" using TDD.

1. Write a class ``Card`` implementing the ``ICard`` interface. Implement the properties. Write a constructor. Implement the ``ToString()`` method. Test all cases.

2. Write a class ``Hand`` implementing the ``IHand`` interface. Implement the properties. Write a constructor. Implement the ``ToString()`` method. Test all cases.

3. Write a class P``okerHandsChecker`` (+ tests) and start implementing the ``IPokerHandsChecker`` interface. Implement the ``IsValidHand(IHand)``. A hand is valid when it consists of exactly 5 different cards.

4. Implement ``IPokerHandsChecker``. ``IsFlush(IHand)`` method. Follow the official poker rules from Wikipedia: http://en.wikipedia.org/wiki/List_of_poker_hands

5. Implement ``IsFourOfAKind(IHand)`` method. Did you test all the scenarios?

6. (Difficult task) Implement the other check for poker hands: ``IsHighCard(IHand hand)``, ``IsOnePair(IHand hand)``, ``IsTwoPair(IHand hand)``, ``IsThreeOfAKind(IHand hand)``, ``IsFullHouse(IHand hand)``, ``IsStraight(IHand hand)`` and ``IsStraightFlush(IHand hand)``. Did you test all the scenarios well?

7. (Difficult task) Implement a card comparison logic for Poker hands (+ tests). ``CompareHands(…)`` should return ``-1``, ``0`` or ``1``.
