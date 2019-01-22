using System;

namespace Collatz_Conjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int turns = 0;
            bool run = true;

            while(run)
            {
                if (n % 2 == 1)
                {
                    n = n * 3 + 1;
                    turns++;
                }
                else
                {
                    n /= 2;
                    turns++;
                }

                if (n == 1)
                    run = false;
            }

            Console.WriteLine("It took " + turns + " turns for n to reach 1.");
        }
    }
}
