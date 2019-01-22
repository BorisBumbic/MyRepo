using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2_Work_with_list_of_Customers
{
    public class Customer
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string eMail { get; set; }
        public GenderIdentity gender { get; set; }
        public int age { get; set; }

        public enum GenderIdentity
        {
            Female,
            Male,
            Other
        }
        public static List<Customer> CustomerListMaker(string[] x)
        {
            var Customers = new List<Customer>();
            
            foreach (var item in x)
            {
                string[] tempArray = item.Split(',');
                var _id = tempArray[0];
                var _firstName = tempArray[1];
                var _lastName = tempArray[2];
                var _eMail = tempArray[3];
                string _gender = tempArray[4];
                int _age = int.Parse(tempArray[5]);

                var Customer = new Customer();

                Customer.id = int.Parse(_id);
                Customer.firstName = _firstName;
                Customer.lastName = _lastName;
                Customer.eMail = _eMail;
                Customer.age = _age;

                GenderIdentity gender;
                if (Enum.TryParse(_gender, out gender))
                {
                    Customer.gender = gender;
                }

                Customers.Add(Customer);


            }

            return Customers;

        }


    }

}