using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyttFörsökPåCheckpoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rooms of the apartment and their sizes.");

            //string userInput = Console.ReadLine();

            string userInput = "livingroom 40m2 | bathroom 15m2 | kitchen 26m2";

            string[] userSplitList = userInput.Split('|');

            List<Room> RoomList = new List<Room>();

            foreach (var item in userSplitList)
            {
                Room Rum = new Room();
                string[] loopSplit = item.Trim().Split();
                Rum.livingspace = int.Parse(loopSplit[1].Replace("m2" , ""));
                Rum.name = loopSplit[0];

                RoomList.Add(Rum);

            }

            foreach (var item in RoomList)
            {
                Console.WriteLine($"The {item.name} is {item.livingspace}m2 big.");
            }

            int smallestRoomSize = 100000000;
            string smallestRoomName = "";


            foreach (var item in RoomList)
            {
                if (item.livingspace < smallestRoomSize)
                {
                    smallestRoomName = item.name;
                    smallestRoomSize = item.livingspace;
                }
            
            }

            Console.WriteLine($"{smallestRoomName} {smallestRoomSize}");
        }
    }
}
