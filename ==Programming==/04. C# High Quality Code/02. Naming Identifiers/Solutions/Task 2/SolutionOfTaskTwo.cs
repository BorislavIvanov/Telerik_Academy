class HumanCreator
    {
        enum Gender { Male, Female };

        class Human
        {
            public Gender gender { get; set; }
            public string name { get; set; }
            public int age { get; set; }
        }

        public void CreateHuman(int magicNumber)
        {
            Human newHuman = new Human();
            newHuman.age = magicNumber;
            if (magicNumber % 2 == 0)
            {
                newHuman.name = "Батката";
                newHuman.gender = Gender.Male;
            }
            else
            {
                newHuman.name = "Мацето";
                newHuman.gender = Gender.Female;
            }
        }
    }