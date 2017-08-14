using System;

namespace IntroToInheriantance
{
    // base class for animals, propeties,
    // and has a certain actions
    // breath, speak, eat


    public abstract class Animal
    {
        public string Greeting { get; set; }
        public string Name { get; set; }
        public string FavoriteFood { get; set; }

        public void Speak()
        {
            Console.WriteLine($"{this.Greeting}");
        }

        public void Eat()
        {
            Console.WriteLine($"My Favorite Food is {FavoriteFood}");
        }

    }
}