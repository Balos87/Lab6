using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Giraffe : Animal
    {
        public double LengthOfNeck {  get; set; }

        public Giraffe(double lengthOfNeck, int age, string name, string species, string favoriteFood, string furColor, string size, string sound) : base(age, name, species, favoriteFood, furColor, size, sound)
        {
            LengthOfNeck = lengthOfNeck;
        }

        public void GiraffeStretchesItsNeck()
        {
            Console.WriteLine($"Oh my god... Den där {Species}en - vid namn {Name} har en RIKTIGT lång..");
            Console.ReadKey();
            Console.WriteLine($"hals!! *Host* Hela {LengthOfNeck}m lång!");
            Console.ReadKey();
        }

        public override void DailyActivities()
        {
            base.DailyActivities(); 
            GiraffeStretchesItsNeck();
        }


    }
}
