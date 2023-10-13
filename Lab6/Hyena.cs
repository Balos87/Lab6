using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Hyena : Wolf
    {
        public int Feef { get; set; }

        public Hyena(int feef, int numberOfLegs, int age, string name, string species, string favoriteFood, string furColor, string size, string sound) : base(numberOfLegs, age, name, species, favoriteFood, furColor, size, sound)
        {
            Feef = feef;
        }

        public void Smiling()
        {
            Console.WriteLine($"En {Species} har otroligt starka käkar, och är utrustad med hela {Feef}st tänder.");
            Console.ReadKey();
        }

        public override void DailyActivities()
        {
            base.DailyActivities();
            Smiling();
        }
    }
}
