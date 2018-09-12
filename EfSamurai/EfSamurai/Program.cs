using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfSamurai
{
    class Program
    {

        static void Main(string[] args)
        {
            //AddSamurai();
            //AddSomeSamurais();
            //RemoveAllSamurais();
            //AddSomeBattles();
            //DisplayAllBattles();
            List<string> namesWithAlias = AllSamuraiNameWithAlias();
            DisplayList(namesWithAlias);
        }

        private static List<string> AllSamuraiNameWithAlias()
        {
            var context = new SamuraiContext();

            List<string> stringList = context.Samurais.Include(SecretIdentities).Select(x => x.name +" alias " + x.sec ).ToList();

            return stringList;
        }

        public static void AddSamurai()
        {
            var context = new SamuraiContext();
            Samurai Jack = new Samurai { name = "Jack" };

            context.Samurais.Add(Jack);
            context.SaveChanges();

        }
        public static void DisplayAllSamurais()
        {
            var context = new SamuraiContext();
            foreach (var item in context.Samurais)
            {
                Console.WriteLine(item.name);
            }
        }
        public static void AddSomeSamurais()
        {
            var context = new SamuraiContext();
            var samuraiList = new List<Samurai>
            {
                new Samurai {name= "Gizmo", haircut = Haircut.Bald},
                new Samurai {name= "FizzyTaco", haircut = Haircut.Manbun},
                new Samurai {name = "Göran", haircut = Haircut.Unkept}
            };
            context.Samurais.AddRange(samuraiList);
            context.SaveChanges();
        }
        public static void RemoveAllSamurais()
        {
            var context = new SamuraiContext();
            foreach (var item in context.Samurais)
            {
                context.Remove(item);
            }
            context.SaveChanges();
        }
        public static void AddSomeBattles()
        {
            var context = new SamuraiContext();
            var list = new List<Battle>
            {
                new Battle { name= "Slaget vid kista", brutal = true, startDate = DateTime.Now, endDate = DateTime.Now.AddDays(6), log = new BattleLog {name = "the boring diary" } },
                new Battle { name= "Slaget vid rökrutan", brutal = false, startDate = DateTime.Now.AddDays(10), endDate = DateTime.Now.AddDays(17), log = new BattleLog {name = "the smokers diary" } },
                new Battle { name= "Slaget vid kullen", brutal = true, startDate = DateTime.Now, endDate = DateTime.Now.AddDays(6), log = new BattleLog {name = "the samurai diary" } }
            };
            context.Battle.AddRange(list);
            context.SaveChanges();
        }
        public static void DisplayAllBattles()
        {
            var context = new SamuraiContext();
            foreach (var item in context.Battle)
            {
                Console.WriteLine(item.name);
            }
        }

    }
}
