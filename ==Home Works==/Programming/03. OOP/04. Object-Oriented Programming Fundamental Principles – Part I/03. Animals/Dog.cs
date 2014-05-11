using System;

class Dog : Animal, ISound
{
    public Dog(string name, byte age, Gender gender) : base(name, age, gender)
    {
        
    }

    public void ProduceSound()
    {
        Console.WriteLine("{0} say: Bau! Bau!", this.Name);
    }
}