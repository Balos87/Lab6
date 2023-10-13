using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Coyote : Wolf
    {
        public int RunSpeed { get; set; }

        public Coyote(int runSpeed, int numberOfLegs, int age, string name, string species, string favoriteFood, string furColor, string size, string sound) : base(numberOfLegs, age, name, species, favoriteFood, furColor, size, sound)
        {
            RunSpeed = runSpeed;
        }

        public void FastRunner()
        {
            Console.WriteLine($"En {Species} kan springa i hela {RunSpeed}km/h!");
        }

        public override void DailyActivities()
        {
            base.DailyActivities();
            FastRunner();
        }
    }
}
