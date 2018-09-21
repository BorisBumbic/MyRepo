using System;
using System.Collections.Generic;

namespace Spaceship_checkpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataaccess = new DataAccess();
            dataaccess.RecreateDatabase();

            dataaccess.AddSpaceship("USS Enterprise");
            dataaccess.AddSpaceship("Millennium Falcon");
            dataaccess.AddSpaceship("Cylon Raider");

            dataaccess.AddRavioliForSpaceship("Cylon Raider", 1, "2018-04-19");
            dataaccess.AddRavioliForSpaceship("Millennium Falcon", 1, "2017-01-01");
            dataaccess.AddRavioliForSpaceship("Millennium Falcon", 2, "2018-01-01");
            dataaccess.AddRavioliForSpaceship("Nalle Puh", 99, "1950-01-01");

            List<Spaceship> list = dataaccess.GetAllSpaceships();
            dataaccess.DisplaySpaceships(list);
        }
    }
}
