using System;
using System.Collections.Generic;

namespace SortincExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(5);
            list.Add(3);
            list.Add(9);
            list.Add(1);

            bool needsSort = true;
            int placeholder;

            for (int i = 0; i < list.Count - 1 && needsSort; i++)
            {
                needsSort = false;

                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] < list[j+1])
                    {
                        placeholder = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = placeholder;
                        needsSort = true;
                    }

                }

            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
         

        }
    }
}
