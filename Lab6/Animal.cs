using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string FavoriteFood { get; set; }
        public string FurColor { get; set; }
        public string Size { get; set; }
        public string Sound { get; set; }
        public static string PlayerName { get; set; }
        private static Random _random = new Random();
        protected static int _counter = 0;

        public Animal(int age, string name, string species, string favoriteFood, string furColor, string size, string sound)
        {
            Age = age;           
            Name = name;
            Species = species;
            FavoriteFood = favoriteFood;
            FurColor = furColor;
            Size = size;
            Sound = sound;          
        }

        public static void SetPlayerName() 
        {
            Console.WriteLine("\n~*~*~*~*~*~*~*~*~*~*~*~*~*.Game instructions.*~*~*~*~*~*~*~*");
            Console.WriteLine("Vänligen tryck på 'enter' vid varje pause för att fortsätta.\nTyp som nu.\n");
            Console.WriteLine("*end of instructions*");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*\n");
            Console.ReadKey();           

            DateTime timeNow = DateTime.Now;
            if (timeNow.Hour < 11 && timeNow.Hour >= 5)
            {
                Console.WriteLine("God morgon! Bra att börja jobbet såhär tidigt!");
                Console.ReadKey();
            } 
            else if (timeNow.Hour >= 11)
            {
                Console.WriteLine("God förmiddag! Lunchdags snart va?");
                Console.ReadKey();
            }
            else if (timeNow.Hour >= 16)
            {
                Console.WriteLine("God eftermiddag! Inne på småtimmarna ser jag!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("God kväll! Lite sent nu va? ;)");
                Console.ReadKey();
            }
            Console.Write("Välkommen till Dennis (NET23) ZooLand! \n\nVad heter du?: ");
            PlayerName = Console.ReadLine();
            Console.WriteLine($"\nFint namn, {PlayerName}. \nHoppas du är lika taggad som jag!!");
            Console.ReadKey();
            Console.WriteLine($"\nVi Presenterar Följande Shoooow!!!");
        }

        public void MakeSoundAndSpecies()
        {
            _counter++;

            static void DisplayMessage() 
            {
                Console.WriteLine($"\n*Mer Konfetti*! Förlåt... kunde inte låta bli.*troll*");
                Console.WriteLine($"Du har blivit konfettitiad {_counter} gånger nu! \nEller..{_counter * 2} Beroende på hur man ser på det... eller nått.");
                Console.ReadKey();
            }
         
            Console.WriteLine("\nTadaaaa!*Konfetti*");
            Console.ReadKey();

                if (_counter >= 2)
                {
                    DisplayMessage();
                }

            Console.WriteLine($"\n{Sound}");
            Console.ReadKey();
            Console.WriteLine($"Titta! En {Species}!! Vilket makalöst ögonblick!\n");    
        }

        public bool TiredOrNot()
        {
            int tiredCheckerBasedOnRandomnessNotEnergy = _random.Next(0, 2);
            if (tiredCheckerBasedOnRandomnessNotEnergy == 0)
            {
                Console.WriteLine($"Ser man på, {Name} är trött och vill sova.\n");
                Console.ReadKey();
                return true;               
            } 
            else
            {
                Console.WriteLine($"Full fart framåt! {Name} är hur pigg som helst! *Springer runt i cirklar*\n");
                Console.ReadKey();
                return false;                
            }
        }

        public bool PlayTime(bool isTired)
        {
            if (isTired)
            {
                Console.WriteLine($"*.. {PlayerName} väntar på den otroliga varelsen...*\n{Name} har vilat och det är dags att röra på den {Size} kroppen!\n");
                Console.ReadKey();
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} blev trött av all lek och valde att sova lite... \n...Den gillar att bli klappad på den {FurColor} pälsen när den sover.\n");
                Console.ReadKey();
                return false;
            }
        }

        public void HungryOrNot(bool hasPlayed) 
        {          
            if (hasPlayed)
            {
                Console.WriteLine($"{Name} blev hungrig av allt springande. Dags för lite {FavoriteFood}!\n");
                Console.ReadKey();
            } 
            else
            {
                Console.WriteLine($"*...{PlayerName} undrar hur länge till det ska ta...*");
                Console.ReadKey();
                Console.WriteLine("...........");
                Console.ReadKey();
                Console.WriteLine($"\nNyvaken som {Name} är så missade vi tyvärr ätstunden denna gång...\n");
                Console.ReadKey();
            }
        }

        public virtual void DailyActivities()
        {
            MakeSoundAndSpecies();
            bool isTired = this.TiredOrNot();
            bool hasPlayed = this.PlayTime(isTired);
            HungryOrNot(hasPlayed);
        }




    }
}
