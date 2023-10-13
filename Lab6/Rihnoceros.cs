using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Rihnoceros : Animal
    {
        public string RollingAround {  get; set; }

        public Rihnoceros(string rollingAround, int age, string name, string species, string favoriteFood, string furColor, string size, string sound) : base(age, name, species, favoriteFood, furColor, size, sound)
        {
            RollingAround = rollingAround;
        }

        public void DirtBringer()
        {
            Console.WriteLine($"Den här {Species} älskar verkligen att rulla i {RollingAround},\nleran skyddar kroppen från solen, typ som solkräm fast utan solskyddsfaktor.");
            Console.ReadKey();
        }

        public override void DailyActivities()
        {
            base.DailyActivities();
            DirtBringer();
        }
    }
}
