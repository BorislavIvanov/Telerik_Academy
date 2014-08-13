using System;

class Cat : Animal, ISound
{
    public Cat(string name, byte age, Gender gender) : base(name, age, gender)
    {
        
    }

    public void ProduceSound()
    {
        Console.WriteLine("{0} say: Miay! Miay!", this.Name);
    }
}