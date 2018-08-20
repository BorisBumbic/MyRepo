using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2
{
    public class Room
    {
        public string name { get; set; }

        public int kvadratMeter { get; set; }

        //public Room RoomDivider(string userInput)
        //{
        //    string[] userInputSplit = userInput.Split('|');

        //    List<Room> Rummen = new List<Room>();

        //    foreach (var item in userInputSplit)
        //    {
        //        string[] secondSplit = item.Split();
        //        string[] thirdSplit = secondSplit[1].Split('m');
        //        var namn = secondSplit[0];
        //        //var kvadrat = int.Parse(thirdSplit[0]);

        //        var Rum = new Room();

        //        Rum.name = namn;
        //        //Rum.kvadratMeter = kvadrat;

        //        return Rum;

        //    }
            
        //}

    }
}
