using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTurtorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal clarabelle = new Animal()
            {
                Name = "Clarabelle",
                Sound = "Mooo!"
            };

            Dog doggy = new Dog()
            {
                Name = "Doggy",
                Sound = "Vooof!",
                Sound2 = "GRRRRRR!"
            };

            doggy.MakeSound();
            clarabelle.MakeSound();

            clarabelle.SetAnimalIdInfo(51, "Olle");
            clarabelle.GetAnimalIdInfo();

            doggy.SetAnimalIdInfo(12, "Bobby");
            doggy.GetAnimalIdInfo();

            Animal.AnimalHealth animalHealth = new Animal.AnimalHealth();

            var result = animalHealth.HealthyWeight(2, 2);
            Console.WriteLine(result);
        }
    }
}
