using System;

class Frog : Animal, ISound
{
    public Frog(string name, byte age, Gender gender) : base(name, age, gender)
    {
        
    }

    public void ProduceSound()
    {
        Console.WriteLine("{0} say: Gribit!", this.Name);
    }
}