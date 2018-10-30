using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11._2_Work_with_list_of_Customers
{
    class Program
    {
        static void Main(string[] args)
        {
            var Customers = new List<Customer>();

            Customers=Customer.CustomerListMaker(File.ReadAllLines("PeopleList.txt"));

            var showList = Customers.OrderBy(x => x.firstName);

            foreach (var item in showList)
            {
                Console.WriteLine(item.firstName.ToUpper() + "  " + item.age);
            }

            var nextList = Customers.OrderBy(x => x.age);

            foreach (var item in nextList)
            {
                if (item.age > 50)
                    Console.WriteLine(item.lastName + "  " + item.age);
            }

            foreach (var i in Customers)
            {
                int a = i.age + 1000;

                Console.WriteLine(a + "\n");

            }
            


            }

        }
    
}
