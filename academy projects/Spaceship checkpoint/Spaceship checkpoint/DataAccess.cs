using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spaceship_checkpoint
{
    class DataAccess
    {
        public void RecreateDatabase()
        {
            using (var context = new SpaceContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }

        public List<Spaceship> GetAllSpaceships()
        {
            var context = new SpaceContext();

            return context.Spaceships.ToList();
        }

        public void DisplaySpaceships(List<Spaceship> spaceList)
        {
            var context = new SpaceContext();
            foreach (var item in spaceList)
            {
                Console.WriteLine(item.name);

                foreach (Ravioli meti in context.RavioliSupply.Where(x=>x.Spaceship.name == item.name))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    for (int i = meti.Quantity; i > 0; i--)
                    {
                        Console.WriteLine("Ravioli  " + "Packdatum: " + meti.packDate + "  Bäst före: " + meti.expDate);
                    }
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        public void AddSpaceship(string namn)
        {
            var context = new SpaceContext();

            var ship = new Spaceship { name = namn };

            context.Spaceships.Add(ship);
            context.SaveChanges();
        }

        public void AddRavioliForSpaceship(string shipName, int qty, string date)
        {
            var context = new SpaceContext();

            DateTime newDate = DateTime.Parse(date);

            try
            {
                var ravioli = new Ravioli
                {
                    Quantity = qty,
                    Spaceship = context.Spaceships.Where(x => x.name == shipName).First(),
                    packDate = newDate,
                    expDate = newDate.AddMonths(6).AddDays(15)
                };

                context.RavioliSupply.Add(ravioli);
                context.SaveChanges();
            }
            catch { }
        }
    }
}
