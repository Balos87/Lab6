using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Wolf : Animal
    {

        public int NumberOfLegs { get; set; }

        public Wolf(int numberOfLegs, int age, string name, string species, string favoriteFood, string furColor, string size, string sound) : base(age, name, species, favoriteFood, furColor, size, sound)
        {
            NumberOfLegs = numberOfLegs;
        }

        public void Tail() 
        {
            Console.WriteLine($"{Name} viftar på sin svans medans hon står på sina {NumberOfLegs} ben!");
            Console.ReadKey();
        }

        public override void DailyActivities()
        {           
            base.DailyActivities();
            Tail();
        }

    }
}
