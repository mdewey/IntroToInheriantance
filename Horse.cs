namespace IntroToInheriantance
{

    // POCO: Place Old C# Object  --- a c# Class
    public class Horse : Animal
    {
        public bool DoesHaveRider { get; set; }
        public int CountOfHorseShoes{get;set;}


        public Horse()
        {
           this.Greeting = "Neigh";
           this.FavoriteFood = "hey"; 
        }

        public int ShoeMyHorse()
        {
            this.CountOfHorseShoes = 4;
            return this.CountOfHorseShoes;
        }
    }
}