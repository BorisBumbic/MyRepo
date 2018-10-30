using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmprovCheckpoint_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some furnitures and their price.");
            string userInput = Console.ReadLine();
            string[] userInputSplit = userInput.Split(':');

            List<Furniture> FurnitureList = new List<Furniture>();

            foreach (var item in userInputSplit)
            {
                string[] secondSplit = item.Split(',');
                Furniture möbel = new Furniture();
                möbel.name = secondSplit[0];
                möbel.price = int.Parse(secondSplit[1]);

                FurnitureList.Add(möbel);
            }

            Furniture billigastMöbel = FurnitureList.OrderBy(x => x.price).First();

            Console.WriteLine($"{billigastMöbel.name} är den billigaste möbeln och dess pris är {billigastMöbel.price} kr.");
        }
    }
}
