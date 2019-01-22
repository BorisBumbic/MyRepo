using System;

namespace OOPGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior max = new Warrior("Max", 1200, 150, 50);

            Warrior min = new Warrior("Min", 1300, 145, 55);

            Battle.StartFight(max, min);

            Console.ReadLine();
        }
    }
}
