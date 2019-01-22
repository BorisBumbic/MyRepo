using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTurtorial
{
    //If you want to restrict a subclass from inheriting from a class you need to mark it as a "sealed" class in the declaration.
    class Animal
    {
        //difference between private and protected?
        private string name;
        protected string sound;
        protected AnimalIdInfo animalIdInfo = new AnimalIdInfo();

        //In the case when we need to creater setters and getters for a parameter whose type is of a different class one can make use of these two classes set below.
        public void SetAnimalIdInfo(int idNum, string ownerName)
        {
            animalIdInfo.IdNum = idNum;
            animalIdInfo.OwnerName = ownerName;
        }
        
        public void GetAnimalIdInfo()
        {
            Console.WriteLine($"{Name} has an ID of {animalIdInfo.IdNum} and the owners name is {animalIdInfo.OwnerName}");
        }

        //The 'virtual' in the declaration of the method makes sure that the method can be overridden by methods with the same name in child classes inheriting from this one (see Dog.cs). This is especially 
        //important when you declare a new instance of the class like so: "Animal doggy = new Dog()". If we didnt mark this as virtual, and the same method in dog as override it would not override this
        //method with that of the Dog.cs class.
        public virtual void MakeSound()
        {
            Console.WriteLine($"{name} say {sound}");
        }

        //The three constructors below are made in order to handle what happens when a new instance is initiated with different kinds of input. In the first one no 'name' or 'sound' is passed into the
        //constructor so it defaults to 'No Name'/'No Sound'.
        public Animal()
            :this("No Name", "No Sound") { }

        public Animal(string name)
            : this(name, "No Sound") { }

        //As you can see by the capital letter in the variables we are assigning, we are using the setters for the constructors with the same name. 
        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        //Below we create properties that makes the variables accessible from the outside of the class.
        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }

                name = value;
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                }
                    
                sound = value;
            }
        }

        //Below we have an example of an so called inner class. This is a help class to the outer one, in our case in order to establish wether the animal is healthy based on its wright and height.
        //Remember that since this is its own class you need to allocate memory for it in order to use it.
        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;

                if (calc >= 1 && calc <= 2)
                    return true;
                else
                    return false;
            }
        }
    }
}
