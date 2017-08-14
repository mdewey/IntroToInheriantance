using System;

namespace IntroToInheriantance
{
    public class Cow : Animal 
    {
        public Cow()
        {
            this.FavoriteFood = "grass";
            this.Greeting = "Mooo";
        }

        public void GiveMilk(){
            Console.WriteLine("giving milk")

        }
    }
}