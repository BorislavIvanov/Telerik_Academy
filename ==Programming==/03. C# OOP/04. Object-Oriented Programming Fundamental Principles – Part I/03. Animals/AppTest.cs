// 03. Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
//All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name 
//and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. 
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

using System;
using System.Linq;
using System.Collections.Generic;

class AppTest
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Test The Animals...");
        Console.ResetColor();
        Console.WriteLine();

        TomCat tomy = new TomCat("Tom", 3);
        Console.WriteLine("TomCat - " + tomy);
        tomy.ProduceSound();

        Console.WriteLine();

        Dog rex = new Dog("Rex", 5, Gender.Male);
        Console.WriteLine("Dog - " + rex);
        rex.ProduceSound();

        Console.WriteLine();

        Frog flip = new Frog("Flip", 1, Gender.Male);
        Console.WriteLine("Frog - " + flip);
        flip.ProduceSound();

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Average Age...");
        Console.ResetColor();
        Console.WriteLine();

        List<Cat> listOfCats = new List<Cat>();
        listOfCats.Add(new Cat("Joney", 5, Gender.Male));
        listOfCats.Add(new Cat("Mike", 1, Gender.Male));
        listOfCats.Add(new Cat("Simi", 5, Gender.Female));

        double catsAverageAge = listOfCats.Average(x => x.Age);
        Console.WriteLine("List Of Cats Average Age: {0}", catsAverageAge);

        List<Dog> listOfDogs = new List<Dog>();
        listOfDogs.Add(new Dog("Sharko", 3, Gender.Female));
        listOfDogs.Add(new Dog("Foxy", 1, Gender.Female));
        listOfDogs.Add(new Dog("Tommy", 5, Gender.Male));

        double dogsAverageAge = listOfDogs.Average(x => x.Age);
        Console.WriteLine("List Of Dogs Average Age: {0}", dogsAverageAge);

        Console.WriteLine();
    }
}