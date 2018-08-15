using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Animal_exceptions
{
    class Program
    {
        public static void Method(string[] lista)
        {
            Regex aa = new Regex(@"^[a-zA-zåäö]+$");
            for (int i = 0; i < lista.Length; i++)
            {
                if (!aa.Match(lista[i]).Success)
                    throw new ArgumentException($"Ogiltiga/inga tecken på plats {i++} i listan!");

                if (lista[i].Length > 20)
                    throw new ArgumentException($"Input nummer {i++} är för lång!");

                Console.WriteLine(lista[i]);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of animals separated bya a coma.");

            string animalList = Console.ReadLine();

            string[] animalFarm = animalList.Split(',');

            try
            {
                Method(animalFarm);
            }
            catch (ArgumentException argexc)
            {
                Console.WriteLine(argexc.Message);
            }

        }
    }
}
