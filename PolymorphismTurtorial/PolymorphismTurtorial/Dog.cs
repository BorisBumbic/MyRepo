using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTurtorial
{
    //The below syntax is how you make a class inherit from another one. In this case the class dog inherits from animal.
    class Dog : Animal
    {
        //The below syntax defines a new varaible with auto-generated getter/setter and with a default value that is valid until manually changed.
        public string Sound2 { get; set; } = "Grr";

        //The syntax below is a way of overiding the method, with the same name, that is inherited from the parent class. In our case this would be 'Animal'. See furtehr explanation above the "MakeSound"
        //method in the Animal.cs.
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        //In the constructor below we use 'base' in order to reuse the setup in the constructor from the parent class. Only the new parameter "Sound2" needs to be set in this one.
        public Dog(string name = "No Name", string sound = "No Sound", string sound2 = "No Sound2")
            :base (name, sound)
        {
            Sound2 = sound2;
        }
    }
}
