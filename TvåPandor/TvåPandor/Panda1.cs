    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvåPandor
{
    class Panda1
    {
        public void Display3and5()
        {
            Console.WriteLine("Enter a number.");
            int userInput = int.Parse(Console.ReadLine());

            int counter = 0;

            while (counter <= userInput)
            {
                if (counter > 0 && counter % 3 == 0 || counter % 5 == 0)
                {
                    Console.Write(counter + " ");
                }
               
                counter++;
            }
        }
        
        public void SumOrProduct()
        {
            Console.WriteLine("Enter a number.");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a '+' or '*' depending on if you want to add or multiply all the numbers leading up to your entered number.");
            string addMultiply = Console.ReadLine();
            int saveValue = 1;

            switch(addMultiply)
            {
                case "+":
                    for (int i = 2; i <= userInput; i++)
                    {
                        saveValue += i;
                    }
                    break;
                case "*":
                    for (int i = 1; i <= userInput; i++)
                    {
                        saveValue *= i;
                    }
                    break;
                    default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            Console.WriteLine(saveValue);
        }
        public void Twelve()
        {
            Console.WriteLine("Enter a number.");
            int userInput = int.Parse(Console.ReadLine());
            int counter = 1;

            Console.WriteLine("*******************************");

            while (counter <= userInput)
            {
                Console.WriteLine(12 * counter);
                counter++;
            }

        }

        public void Palindrome()
        {
            Console.WriteLine("Enter a word.");
            string userInput = Console.ReadLine();

            char[] array = userInput.ToCharArray();
            char[] arrayPal = userInput.ToCharArray();

            Array.Reverse(arrayPal);
            string check = new string(arrayPal);

            if(userInput == check)
                Console.WriteLine("The word is a palindrome.");
            else
                Console.WriteLine("The word is not a palindrome.");

        }
        public void TwoLists()
        {
            List<string> StringList = new List<string> { "a", "b", "c", "d" };
            List<int> IntList = new List<int> { 1, 2, 3, 4 };
            int counter = 1; 
            foreach (var item in IntList)
            {
                StringList.Insert(counter, Convert.ToString(item));
                counter += +2;
                
            }

            foreach (var item in StringList)
            {
                Console.Write(item + ",");
            }
        }

        public void RotateList()
        {
            Console.WriteLine("Enter a number.");
            List<int> IntLista = new List<int> {1, 2, 3, 4 ,5, 6 };
            int userInput = int.Parse(Console.ReadLine());
            var SkippedList = IntLista.Skip(userInput);
            var RestList = IntLista.Take(userInput);
                
                foreach (var item in SkippedList)
                {
                    Console.WriteLine(item);
                }
                foreach (var item in RestList)
                {
                    Console.WriteLine(item);
                }
            
        }

        public void Fibbonacci()
        {
            decimal one = 1;
            decimal two = 1;
            int counter = 100;
            
            while (counter > 0)
            {
                Console.WriteLine(one);
                Console.WriteLine(two);

                one += two;
                two += one;

                counter--;
            }
        }

        public void PrintHW()
        {
            List<string> StringList = new List<string>() { "Hello", "World", "in", "a", "frame"};

            Console.WriteLine("**************");

            foreach (var item in StringList)
            {
                Console.WriteLine($"*   {item.PadRight(9)}*");
            }
            Console.WriteLine("**************");
        }


    }
}
