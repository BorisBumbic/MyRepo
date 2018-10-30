using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Modullering_hiss
{
    class Elevator
    {
        public Elevator(string name, int currstorey, int highStorey, int lowStorey, int age)
        {
            namn = name;
            högstaVåning = highStorey;
            lägstaVåning = lowStorey;
            startvåning = currstorey;
            ålder = age;

        }
        public bool OnOff = true;
        public string namn { get; set; }

        public int startvåning { get; set; }

       // public int vikt { get; set; }

        public int ålder { get; set; }

        public int högstaVåning { get; set; }

        public int lägstaVåning { get; set; }

        //public bool färdRiktning { get; set; }

        

        public void GoUp()
        {
            while (OnOff == true)
            {
                if (högstaVåning <= startvåning)
                {
                    Console.WriteLine("Du är på högsta våningen redan!");
                    startvåning = högstaVåning;
                    break;
                }

                else
                {
                    startvåning++;
                    ålder--;
                    break;
                }

                    }
            if (ålder <= 0)
            {
                OnOff = false;
            }
        }

        public void GoDown()
        {
            while (OnOff == true)
            {
                if (lägstaVåning >= startvåning)
                {
                    Console.WriteLine("Du är på lägsta våningen redan!");
                    startvåning = lägstaVåning;
                    break;
                }
                else
                {
                    startvåning--;
                    ålder--;
                    break;
                }

            }
            if (ålder <= 0)
            {
                OnOff = false;
            }

        }


        public string Report()
        {
            string yes = "Hissen " + namn + " är på våning " + startvåning + ". Hissen är på. Tid tills underhåll " + ålder;
            string no = "Hissen " + namn + " är på våning " + startvåning + ". Hissen är av. Tid tills underhåll " + ålder;
            if (OnOff == true)
                return yes;
            else
                return no;    
        }


    }
    public class Random
    {
        public static void Info(string input)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(input);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    
}
