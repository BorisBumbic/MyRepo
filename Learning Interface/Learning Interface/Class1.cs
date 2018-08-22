using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_Interface
{
    public interface IFriendly
    {
        void Greet();
        void ThanksForDinner(string meal);
        void DoNiceThings();
    }

    public interface IAggressive
    {
        int Bite();
        void ShowTeeth();
        void Growl();
        void DoMeanThings();
    }

    public class Dog : IFriendly, IAggressive
    {
        string name { get; set; }
        public Dog(string _name)
        {
            name = _name;
        }
        public void Greet()
        { Console.WriteLine($"Woof! {name} is happy to see you!"); }
        public void ThanksForDinner(string meal)
        { Console.WriteLine($"{this} ate the {meal}."); }
        public int Bite()
        { Random Damage = new Random();
            int dmg = Damage.Next(1, 4);
            Console.WriteLine($"{name} bit {dmg} of your limbs off!");
            return dmg;
        }
        public void ShowTeeth()
        { Console.WriteLine($"{name} is grinning at you, showing its razor sharp teeth..."); }
        public void Growl()
        { Console.WriteLine($"{name} is growling at you."); }
        public void DoNiceThings()
        {Console.WriteLine($"The {name} licks you in the face.");}
        public void DoMeanThings()
        {
            Console.WriteLine($"{name} is chewing on your boot!");
        }
    }

    public class Cat : IFriendly
    {
        string name { get; set; }
        public Cat(string _name)
        {
            name = _name;
        }
        public void Greet()
        { Console.WriteLine($"Mjau! {name} is happy to see you!"); }
        public void ThanksForDinner(string meal)
        { Console.WriteLine($"{name} ate the {meal}."); }
        void DoNiceThings()
        { Console.WriteLine($"{name} is rubbing against your leg."); }

    }
}
