using System.Data.Common;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Animal.SetPlayerName();
            string PlayerName = Animal.PlayerName;

            Giraffe giraffe = new Giraffe(2.3, 15, "MrLongNeck", "giraff", "vindruvor", "oranga", "gigantisk", "Mwwrroooorwww *wtf?*");
            giraffe.DailyActivities();

            Wolf wolf = new Wolf(4, 8, "Doris", "varg", "köttbullar", "gråa", "mellanstora","Aaaaoooouuuhhhhhhhh *Ylar mot månen*");
            wolf.DailyActivities();

            Rihnoceros rhino = new Rihnoceros("grötig lera", 7, "SamTheRhino", "noshörning", "vattenmelon", "grålädriga", "enorma", "hnf-hnf");
            rhino.DailyActivities();

            Hyena hyena = new Hyena(34, 4, 8, "FlitigaFlina", "hyena", "köttfärssås med ben", "brun-randiga", "stora", "Whooo-ooop!! HEHEHE");
            hyena.DailyActivities();

            Coyote coyote = new Coyote(59, 4, 9, "SnabbaSune", "prärievarg", "kaninsoppa", "gråish", "lilla", "Eeeehhhahaha");
            coyote.DailyActivities();

            
        }   
    }
}