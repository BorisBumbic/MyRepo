using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicktesting
{
    class Program
    {
        Member Uno = new Member();
        static void Main(string[] args)
        {

            List<Member> UnoList = new List<Member>(4);

            foreach (var item in UnoList)
            {
                item.name += "15";
                item.id += 2000;
            }

            UnoList.ForEach( id => Console.WriteLine(id));



            Console.ReadKey();
        }
            

    }
}

