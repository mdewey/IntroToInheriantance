using System;

namespace IntroToInheriantance
{
    class Program
    {
        static void Main(string[] args)
        {

            var horse = new Horse{
                Name = "Clippity Clop"
            };

            horse.Speak();
            horse.Eat();
            horse.ShoeMyHorse();

            var cow = new Cow{
                Name = "Betsy"
            };

            cow.Speak();
            cow.Eat();
            cow.GiveMilk();


            Console.WriteLine("Hello World!");
        }
    }
}
