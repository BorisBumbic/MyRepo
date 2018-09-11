using System;

namespace CodeAlongDBquick
{
    class Program
    {
        static FruitContext context = new FruitContext();
        static void Main(string[] args)
        {
            //context.Database.EnsureCreated();
            //context.Database.EnsureDeleted();
            //context.SaveChanges();
            //AddFruit();
            //DisplayFruits();
        }

        static public void AddFruit()
        {
            var frulle = new Fruit()
            {
                Name = "äpple",
                Price = 11.7M,
                Colour = "grön"

            };
            context.Add(frulle);
            context.SaveChanges();
        }

        static public void DisplayFruits()
        {
            foreach (var item in context.Fruits)
            {
                Console.WriteLine(item.Name.PadRight(15) + item.Price.ToString().PadRight(15) + item.Colour.PadRight(15));
            }
        }
    }
}
